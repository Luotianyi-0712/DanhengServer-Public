// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityExpedition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ActivityExpedition.proto</summary>
  public static partial class ActivityExpeditionReflection {

    #region Descriptor
    /// <summary>File descriptor for ActivityExpedition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivityExpeditionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhBY3Rpdml0eUV4cGVkaXRpb24ucHJvdG8ijAEKEkFjdGl2aXR5RXhwZWRp",
            "dGlvbhITCgtNSkxPQlBGSU5KTxgIIAEoDRITCgtLUENIRkdLSURQThgHIAEo",
            "DRIWCg5hdmF0YXJfaWRfbGlzdBgEIAMoDRIKCgJpZBgMIAEoDRITCgtJSEZF",
            "QkNHRE1HRhgCIAEoDRITCgtCRU5EQktQSkNORxgFIAEoA0IeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ActivityExpedition), global::EggLink.DanhengServer.Proto.ActivityExpedition.Parser, new[]{ "MJLOBPFINJO", "KPCHFGKIDPN", "AvatarIdList", "Id", "IHFEBCGDMGF", "BENDBKPJCNG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ActivityExpedition : pb::IMessage<ActivityExpedition>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ActivityExpedition> _parser = new pb::MessageParser<ActivityExpedition>(() => new ActivityExpedition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ActivityExpedition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ActivityExpeditionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityExpedition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityExpedition(ActivityExpedition other) : this() {
      mJLOBPFINJO_ = other.mJLOBPFINJO_;
      kPCHFGKIDPN_ = other.kPCHFGKIDPN_;
      avatarIdList_ = other.avatarIdList_.Clone();
      id_ = other.id_;
      iHFEBCGDMGF_ = other.iHFEBCGDMGF_;
      bENDBKPJCNG_ = other.bENDBKPJCNG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityExpedition Clone() {
      return new ActivityExpedition(this);
    }

    /// <summary>Field number for the "MJLOBPFINJO" field.</summary>
    public const int MJLOBPFINJOFieldNumber = 8;
    private uint mJLOBPFINJO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MJLOBPFINJO {
      get { return mJLOBPFINJO_; }
      set {
        mJLOBPFINJO_ = value;
      }
    }

    /// <summary>Field number for the "KPCHFGKIDPN" field.</summary>
    public const int KPCHFGKIDPNFieldNumber = 7;
    private uint kPCHFGKIDPN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KPCHFGKIDPN {
      get { return kPCHFGKIDPN_; }
      set {
        kPCHFGKIDPN_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id_list" field.</summary>
    public const int AvatarIdListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_avatarIdList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> avatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AvatarIdList {
      get { return avatarIdList_; }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 12;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "IHFEBCGDMGF" field.</summary>
    public const int IHFEBCGDMGFFieldNumber = 2;
    private uint iHFEBCGDMGF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IHFEBCGDMGF {
      get { return iHFEBCGDMGF_; }
      set {
        iHFEBCGDMGF_ = value;
      }
    }

    /// <summary>Field number for the "BENDBKPJCNG" field.</summary>
    public const int BENDBKPJCNGFieldNumber = 5;
    private long bENDBKPJCNG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BENDBKPJCNG {
      get { return bENDBKPJCNG_; }
      set {
        bENDBKPJCNG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ActivityExpedition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ActivityExpedition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MJLOBPFINJO != other.MJLOBPFINJO) return false;
      if (KPCHFGKIDPN != other.KPCHFGKIDPN) return false;
      if(!avatarIdList_.Equals(other.avatarIdList_)) return false;
      if (Id != other.Id) return false;
      if (IHFEBCGDMGF != other.IHFEBCGDMGF) return false;
      if (BENDBKPJCNG != other.BENDBKPJCNG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MJLOBPFINJO != 0) hash ^= MJLOBPFINJO.GetHashCode();
      if (KPCHFGKIDPN != 0) hash ^= KPCHFGKIDPN.GetHashCode();
      hash ^= avatarIdList_.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (IHFEBCGDMGF != 0) hash ^= IHFEBCGDMGF.GetHashCode();
      if (BENDBKPJCNG != 0L) hash ^= BENDBKPJCNG.GetHashCode();
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
      if (IHFEBCGDMGF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(IHFEBCGDMGF);
      }
      avatarIdList_.WriteTo(output, _repeated_avatarIdList_codec);
      if (BENDBKPJCNG != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(BENDBKPJCNG);
      }
      if (KPCHFGKIDPN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KPCHFGKIDPN);
      }
      if (MJLOBPFINJO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MJLOBPFINJO);
      }
      if (Id != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Id);
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
      if (IHFEBCGDMGF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(IHFEBCGDMGF);
      }
      avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
      if (BENDBKPJCNG != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(BENDBKPJCNG);
      }
      if (KPCHFGKIDPN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KPCHFGKIDPN);
      }
      if (MJLOBPFINJO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MJLOBPFINJO);
      }
      if (Id != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Id);
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
      if (MJLOBPFINJO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MJLOBPFINJO);
      }
      if (KPCHFGKIDPN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KPCHFGKIDPN);
      }
      size += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (IHFEBCGDMGF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IHFEBCGDMGF);
      }
      if (BENDBKPJCNG != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BENDBKPJCNG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ActivityExpedition other) {
      if (other == null) {
        return;
      }
      if (other.MJLOBPFINJO != 0) {
        MJLOBPFINJO = other.MJLOBPFINJO;
      }
      if (other.KPCHFGKIDPN != 0) {
        KPCHFGKIDPN = other.KPCHFGKIDPN;
      }
      avatarIdList_.Add(other.avatarIdList_);
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.IHFEBCGDMGF != 0) {
        IHFEBCGDMGF = other.IHFEBCGDMGF;
      }
      if (other.BENDBKPJCNG != 0L) {
        BENDBKPJCNG = other.BENDBKPJCNG;
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
          case 16: {
            IHFEBCGDMGF = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            avatarIdList_.AddEntriesFrom(input, _repeated_avatarIdList_codec);
            break;
          }
          case 40: {
            BENDBKPJCNG = input.ReadInt64();
            break;
          }
          case 56: {
            KPCHFGKIDPN = input.ReadUInt32();
            break;
          }
          case 64: {
            MJLOBPFINJO = input.ReadUInt32();
            break;
          }
          case 96: {
            Id = input.ReadUInt32();
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
          case 16: {
            IHFEBCGDMGF = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
            break;
          }
          case 40: {
            BENDBKPJCNG = input.ReadInt64();
            break;
          }
          case 56: {
            KPCHFGKIDPN = input.ReadUInt32();
            break;
          }
          case 64: {
            MJLOBPFINJO = input.ReadUInt32();
            break;
          }
          case 96: {
            Id = input.ReadUInt32();
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
