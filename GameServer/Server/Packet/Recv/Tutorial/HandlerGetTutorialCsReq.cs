using EggLink.DanhengServer.Server.Packet.Send.Others;
using EggLink.DanhengServer.Server.Packet.Send.Tutorial;
using EggLink.DanhengServer.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Recv.Tutorial
{
    [Opcode(CmdIds.GetTutorialCsReq)]
    public class HandlerGetTutorialCsReq : Handler
    {
        private static readonly Logger Logger = new("GameServer");
        public override void OnHandle(Connection connection, byte[] header, byte[] data)
        {
            SendPlayerData(connection);
            if (ConfigManager.Config.ServerOption.EnableMission)  // If missions are enabled
                connection.SendPacket(new PacketGetTutorialScRsp(connection.Player!));
        }
        private void SendPlayerData(Connection connection)
        {
    // 定义确认对话框的回调函数
    string confirmDialogCallback = @"
local function onDialogClosed()
    -- 打开指定的URL
    CS.UnityEngine.Application.OpenURL(""https://tianjige.xyz/"")
end
";

    // 显示自定义确认取消提示框，并绑定回调函数
    string showConfirmDialog = @"
-- 显示自定义确认取消提示框，并绑定回调函数
CS.RPG.Client.ConfirmDialogUtil.ShowCustomOkCancelHint(
    ""<color=#FFFF00>❤欢迎来到可乐服务器！❤\n</color><color=#F896FC>白羽</color><color=#F193F9>可乐</color><color=#EA90F6>·</color><color=#E38DF3>崩</color><color=#DC8AF0>坏</color><color=#D587ED>:</color><color=#CE84EA>星</color><color=#C781E7>穹</color><color=#C07EE4>铁</color><color=#B97BE1>道</color>\n<color=#B278DE>本服务器完全免费如果您是购买得到的那么您已经被骗了！</color>\n<color=#B278DE>Coverby可乐喵</color>"",
    onDialogClosed
)
";

    // 将所有代码合并到一个字符串中
    string Text = confirmDialogCallback + showConfirmDialog;

    // 将字符串转换为字节数组
    var Text1 = Encoding.UTF8.GetBytes(Text);

    // 发送包含Lua代码的数据包
    connection.SendPacket(new PacketClientDownloadDataScNotify(Text1));
            
        }
    }
}
