// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OEADHAOAABJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from OEADHAOAABJ.proto</summary>
  public static partial class OEADHAOAABJReflection {

    #region Descriptor
    /// <summary>File descriptor for OEADHAOAABJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OEADHAOAABJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFPRUFESEFPQUFCSi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIoMBCgtP",
            "RUFESEFPQUFCShITCgtLQ05KTUFKQkhQSRgOIAEoDRIgCgljb3N0X2RhdGEY",
            "CiABKAsyDS5JdGVtQ29zdERhdGESEwoLUEZGRUJBRE1GSk4YAyABKA0SEwoL",
            "UEpMT0tORElFR0cYASABKAgSEwoLRU1NUENPSUhQREEYByABKAVCHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.OEADHAOAABJ), global::EggLink.DanhengServer.Proto.OEADHAOAABJ.Parser, new[]{ "KCNJMAJBHPI", "CostData", "PFFEBADMFJN", "PJLOKNDIEGG", "EMMPCOIHPDA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OEADHAOAABJ : pb::IMessage<OEADHAOAABJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OEADHAOAABJ> _parser = new pb::MessageParser<OEADHAOAABJ>(() => new OEADHAOAABJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OEADHAOAABJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.OEADHAOAABJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OEADHAOAABJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OEADHAOAABJ(OEADHAOAABJ other) : this() {
      kCNJMAJBHPI_ = other.kCNJMAJBHPI_;
      costData_ = other.costData_ != null ? other.costData_.Clone() : null;
      pFFEBADMFJN_ = other.pFFEBADMFJN_;
      pJLOKNDIEGG_ = other.pJLOKNDIEGG_;
      eMMPCOIHPDA_ = other.eMMPCOIHPDA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OEADHAOAABJ Clone() {
      return new OEADHAOAABJ(this);
    }

    /// <summary>Field number for the "KCNJMAJBHPI" field.</summary>
    public const int KCNJMAJBHPIFieldNumber = 14;
    private uint kCNJMAJBHPI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KCNJMAJBHPI {
      get { return kCNJMAJBHPI_; }
      set {
        kCNJMAJBHPI_ = value;
      }
    }

    /// <summary>Field number for the "cost_data" field.</summary>
    public const int CostDataFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ItemCostData costData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData CostData {
      get { return costData_; }
      set {
        costData_ = value;
      }
    }

    /// <summary>Field number for the "PFFEBADMFJN" field.</summary>
    public const int PFFEBADMFJNFieldNumber = 3;
    private uint pFFEBADMFJN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PFFEBADMFJN {
      get { return pFFEBADMFJN_; }
      set {
        pFFEBADMFJN_ = value;
      }
    }

    /// <summary>Field number for the "PJLOKNDIEGG" field.</summary>
    public const int PJLOKNDIEGGFieldNumber = 1;
    private bool pJLOKNDIEGG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PJLOKNDIEGG {
      get { return pJLOKNDIEGG_; }
      set {
        pJLOKNDIEGG_ = value;
      }
    }

    /// <summary>Field number for the "EMMPCOIHPDA" field.</summary>
    public const int EMMPCOIHPDAFieldNumber = 7;
    private int eMMPCOIHPDA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EMMPCOIHPDA {
      get { return eMMPCOIHPDA_; }
      set {
        eMMPCOIHPDA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OEADHAOAABJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OEADHAOAABJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KCNJMAJBHPI != other.KCNJMAJBHPI) return false;
      if (!object.Equals(CostData, other.CostData)) return false;
      if (PFFEBADMFJN != other.PFFEBADMFJN) return false;
      if (PJLOKNDIEGG != other.PJLOKNDIEGG) return false;
      if (EMMPCOIHPDA != other.EMMPCOIHPDA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KCNJMAJBHPI != 0) hash ^= KCNJMAJBHPI.GetHashCode();
      if (costData_ != null) hash ^= CostData.GetHashCode();
      if (PFFEBADMFJN != 0) hash ^= PFFEBADMFJN.GetHashCode();
      if (PJLOKNDIEGG != false) hash ^= PJLOKNDIEGG.GetHashCode();
      if (EMMPCOIHPDA != 0) hash ^= EMMPCOIHPDA.GetHashCode();
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
      if (PJLOKNDIEGG != false) {
        output.WriteRawTag(8);
        output.WriteBool(PJLOKNDIEGG);
      }
      if (PFFEBADMFJN != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PFFEBADMFJN);
      }
      if (EMMPCOIHPDA != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(EMMPCOIHPDA);
      }
      if (costData_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CostData);
      }
      if (KCNJMAJBHPI != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(KCNJMAJBHPI);
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
      if (PJLOKNDIEGG != false) {
        output.WriteRawTag(8);
        output.WriteBool(PJLOKNDIEGG);
      }
      if (PFFEBADMFJN != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PFFEBADMFJN);
      }
      if (EMMPCOIHPDA != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(EMMPCOIHPDA);
      }
      if (costData_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CostData);
      }
      if (KCNJMAJBHPI != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(KCNJMAJBHPI);
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
      if (KCNJMAJBHPI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KCNJMAJBHPI);
      }
      if (costData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CostData);
      }
      if (PFFEBADMFJN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PFFEBADMFJN);
      }
      if (PJLOKNDIEGG != false) {
        size += 1 + 1;
      }
      if (EMMPCOIHPDA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EMMPCOIHPDA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OEADHAOAABJ other) {
      if (other == null) {
        return;
      }
      if (other.KCNJMAJBHPI != 0) {
        KCNJMAJBHPI = other.KCNJMAJBHPI;
      }
      if (other.costData_ != null) {
        if (costData_ == null) {
          CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        CostData.MergeFrom(other.CostData);
      }
      if (other.PFFEBADMFJN != 0) {
        PFFEBADMFJN = other.PFFEBADMFJN;
      }
      if (other.PJLOKNDIEGG != false) {
        PJLOKNDIEGG = other.PJLOKNDIEGG;
      }
      if (other.EMMPCOIHPDA != 0) {
        EMMPCOIHPDA = other.EMMPCOIHPDA;
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
          case 8: {
            PJLOKNDIEGG = input.ReadBool();
            break;
          }
          case 24: {
            PFFEBADMFJN = input.ReadUInt32();
            break;
          }
          case 56: {
            EMMPCOIHPDA = input.ReadInt32();
            break;
          }
          case 82: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 112: {
            KCNJMAJBHPI = input.ReadUInt32();
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
          case 8: {
            PJLOKNDIEGG = input.ReadBool();
            break;
          }
          case 24: {
            PFFEBADMFJN = input.ReadUInt32();
            break;
          }
          case 56: {
            EMMPCOIHPDA = input.ReadInt32();
            break;
          }
          case 82: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 112: {
            KCNJMAJBHPI = input.ReadUInt32();
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