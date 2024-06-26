// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FriendSimpleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FriendSimpleInfo.proto</summary>
  public static partial class FriendSimpleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FriendSimpleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FriendSimpleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGcmllbmRTaW1wbGVJbmZvLnByb3RvGhZQbGF5ZXJTaW1wbGVJbmZvLnBy",
            "b3RvGhVQbGF5ZXJTdGF0ZVR5cGUucHJvdG8aEUFMQ09FQU5JS0lMLnByb3Rv",
            "Iq0BChBGcmllbmRTaW1wbGVJbmZvEiYKC3BsYXllcl9pbmZvGAcgASgLMhEu",
            "UGxheWVyU2ltcGxlSW5mbxITCgtyZW1hcmtfbmFtZRgKIAEoCRImCgxwbGF5",
            "ZXJfc3RhdGUYBSABKA4yEC5QbGF5ZXJTdGF0ZVR5cGUSIQoLQ0ZNSUtMSEpN",
            "TEUYBiABKAsyDC5BTENPRUFOSUtJTBIRCglpc19tYXJrZWQYCSABKAhCHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerSimpleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.PlayerStateTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.ALCOEANIKILReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FriendSimpleInfo), global::EggLink.DanhengServer.Proto.FriendSimpleInfo.Parser, new[]{ "PlayerInfo", "RemarkName", "PlayerState", "CFMIKLHJMLE", "IsMarked" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FriendSimpleInfo : pb::IMessage<FriendSimpleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FriendSimpleInfo> _parser = new pb::MessageParser<FriendSimpleInfo>(() => new FriendSimpleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FriendSimpleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FriendSimpleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FriendSimpleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FriendSimpleInfo(FriendSimpleInfo other) : this() {
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      remarkName_ = other.remarkName_;
      playerState_ = other.playerState_;
      cFMIKLHJMLE_ = other.cFMIKLHJMLE_ != null ? other.cFMIKLHJMLE_.Clone() : null;
      isMarked_ = other.isMarked_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FriendSimpleInfo Clone() {
      return new FriendSimpleInfo(this);
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.PlayerSimpleInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerSimpleInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "remark_name" field.</summary>
    public const int RemarkNameFieldNumber = 10;
    private string remarkName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemarkName {
      get { return remarkName_; }
      set {
        remarkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "player_state" field.</summary>
    public const int PlayerStateFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.PlayerStateType playerState_ = global::EggLink.DanhengServer.Proto.PlayerStateType.PlayingStateNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerStateType PlayerState {
      get { return playerState_; }
      set {
        playerState_ = value;
      }
    }

    /// <summary>Field number for the "CFMIKLHJMLE" field.</summary>
    public const int CFMIKLHJMLEFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ALCOEANIKIL cFMIKLHJMLE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ALCOEANIKIL CFMIKLHJMLE {
      get { return cFMIKLHJMLE_; }
      set {
        cFMIKLHJMLE_ = value;
      }
    }

    /// <summary>Field number for the "is_marked" field.</summary>
    public const int IsMarkedFieldNumber = 9;
    private bool isMarked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMarked {
      get { return isMarked_; }
      set {
        isMarked_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FriendSimpleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FriendSimpleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (RemarkName != other.RemarkName) return false;
      if (PlayerState != other.PlayerState) return false;
      if (!object.Equals(CFMIKLHJMLE, other.CFMIKLHJMLE)) return false;
      if (IsMarked != other.IsMarked) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (RemarkName.Length != 0) hash ^= RemarkName.GetHashCode();
      if (PlayerState != global::EggLink.DanhengServer.Proto.PlayerStateType.PlayingStateNone) hash ^= PlayerState.GetHashCode();
      if (cFMIKLHJMLE_ != null) hash ^= CFMIKLHJMLE.GetHashCode();
      if (IsMarked != false) hash ^= IsMarked.GetHashCode();
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
      if (PlayerState != global::EggLink.DanhengServer.Proto.PlayerStateType.PlayingStateNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) PlayerState);
      }
      if (cFMIKLHJMLE_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CFMIKLHJMLE);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(PlayerInfo);
      }
      if (IsMarked != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsMarked);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(RemarkName);
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
      if (PlayerState != global::EggLink.DanhengServer.Proto.PlayerStateType.PlayingStateNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) PlayerState);
      }
      if (cFMIKLHJMLE_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CFMIKLHJMLE);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(PlayerInfo);
      }
      if (IsMarked != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsMarked);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(RemarkName);
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
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (RemarkName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemarkName);
      }
      if (PlayerState != global::EggLink.DanhengServer.Proto.PlayerStateType.PlayingStateNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PlayerState);
      }
      if (cFMIKLHJMLE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CFMIKLHJMLE);
      }
      if (IsMarked != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FriendSimpleInfo other) {
      if (other == null) {
        return;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::EggLink.DanhengServer.Proto.PlayerSimpleInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.RemarkName.Length != 0) {
        RemarkName = other.RemarkName;
      }
      if (other.PlayerState != global::EggLink.DanhengServer.Proto.PlayerStateType.PlayingStateNone) {
        PlayerState = other.PlayerState;
      }
      if (other.cFMIKLHJMLE_ != null) {
        if (cFMIKLHJMLE_ == null) {
          CFMIKLHJMLE = new global::EggLink.DanhengServer.Proto.ALCOEANIKIL();
        }
        CFMIKLHJMLE.MergeFrom(other.CFMIKLHJMLE);
      }
      if (other.IsMarked != false) {
        IsMarked = other.IsMarked;
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
          case 40: {
            PlayerState = (global::EggLink.DanhengServer.Proto.PlayerStateType) input.ReadEnum();
            break;
          }
          case 50: {
            if (cFMIKLHJMLE_ == null) {
              CFMIKLHJMLE = new global::EggLink.DanhengServer.Proto.ALCOEANIKIL();
            }
            input.ReadMessage(CFMIKLHJMLE);
            break;
          }
          case 58: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.PlayerSimpleInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 72: {
            IsMarked = input.ReadBool();
            break;
          }
          case 82: {
            RemarkName = input.ReadString();
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
          case 40: {
            PlayerState = (global::EggLink.DanhengServer.Proto.PlayerStateType) input.ReadEnum();
            break;
          }
          case 50: {
            if (cFMIKLHJMLE_ == null) {
              CFMIKLHJMLE = new global::EggLink.DanhengServer.Proto.ALCOEANIKIL();
            }
            input.ReadMessage(CFMIKLHJMLE);
            break;
          }
          case 58: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.PlayerSimpleInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 72: {
            IsMarked = input.ReadBool();
            break;
          }
          case 82: {
            RemarkName = input.ReadString();
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
