// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterMapRotationRegionScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterMapRotationRegionScRsp.proto</summary>
  public static partial class EnterMapRotationRegionScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterMapRotationRegionScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterMapRotationRegionScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFbnRlck1hcFJvdGF0aW9uUmVnaW9uU2NSc3AucHJvdG8aF1JvdGF0b3JF",
            "bmVyZ3lJbmZvLnByb3RvGhBNb3Rpb25JbmZvLnByb3RvIrcBChtFbnRlck1h",
            "cFJvdGF0aW9uUmVnaW9uU2NSc3ASGwoGbW90aW9uGAQgASgLMgsuTW90aW9u",
            "SW5mbxIPCgdyZXRjb2RlGAUgASgNEhAKCHJvdGF0aW9uGAggASgNEhMKC01O",
            "TkhQSkdMT0tNGAkgASgNEicKC2VuZXJneV9pbmZvGAwgASgLMhIuUm90YXRv",
            "ckVuZXJneUluZm8SGgoSY2xpZW50X3Bvc192ZXJzaW9uGA4gASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RotatorEnergyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterMapRotationRegionScRsp), global::EggLink.DanhengServer.Proto.EnterMapRotationRegionScRsp.Parser, new[]{ "Motion", "Retcode", "Rotation", "MNNHPJGLOKM", "EnergyInfo", "ClientPosVersion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterMapRotationRegionScRsp : pb::IMessage<EnterMapRotationRegionScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterMapRotationRegionScRsp> _parser = new pb::MessageParser<EnterMapRotationRegionScRsp>(() => new EnterMapRotationRegionScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterMapRotationRegionScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterMapRotationRegionScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterMapRotationRegionScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterMapRotationRegionScRsp(EnterMapRotationRegionScRsp other) : this() {
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      retcode_ = other.retcode_;
      rotation_ = other.rotation_;
      mNNHPJGLOKM_ = other.mNNHPJGLOKM_;
      energyInfo_ = other.energyInfo_ != null ? other.energyInfo_.Clone() : null;
      clientPosVersion_ = other.clientPosVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterMapRotationRegionScRsp Clone() {
      return new EnterMapRotationRegionScRsp(this);
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 8;
    private uint rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    /// <summary>Field number for the "MNNHPJGLOKM" field.</summary>
    public const int MNNHPJGLOKMFieldNumber = 9;
    private uint mNNHPJGLOKM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MNNHPJGLOKM {
      get { return mNNHPJGLOKM_; }
      set {
        mNNHPJGLOKM_ = value;
      }
    }

    /// <summary>Field number for the "energy_info" field.</summary>
    public const int EnergyInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RotatorEnergyInfo energyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RotatorEnergyInfo EnergyInfo {
      get { return energyInfo_; }
      set {
        energyInfo_ = value;
      }
    }

    /// <summary>Field number for the "client_pos_version" field.</summary>
    public const int ClientPosVersionFieldNumber = 14;
    private uint clientPosVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientPosVersion {
      get { return clientPosVersion_; }
      set {
        clientPosVersion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterMapRotationRegionScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterMapRotationRegionScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Motion, other.Motion)) return false;
      if (Retcode != other.Retcode) return false;
      if (Rotation != other.Rotation) return false;
      if (MNNHPJGLOKM != other.MNNHPJGLOKM) return false;
      if (!object.Equals(EnergyInfo, other.EnergyInfo)) return false;
      if (ClientPosVersion != other.ClientPosVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (motion_ != null) hash ^= Motion.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Rotation != 0) hash ^= Rotation.GetHashCode();
      if (MNNHPJGLOKM != 0) hash ^= MNNHPJGLOKM.GetHashCode();
      if (energyInfo_ != null) hash ^= EnergyInfo.GetHashCode();
      if (ClientPosVersion != 0) hash ^= ClientPosVersion.GetHashCode();
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
      if (motion_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Motion);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (Rotation != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Rotation);
      }
      if (MNNHPJGLOKM != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MNNHPJGLOKM);
      }
      if (energyInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(EnergyInfo);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ClientPosVersion);
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
      if (motion_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Motion);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (Rotation != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Rotation);
      }
      if (MNNHPJGLOKM != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MNNHPJGLOKM);
      }
      if (energyInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(EnergyInfo);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ClientPosVersion);
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
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (Rotation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rotation);
      }
      if (MNNHPJGLOKM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MNNHPJGLOKM);
      }
      if (energyInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnergyInfo);
      }
      if (ClientPosVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterMapRotationRegionScRsp other) {
      if (other == null) {
        return;
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Rotation != 0) {
        Rotation = other.Rotation;
      }
      if (other.MNNHPJGLOKM != 0) {
        MNNHPJGLOKM = other.MNNHPJGLOKM;
      }
      if (other.energyInfo_ != null) {
        if (energyInfo_ == null) {
          EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
        }
        EnergyInfo.MergeFrom(other.EnergyInfo);
      }
      if (other.ClientPosVersion != 0) {
        ClientPosVersion = other.ClientPosVersion;
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
          case 34: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            Rotation = input.ReadUInt32();
            break;
          }
          case 72: {
            MNNHPJGLOKM = input.ReadUInt32();
            break;
          }
          case 98: {
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
            break;
          }
          case 112: {
            ClientPosVersion = input.ReadUInt32();
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
          case 34: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            Rotation = input.ReadUInt32();
            break;
          }
          case 72: {
            MNNHPJGLOKM = input.ReadUInt32();
            break;
          }
          case 98: {
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
            break;
          }
          case 112: {
            ClientPosVersion = input.ReadUInt32();
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
