﻿using System.Reflection;
using EggLink.DanhengServer.Data.Config;
using EggLink.DanhengServer.Data.Custom;
using EggLink.DanhengServer.Data.Excel;
using EggLink.DanhengServer.Enums.Rogue;
using EggLink.DanhengServer.Internationalization;
using EggLink.DanhengServer.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EggLink.DanhengServer.Data;

public class ResourceManager
{
    public static Logger Logger { get; } = new("ResourceManager");

    public static void LoadGameData()
    {
        LoadExcel();
        LoadFloorInfo();
        LoadMissionInfo();
        LoadMazeSkill();
        LoadDialogueInfo();
        LoadPerformanceInfo();
        LoadSubMissionInfo();
        LoadRogueChestMapInfo();
        GameData.ActivityConfig = LoadCustomFile<ActivityConfig>("Activity", "ActivityConfig") ?? new ActivityConfig();
        GameData.BannersConfig = LoadCustomFile<BannersConfig>("Banner", "Banners") ?? new BannersConfig();
        GameData.RogueMapGenData = LoadCustomFile<Dictionary<int, List<int>>>("Rogue Map", "RogueMapGen") ?? [];
        GameData.RogueMiracleGroupData =
            LoadCustomFile<Dictionary<int, List<int>>>("Rogue Miracle Group", "RogueMiracleGroup") ?? [];
        GameData.RogueMiracleEffectData =
            LoadCustomFile<RogueMiracleEffectConfig>("Rogue Miracle Effect", "RogueMiracleEffectGen") ??
            new RogueMiracleEffectConfig();
        LoadChessRogueRoomData();
    }

