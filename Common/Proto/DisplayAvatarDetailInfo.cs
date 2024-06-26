// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DisplayAvatarDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DisplayAvatarDetailInfo.proto</summary>
  public static partial class DisplayAvatarDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DisplayAvatarDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayAvatarDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1EaXNwbGF5QXZhdGFyRGV0YWlsSW5mby5wcm90bxoaRGlzcGxheUVxdWlw",
            "bWVudEluZm8ucHJvdG8aFUF2YXRhclNraWxsVHJlZS5wcm90bxoWRGlzcGxh",
            "eVJlbGljSW5mby5wcm90byKKAgoXRGlzcGxheUF2YXRhckRldGFpbEluZm8S",
            "FwoPZHJlc3NlZF9za2luX2lkGA8gASgNEgwKBHJhbmsYBSABKA0SCwoDcG9z",
            "GA4gASgNEhEKCWF2YXRhcl9pZBgLIAEoDRIoCg5za2lsbHRyZWVfbGlzdBgG",
            "IAMoCzIQLkF2YXRhclNraWxsVHJlZRINCgVsZXZlbBgMIAEoDRIlCgpyZWxp",
            "Y19saXN0GAggAygLMhEuRGlzcGxheVJlbGljSW5mbxIRCglwcm9tb3Rpb24Y",
            "BCABKA0SKAoJZXF1aXBtZW50GAIgASgLMhUuRGlzcGxheUVxdWlwbWVudElu",
            "Zm8SCwoDZXhwGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DisplayEquipmentInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.AvatarSkillTreeReflection.Descriptor, global::EggLink.DanhengServer.Proto.DisplayRelicInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo), global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo.Parser, new[]{ "DressedSkinId", "Rank", "Pos", "AvatarId", "SkilltreeList", "Level", "RelicList", "Promotion", "Equipment", "Exp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DisplayAvatarDetailInfo : pb::IMessage<DisplayAvatarDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DisplayAvatarDetailInfo> _parser = new pb::MessageParser<DisplayAvatarDetailInfo>(() => new DisplayAvatarDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DisplayAvatarDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayAvatarDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayAvatarDetailInfo(DisplayAvatarDetailInfo other) : this() {
      dressedSkinId_ = other.dressedSkinId_;
      rank_ = other.rank_;
      pos_ = other.pos_;
      avatarId_ = other.avatarId_;
      skilltreeList_ = other.skilltreeList_.Clone();
      level_ = other.level_;
      relicList_ = other.relicList_.Clone();
      promotion_ = other.promotion_;
      equipment_ = other.equipment_ != null ? other.equipment_.Clone() : null;
      exp_ = other.exp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayAvatarDetailInfo Clone() {
      return new DisplayAvatarDetailInfo(this);
    }

    /// <summary>Field number for the "dressed_skin_id" field.</summary>
    public const int DressedSkinIdFieldNumber = 15;
    private uint dressedSkinId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DressedSkinId {
      get { return dressedSkinId_; }
      set {
        dressedSkinId_ = value;
      }
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 5;
    private uint rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 14;
    private uint pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 11;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "skilltree_list" field.</summary>
    public const int SkilltreeListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AvatarSkillTree> _repeated_skilltreeList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.AvatarSkillTree.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree> skilltreeList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree> SkilltreeList {
      get { return skilltreeList_; }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 12;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "relic_list" field.</summary>
    public const int RelicListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DisplayRelicInfo> _repeated_relicList_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.DisplayRelicInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayRelicInfo> relicList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayRelicInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayRelicInfo> RelicList {
      get { return relicList_; }
    }

    /// <summary>Field number for the "promotion" field.</summary>
    public const int PromotionFieldNumber = 4;
    private uint promotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Promotion {
      get { return promotion_; }
      set {
        promotion_ = value;
      }
    }

    /// <summary>Field number for the "equipment" field.</summary>
    public const int EquipmentFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo equipment_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo Equipment {
      get { return equipment_; }
      set {
        equipment_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 10;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DisplayAvatarDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DisplayAvatarDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DressedSkinId != other.DressedSkinId) return false;
      if (Rank != other.Rank) return false;
      if (Pos != other.Pos) return false;
      if (AvatarId != other.AvatarId) return false;
      if(!skilltreeList_.Equals(other.skilltreeList_)) return false;
      if (Level != other.Level) return false;
      if(!relicList_.Equals(other.relicList_)) return false;
      if (Promotion != other.Promotion) return false;
      if (!object.Equals(Equipment, other.Equipment)) return false;
      if (Exp != other.Exp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DressedSkinId != 0) hash ^= DressedSkinId.GetHashCode();
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (Pos != 0) hash ^= Pos.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      hash ^= skilltreeList_.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= relicList_.GetHashCode();
      if (Promotion != 0) hash ^= Promotion.GetHashCode();
      if (equipment_ != null) hash ^= Equipment.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (equipment_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Equipment);
      }
      if (Promotion != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Promotion);
      }
      if (Rank != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Rank);
      }
      skilltreeList_.WriteTo(output, _repeated_skilltreeList_codec);
      relicList_.WriteTo(output, _repeated_relicList_codec);
      if (Exp != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Exp);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(AvatarId);
      }
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
      }
      if (Pos != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Pos);
      }
      if (DressedSkinId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DressedSkinId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (equipment_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Equipment);
      }
      if (Promotion != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Promotion);
      }
      if (Rank != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Rank);
      }
      skilltreeList_.WriteTo(ref output, _repeated_skilltreeList_codec);
      relicList_.WriteTo(ref output, _repeated_relicList_codec);
      if (Exp != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Exp);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(AvatarId);
      }
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
      }
      if (Pos != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Pos);
      }
      if (DressedSkinId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DressedSkinId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (DressedSkinId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DressedSkinId);
      }
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rank);
      }
      if (Pos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Pos);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      size += skilltreeList_.CalculateSize(_repeated_skilltreeList_codec);
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      size += relicList_.CalculateSize(_repeated_relicList_codec);
      if (Promotion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Promotion);
      }
      if (equipment_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Equipment);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DisplayAvatarDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.DressedSkinId != 0) {
        DressedSkinId = other.DressedSkinId;
      }
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.Pos != 0) {
        Pos = other.Pos;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      skilltreeList_.Add(other.skilltreeList_);
      if (other.Level != 0) {
        Level = other.Level;
      }
      relicList_.Add(other.relicList_);
      if (other.Promotion != 0) {
        Promotion = other.Promotion;
      }
      if (other.equipment_ != null) {
        if (equipment_ == null) {
          Equipment = new global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo();
        }
        Equipment.MergeFrom(other.Equipment);
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            if (equipment_ == null) {
              Equipment = new global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo();
            }
            input.ReadMessage(Equipment);
            break;
          }
          case 32: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 40: {
            Rank = input.ReadUInt32();
            break;
          }
          case 50: {
            skilltreeList_.AddEntriesFrom(input, _repeated_skilltreeList_codec);
            break;
          }
          case 66: {
            relicList_.AddEntriesFrom(input, _repeated_relicList_codec);
            break;
          }
          case 80: {
            Exp = input.ReadUInt32();
            break;
          }
          case 88: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
            break;
          }
          case 112: {
            Pos = input.ReadUInt32();
            break;
          }
          case 120: {
            DressedSkinId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            if (equipment_ == null) {
              Equipment = new global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo();
            }
            input.ReadMessage(Equipment);
            break;
          }
          case 32: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 40: {
            Rank = input.ReadUInt32();
            break;
          }
          case 50: {
            skilltreeList_.AddEntriesFrom(ref input, _repeated_skilltreeList_codec);
            break;
          }
          case 66: {
            relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
            break;
          }
          case 80: {
            Exp = input.ReadUInt32();
            break;
          }
          case 88: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
            break;
          }
          case 112: {
            Pos = input.ReadUInt32();
            break;
          }
          case 120: {
            DressedSkinId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
