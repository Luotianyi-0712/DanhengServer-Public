// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMiracle.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMiracle.proto</summary>
  public static partial class RogueMiracleReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMiracle.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMiracleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJSb2d1ZU1pcmFjbGUucHJvdG8iyAEKDFJvZ3VlTWlyYWNsZRITCgtEQ0xB",
            "QlBBTkJKRxgMIAEoDRIzCgtLT05BR0NESEtLSBgPIAMoCzIeLlJvZ3VlTWly",
            "YWNsZS5LT05BR0NESEtLSEVudHJ5EhIKCmR1cmFiaWxpdHkYCCABKA0SEgoK",
            "dXNlZF90aW1lcxgLIAEoDRISCgptaXJhY2xlX2lkGAcgASgNGjIKEEtPTkFH",
            "Q0RIS0tIRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMiracle), global::EggLink.DanhengServer.Proto.RogueMiracle.Parser, new[]{ "DCLABPANBJG", "KONAGCDHKKH", "Durability", "UsedTimes", "MiracleId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMiracle : pb::IMessage<RogueMiracle>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMiracle> _parser = new pb::MessageParser<RogueMiracle>(() => new RogueMiracle());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMiracle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMiracleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracle(RogueMiracle other) : this() {
      dCLABPANBJG_ = other.dCLABPANBJG_;
      kONAGCDHKKH_ = other.kONAGCDHKKH_.Clone();
      durability_ = other.durability_;
      usedTimes_ = other.usedTimes_;
      miracleId_ = other.miracleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracle Clone() {
      return new RogueMiracle(this);
    }

    /// <summary>Field number for the "DCLABPANBJG" field.</summary>
    public const int DCLABPANBJGFieldNumber = 12;
    private uint dCLABPANBJG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DCLABPANBJG {
      get { return dCLABPANBJG_; }
      set {
        dCLABPANBJG_ = value;
      }
    }

    /// <summary>Field number for the "KONAGCDHKKH" field.</summary>
    public const int KONAGCDHKKHFieldNumber = 15;
    private static readonly pbc::MapField<uint, uint>.Codec _map_kONAGCDHKKH_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 122);
    private readonly pbc::MapField<uint, uint> kONAGCDHKKH_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> KONAGCDHKKH {
      get { return kONAGCDHKKH_; }
    }

    /// <summary>Field number for the "durability" field.</summary>
    public const int DurabilityFieldNumber = 8;
    private uint durability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Durability {
      get { return durability_; }
      set {
        durability_ = value;
      }
    }

    /// <summary>Field number for the "used_times" field.</summary>
    public const int UsedTimesFieldNumber = 11;
    private uint usedTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UsedTimes {
      get { return usedTimes_; }
      set {
        usedTimes_ = value;
      }
    }

    /// <summary>Field number for the "miracle_id" field.</summary>
    public const int MiracleIdFieldNumber = 7;
    private uint miracleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MiracleId {
      get { return miracleId_; }
      set {
        miracleId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMiracle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMiracle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DCLABPANBJG != other.DCLABPANBJG) return false;
      if (!KONAGCDHKKH.Equals(other.KONAGCDHKKH)) return false;
      if (Durability != other.Durability) return false;
      if (UsedTimes != other.UsedTimes) return false;
      if (MiracleId != other.MiracleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DCLABPANBJG != 0) hash ^= DCLABPANBJG.GetHashCode();
      hash ^= KONAGCDHKKH.GetHashCode();
      if (Durability != 0) hash ^= Durability.GetHashCode();
      if (UsedTimes != 0) hash ^= UsedTimes.GetHashCode();
      if (MiracleId != 0) hash ^= MiracleId.GetHashCode();
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
      if (MiracleId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MiracleId);
      }
      if (Durability != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Durability);
      }
      if (UsedTimes != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UsedTimes);
      }
      if (DCLABPANBJG != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DCLABPANBJG);
      }
      kONAGCDHKKH_.WriteTo(output, _map_kONAGCDHKKH_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MiracleId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MiracleId);
      }
      if (Durability != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Durability);
      }
      if (UsedTimes != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UsedTimes);
      }
      if (DCLABPANBJG != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DCLABPANBJG);
      }
      kONAGCDHKKH_.WriteTo(ref output, _map_kONAGCDHKKH_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (DCLABPANBJG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DCLABPANBJG);
      }
      size += kONAGCDHKKH_.CalculateSize(_map_kONAGCDHKKH_codec);
      if (Durability != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Durability);
      }
      if (UsedTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UsedTimes);
      }
      if (MiracleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MiracleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMiracle other) {
      if (other == null) {
        return;
      }
      if (other.DCLABPANBJG != 0) {
        DCLABPANBJG = other.DCLABPANBJG;
      }
      kONAGCDHKKH_.MergeFrom(other.kONAGCDHKKH_);
      if (other.Durability != 0) {
        Durability = other.Durability;
      }
      if (other.UsedTimes != 0) {
        UsedTimes = other.UsedTimes;
      }
      if (other.MiracleId != 0) {
        MiracleId = other.MiracleId;
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
          case 56: {
            MiracleId = input.ReadUInt32();
            break;
          }
          case 64: {
            Durability = input.ReadUInt32();
            break;
          }
          case 88: {
            UsedTimes = input.ReadUInt32();
            break;
          }
          case 96: {
            DCLABPANBJG = input.ReadUInt32();
            break;
          }
          case 122: {
            kONAGCDHKKH_.AddEntriesFrom(input, _map_kONAGCDHKKH_codec);
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
          case 56: {
            MiracleId = input.ReadUInt32();
            break;
          }
          case 64: {
            Durability = input.ReadUInt32();
            break;
          }
          case 88: {
            UsedTimes = input.ReadUInt32();
            break;
          }
          case 96: {
            DCLABPANBJG = input.ReadUInt32();
            break;
          }
          case 122: {
            kONAGCDHKKH_.AddEntriesFrom(ref input, _map_kONAGCDHKKH_codec);
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