    public static void LoadExcel()
    {
        var classes = Assembly.GetExecutingAssembly().GetTypes(); // Get all classes in the assembly
        var resList = new List<ExcelResource>();
        foreach (var cls in classes)
        {
            var attribute = (ResourceEntity)Attribute.GetCustomAttribute(cls, typeof(ResourceEntity))!;

            if (attribute != null)
            {
                var resource = (ExcelResource)Activator.CreateInstance(cls)!;
                var count = 0;
                foreach (var fileName in attribute.FileName)
                    try
                    {
                        var path = ConfigManager.Config.Path.ResourcePath + "/ExcelOutput/" + fileName;
                        var file = new FileInfo(path);
                        if (!file.Exists)
                        {
                            Logger.Error(I18nManager.Translate("Server.ServerInfo.FailedToReadItem", fileName,
                                I18nManager.Translate("Word.NotFound")));
                            continue;
                        }

                        var json = file.OpenText().ReadToEnd();
                        using (var reader = new JsonTextReader(new StringReader(json)))
                        {
                            reader.Read();
                            if (reader.TokenType == JsonToken.StartArray)
                            {
                                // array
                                var jArray = JArray.Parse(json);
                                foreach (var item in jArray)
                                {
                                    var res = JsonConvert.DeserializeObject(item.ToString(), cls);
                                    resList.Add((ExcelResource)res!);
                                    ((ExcelResource?)res)?.Loaded();
                                    count++;
                                }
                            }
                            else if (reader.TokenType == JsonToken.StartObject)
                            {
                                // dictionary
                                var jObject = JObject.Parse(json);
                                foreach (var item in jObject)
                                {
                                    var id = int.Parse(item.Key);
                                    var obj = item.Value;
                                    var instance = JsonConvert.DeserializeObject(obj!.ToString(), cls);

                                    if (((ExcelResource?)instance)?.GetId() == 0 || (ExcelResource?)instance == null)
                                    {
                                        // Deserialize as JObject to handle nested dictionaries
                                        var nestedObject = JsonConvert.DeserializeObject<JObject>(obj.ToString());

                                        foreach (var nestedItem in nestedObject ?? [])
                                        {
                                            var nestedInstance =
                                                JsonConvert.DeserializeObject(nestedItem.Value!.ToString(), cls);
                                            resList.Add((ExcelResource)nestedInstance!);
                                            ((ExcelResource?)nestedInstance)?.Loaded();
                                            count++;
                                        }
                                    }
                                    else
                                    {
                                        resList.Add((ExcelResource)instance!);
                                        ((ExcelResource)instance).Loaded();
                                    }

                                    count++;
                                }
                            }
                        }

                        resource.Finalized();
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(
                            I18nManager.Translate("Server.ServerInfo.FailedToReadItem", fileName,
                                I18nManager.Translate("Word.Error")), ex);
                    }

                Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(), cls.Name));
            }
        }

        foreach (var cls in resList) cls.AfterAllDone();
    }

    public static void LoadFloorInfo()
    {
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem", I18nManager.Translate("Word.FloorInfo")));
        DirectoryInfo directory = new(ConfigManager.Config.Path.ResourcePath + "/Config/LevelOutput/RuntimeFloor/");
        var missingGroupInfos = false;

        if (!directory.Exists)
        {
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.ConfigMissing",
                I18nManager.Translate("Word.FloorInfo"),
                $"{ConfigManager.Config.Path.ResourcePath}/Config/LevelOutput/RuntimeFloor",
                I18nManager.Translate("Word.FloorMissingResult")));
            return;
        }

        // Load floor infos
        foreach (var file in directory.GetFiles())
            try
            {
                using var reader = file.OpenRead();
                using StreamReader reader2 = new(reader);
                var text = reader2.ReadToEnd();
                var info = JsonConvert.DeserializeObject<FloorInfo>(text);
                var name = file.Name[..file.Name.IndexOf('.')];
                GameData.FloorInfoData.Add(name, info!);
            }
            catch (Exception ex)
            {
                Logger.Error(
                    I18nManager.Translate("Server.ServerInfo.FailedToReadItem", file.Name,
                        I18nManager.Translate("Word.Error")), ex);
            }

        foreach (var info in GameData.FloorInfoData.Values)
        {
            foreach (var groupInfo in info.GroupInstanceList)
            {
                if (groupInfo.IsDelete) continue;
                FileInfo file = new(ConfigManager.Config.Path.ResourcePath + "/" + groupInfo.GroupPath);
                if (!file.Exists) continue;
                try
                {
                    using var reader = file.OpenRead();
                    using StreamReader reader2 = new(reader);
                    var text = reader2.ReadToEnd();
                    var group = JsonConvert.DeserializeObject<GroupInfo>(text);
                    if (group != null)
                    {
                        group.Id = groupInfo.ID;
                        info.Groups.TryAdd(groupInfo.ID, group);
                        group.Load();

                        // load graph
                        var graphPath = ConfigManager.Config.Path.ResourcePath + "/" + group.LevelGraph;
                        var graphFile = new FileInfo(graphPath);
                        if (graphFile.Exists)
                        {
                            using var graphReader = graphFile.OpenRead();
                            using StreamReader graphReader2 = new(graphReader);
                            var graphText = graphReader2.ReadToEnd().Replace("$type", "Type");
                            var graphObj = JObject.Parse(graphText);
                            if (graphObj != null)
                            {
                                var graphInfo = LevelGraphConfigInfo.LoadFromJsonObject(graphObj);
                                group.LevelGraphConfig = graphInfo;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error(
                        I18nManager.Translate("Server.ServerInfo.FailedToReadItem", file.Name,
                            I18nManager.Translate("Word.Error")), ex);
                }

                if (info.Groups.Count == 0) missingGroupInfos = true;
            }

            info.OnLoad();
        }

        if (missingGroupInfos)
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.ConfigMissing",
                I18nManager.Translate("Word.FloorGroupInfo"),
                $"{ConfigManager.Config.Path.ResourcePath}/Config/LevelOutput/SharedRuntimeGroup",
                I18nManager.Translate("Word.FloorGroupMissingResult")));

        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", GameData.FloorInfoData.Count.ToString(),
            I18nManager.Translate("Word.FloorInfo")));
    }

    public static void LoadMissionInfo()
    {
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem", I18nManager.Translate("Word.MissionInfo")));
        DirectoryInfo directory = new(ConfigManager.Config.Path.ResourcePath + "/Config/Level/Mission");
        if (!directory.Exists)
        {
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.ConfigMissing",
                I18nManager.Translate("Word.MissionInfo"),
                $"{ConfigManager.Config.Path.ResourcePath}/Config/Level/Mission",
                I18nManager.Translate("Word.Mission")));
            return;
        }

        var missingMissionInfos = false;
        var count = 0;
        foreach (var missionExcel in GameData.MainMissionData)
        {
            var path =
                $"{ConfigManager.Config.Path.ResourcePath}/Config/Level/Mission/{missionExcel.Key}/MissionInfo_{missionExcel.Key}.json";
            if (!File.Exists(path))
            {
                missingMissionInfos = true;
                continue;
            }

            var json = File.ReadAllText(path);
            var missionInfo = JsonConvert.DeserializeObject<MissionInfo>(json);
            if (missionInfo != null)
            {
                GameData.MainMissionData[missionExcel.Key].MissionInfo = missionInfo;
                foreach (var subMission in missionInfo.SubMissionList)
                {
                    // load mission json
                    var missionJsonPath = ConfigManager.Config.Path.ResourcePath + "/" + subMission.MissionJsonPath;
                    if (File.Exists(missionJsonPath))
                    {
                        var missionJson = File.ReadAllText(missionJsonPath).Replace("$type", "Type");
                    }
                }

                count++;
            }
            else
            {
                missingMissionInfos = true;
            }
        }

        if (missingMissionInfos)
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.ConfigMissing",
                I18nManager.Translate("Word.MissionInfo"),
                $"{ConfigManager.Config.Path.ResourcePath}/Config/Level/Mission",
                I18nManager.Translate("Word.Mission")));
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(),
            I18nManager.Translate("Word.MissionInfo")));
    }

    public static T? LoadCustomFile<T>(string filetype, string filename)
    {
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem", filetype));
        FileInfo file = new(ConfigManager.Config.Path.ConfigPath + $"/{filename}.json");
        T? customFile = default;
        if (!file.Exists)
        {
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.ConfigMissing", filetype,
                $"{ConfigManager.Config.Path.ConfigPath}/{filename}.json", filetype));
            return customFile;
        }

        try
        {
            using var reader = file.OpenRead();
            using StreamReader reader2 = new(reader);
            var text = reader2.ReadToEnd();
            var json = JsonConvert.DeserializeObject<T>(text);
            customFile = json;
        }
        catch (Exception ex)
        {
            Logger.Error("Error in reading " + file.Name, ex);
        }

        if (customFile is Dictionary<int, int> d)
            Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", d.Count.ToString(), filetype));
        else if (customFile is Dictionary<int, List<int>> di)
            Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", di.Count.ToString(), filetype));
        else if (customFile is BannersConfig c)
            Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", c.Banners.Count.ToString(), filetype));
        else if (customFile is RogueMiracleEffectConfig r)
            Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", r.Miracles.Count.ToString(), filetype));
        else if (customFile is ActivityConfig a)
            Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", a.ScheduleData.Count.ToString(),
                filetype));
        else
            Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItem", filetype));

        return customFile;
    }

    public static void LoadMazeSkill()
    {
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem",
            I18nManager.Translate("Word.MazeSkillInfo")));
        var count = 0;
        foreach (var adventure in GameData.AdventurePlayerData.Values)
        {
            var avatar = GameData.AvatarConfigData[adventure.AvatarID];
            var adventurePath = adventure.PlayerJsonPath.Replace("_Config.json", "_Ability.json")
                .Replace("ConfigCharacter", "ConfigAdventureAbility");
            var path = ConfigManager.Config.Path.ResourcePath + "/" + adventurePath;
            var file = new FileInfo(path);
            if (!file.Exists) continue;
            try
            {
                using var reader = file.OpenRead();
                using StreamReader reader2 = new(reader);
                var text = reader2.ReadToEnd().Replace("$type", "Type");
                var skillAbilityInfo = JsonConvert.DeserializeObject<SkillAbilityInfo>(text);
                skillAbilityInfo?.Loaded(avatar);
                count += skillAbilityInfo == null ? 0 : 1;
            }
            catch (Exception ex)
            {
                Logger.Error(
                    I18nManager.Translate("Server.ServerInfo.FailedToReadItem", adventurePath,
                        I18nManager.Translate("Word.Error")), ex);
            }
        }

        if (count < GameData.AdventurePlayerData.Count)
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.ConfigMissing",
                I18nManager.Translate("Word.MazeSkillInfo"),
                $"{ConfigManager.Config.Path.ResourcePath}/Config/Level/AdventureAbility",
                I18nManager.Translate("Word.MazeSkill")));

        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(),
            I18nManager.Translate("Word.MazeSkillInfo")));
    }

    public static void LoadDialogueInfo()
    {
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem", I18nManager.Translate("Word.DialogueInfo")));
        var count = 0;
        foreach (var dialogue in GameData.RogueNPCDialogueData)
        {
            var path = ConfigManager.Config.Path.ResourcePath + "/" + dialogue.Value.DialoguePath;
            var file = new FileInfo(path);
            if (!file.Exists) continue;
            try
            {
                using var reader = file.OpenRead();
                using StreamReader reader2 = new(reader);
                var text = reader2.ReadToEnd().Replace("$type", "Type");
                var dialogueInfo = JsonConvert.DeserializeObject<DialogueInfo>(text);
                if (dialogueInfo != null)
                {
                    dialogue.Value.DialogueInfo = dialogueInfo;
                    dialogueInfo.Loaded();
                    if (dialogueInfo.DialogueIds.Count == 0)
                        // set to invalid
                        dialogue.Value.DialogueInfo = null;
                    count++;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(
                    I18nManager.Translate("Server.ServerInfo.FailedToReadItem", file.Name,
                        I18nManager.Translate("Word.Error")), ex);
            }
        }

        if (count < GameData.RogueNPCDialogueData.Count)
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.ConfigMissing",
                I18nManager.Translate("Word.DialogueInfo"),
                $"{ConfigManager.Config.Path.ResourcePath}/Config/Level/Rogue/Dialogue",
                I18nManager.Translate("Word.Dialogue")));

        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(),
            I18nManager.Translate("Word.DialogueInfo")));
    }

    public static void LoadPerformanceInfo()
    {
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem",
            I18nManager.Translate("Word.PerformanceInfo")));
        var count = 0;
        foreach (var performance in GameData.PerformanceEData.Values)
        {
            if (performance.PerformancePath == "")
            {
                count++;
                continue;
            }

            var path = ConfigManager.Config.Path.ResourcePath + "/" + performance.PerformancePath;
            var file = new FileInfo(path);
            if (!file.Exists) continue;
            try
            {
                using var reader = file.OpenRead();
                using StreamReader reader2 = new(reader);
                var text = reader2.ReadToEnd().Replace("$type", "Type");
                var obj = JObject.Parse(text);
                if (obj != null)
                {
                    var info = LevelGraphConfigInfo.LoadFromJsonObject(obj);
                    performance.ActInfo = info;
                    count++;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(
                    I18nManager.Translate("Server.ServerInfo.FailedToReadItem", file.Name,
                        I18nManager.Translate("Word.Error")), ex);
            }
        }

        foreach (var performance in GameData.PerformanceDData.Values)
        {
            if (performance.PerformancePath == "")
            {
                count++;
                continue;
            }

            var path = ConfigManager.Config.Path.ResourcePath + "/" + performance.PerformancePath;
            var file = new FileInfo(path);
            if (!file.Exists) continue;
            try
            {
                using var reader = file.OpenRead();
                using StreamReader reader2 = new(reader);
                var text = reader2.ReadToEnd().Replace("$type", "Type");
                var obj = JObject.Parse(text);
                if (obj != null)
                {
                    var info = LevelGraphConfigInfo.LoadFromJsonObject(obj);
                    performance.ActInfo = info;
                    count++;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(
                    I18nManager.Translate("Server.ServerInfo.FailedToReadItem", file.Name,
                        I18nManager.Translate("Word.Error")), ex);
            }
        }

        if (count < GameData.PerformanceEData.Count + GameData.PerformanceDData.Count)
        {
            // looks like many dont exist
            //Logger.Warn("Performance infos are missing, please check your resources folder: " + ConfigManager.Config.Path.ResourcePath + "/Config/Level/Mission/*/Act. Performances may not work!");
        }

        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(),
            I18nManager.Translate("Word.PerformanceInfo")));
    }

    public static void LoadSubMissionInfo()
    {
        Logger.Info(
            I18nManager.Translate("Server.ServerInfo.LoadingItem", I18nManager.Translate("Word.SubMissionInfo")));
        var count = 0;
        foreach (var subMission in GameData.SubMissionData.Values)
        {
            if (subMission.SubMissionInfo == null || subMission.SubMissionInfo.MissionJsonPath == "") continue;

            var path = ConfigManager.Config.Path.ResourcePath + "/" + subMission.SubMissionInfo.MissionJsonPath;
            var file = new FileInfo(path);
            if (!file.Exists) continue;
            try
            {
                using var reader = file.OpenRead();
                using StreamReader reader2 = new(reader);
                var text = reader2.ReadToEnd().Replace("$type", "Type");
                var obj = JObject.Parse(text);
                if (obj != null)
                {
                    var info = LevelGraphConfigInfo.LoadFromJsonObject(obj);
                    subMission.SubMissionTaskInfo = info;
                    count++;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(
                    I18nManager.Translate("Server.ServerInfo.FailedToReadItem", file.Name,
                        I18nManager.Translate("Word.Error")), ex);
            }
        }

        if (count < GameData.SubMissionData.Count)
        {
            //Logger.Warn("Performance infos are missing, please check your resources folder: " + ConfigManager.Config.Path.ResourcePath + "/Config/Level/Mission/*/Act. Performances may not work!");
        }

        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(),
            I18nManager.Translate("Word.SubMissionInfo")));
    }

    public static void LoadRogueChestMapInfo()
    {
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem",
            I18nManager.Translate("Word.RogueChestMapInfo")));
        var count = 0;
        var boardList = new List<RogueDLCChessBoardExcel>();
        foreach (var nousMap in GameData.RogueNousChessBoardData.Values) boardList.AddRange(nousMap);

        foreach (var nousMap in GameData.RogueSwarmChessBoardData.Values) boardList.AddRange(nousMap);

        foreach (var board in boardList)
        {
            if (board.ChessBoardConfiguration == "")
            {
                count++;
                continue;
            }

            var path = ConfigManager.Config.Path.ResourcePath + "/" + board.ChessBoardConfiguration;

            var file = new FileInfo(path);
            if (!file.Exists) continue;
            try
            {
                using var reader = file.OpenRead();
                using StreamReader reader2 = new(reader);
                var text = reader2.ReadToEnd();
                var map = JsonConvert.DeserializeObject<RogueChestMapInfo>(text);
                if (map != null)
                {
                    board.MapInfo = map;
                    count++;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(
                    I18nManager.Translate("Server.ServerInfo.FailedToReadItem", file.Name,
                        I18nManager.Translate("Word.Error")), ex);
            }
        }

        if (count < boardList.Count)
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.ConfigMissing",
                I18nManager.Translate("Word.RogueChestMapInfo"),
                $"{ConfigManager.Config.Path.ResourcePath}/Config/Gameplays/RogueDLC",
                I18nManager.Translate("Word.RogueChestMap")));

        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(),
            I18nManager.Translate("Word.RogueChestMapInfo")));
    }

    public static void LoadChessRogueRoomData()
    {
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem",
            I18nManager.Translate("Word.ChessRogueRoomInfo")));
        var count = 0;

        FileInfo file = new(ConfigManager.Config.Path.ConfigPath + "/ChessRogueRoomGen.json");
        List<ChessRogueRoomConfig>? customFile;
        if (!file.Exists)
        {
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.ConfigMissing",
                I18nManager.Translate("Word.ChessRogueRoomInfo"),
                $"{ConfigManager.Config.Path.ConfigPath}/ChessRogueRoomGen.json",
                I18nManager.Translate("Word.ChessRogueRoom")));

            return;
        }

        try
        {
            using var reader = file.OpenRead();
            using StreamReader reader2 = new(reader);
            var text = reader2.ReadToEnd();
            var json = JsonConvert.DeserializeObject<List<ChessRogueRoomConfig>>(text);
            customFile = json;

            foreach (var room in customFile!)
                if (room.BlockType == RogueDLCBlockTypeEnum.MonsterNormal)
                {
                    AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterNormal, room);
                    AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterSwarm, room);
                    count += 2;
                }
                else if (room.BlockType == RogueDLCBlockTypeEnum.MonsterBoss)
                {
                    AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterBoss, room);
                    AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterNousBoss, room);
                    AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterSwarmBoss, room);
                    count += 3;
                }
                else if (room.BlockType == RogueDLCBlockTypeEnum.Event)
                {
                    AddRoomToGameData(RogueDLCBlockTypeEnum.Event, room);
                    AddRoomToGameData(RogueDLCBlockTypeEnum.Reward, room);
                    AddRoomToGameData(RogueDLCBlockTypeEnum.Adventure, room); // adventure is not this type
                    AddRoomToGameData(RogueDLCBlockTypeEnum.NousSpecialEvent, room);
                    AddRoomToGameData(RogueDLCBlockTypeEnum.SwarmEvent, room);
                    AddRoomToGameData(RogueDLCBlockTypeEnum.NousEvent, room);
                    count += 6;
                }
                else if (room.BlockType == RogueDLCBlockTypeEnum.Trade)
                {
                    AddRoomToGameData(RogueDLCBlockTypeEnum.Trade, room);
                    AddRoomToGameData(RogueDLCBlockTypeEnum.BlackMarket, room);
                    count += 2;
                }
                else
                {
                    AddRoomToGameData(room.BlockType, room);
                    count++;
                }
        }
        catch (Exception ex)
        {
            Logger.Error("Error in reading " + file.Name, ex);
        }

        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(),
            I18nManager.Translate("Word.ChessRogueRoomInfo")));
    }

    public static void AddRoomToGameData(RogueDLCBlockTypeEnum type, ChessRogueRoomConfig room)
    {
        if (GameData.ChessRogueRoomData.TryGetValue(type, out var list))
            list.Add(room);
        else
            GameData.ChessRogueRoomData.Add(type, [room]);
    }
}