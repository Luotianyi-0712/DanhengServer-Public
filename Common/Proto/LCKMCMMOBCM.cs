// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LCKMCMMOBCM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LCKMCMMOBCM.proto</summary>
  public static partial class LCKMCMMOBCMReflection {

    #region Descriptor
    /// <summary>File descriptor for LCKMCMMOBCM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LCKMCMMOBCMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFMQ0tNQ01NT0JDTS5wcm90byI3CgtMQ0tNQ01NT0JDTRITCgtPUE5GUExC",
            "T01JRRgIIAEoDRITCgtKRkJLQ09BQklHUBgLIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LCKMCMMOBCM), global::EggLink.DanhengServer.Proto.LCKMCMMOBCM.Parser, new[]{ "OPNFPLBOMIE", "JFBKCOABIGP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LCKMCMMOBCM : pb::IMessage<LCKMCMMOBCM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LCKMCMMOBCM> _parser = new pb::MessageParser<LCKMCMMOBCM>(() => new LCKMCMMOBCM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LCKMCMMOBCM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LCKMCMMOBCMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LCKMCMMOBCM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LCKMCMMOBCM(LCKMCMMOBCM other) : this() {
      oPNFPLBOMIE_ = other.oPNFPLBOMIE_;
      jFBKCOABIGP_ = other.jFBKCOABIGP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LCKMCMMOBCM Clone() {
      return new LCKMCMMOBCM(this);
    }

    /// <summary>Field number for the "OPNFPLBOMIE" field.</summary>
    public const int OPNFPLBOMIEFieldNumber = 8;
    private uint oPNFPLBOMIE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OPNFPLBOMIE {
      get { return oPNFPLBOMIE_; }
      set {
        oPNFPLBOMIE_ = value;
      }
    }

    /// <summary>Field number for the "JFBKCOABIGP" field.</summary>
    public const int JFBKCOABIGPFieldNumber = 11;
    private uint jFBKCOABIGP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JFBKCOABIGP {
      get { return jFBKCOABIGP_; }
      set {
        jFBKCOABIGP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LCKMCMMOBCM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LCKMCMMOBCM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OPNFPLBOMIE != other.OPNFPLBOMIE) return false;
      if (JFBKCOABIGP != other.JFBKCOABIGP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OPNFPLBOMIE != 0) hash ^= OPNFPLBOMIE.GetHashCode();
      if (JFBKCOABIGP != 0) hash ^= JFBKCOABIGP.GetHashCode();
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
      if (OPNFPLBOMIE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OPNFPLBOMIE);
      }
      if (JFBKCOABIGP != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(JFBKCOABIGP);
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
      if (OPNFPLBOMIE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OPNFPLBOMIE);
      }
      if (JFBKCOABIGP != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(JFBKCOABIGP);
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
      if (OPNFPLBOMIE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OPNFPLBOMIE);
      }
      if (JFBKCOABIGP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JFBKCOABIGP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LCKMCMMOBCM other) {
      if (other == null) {
        return;
      }
      if (other.OPNFPLBOMIE != 0) {
        OPNFPLBOMIE = other.OPNFPLBOMIE;
      }
      if (other.JFBKCOABIGP != 0) {
        JFBKCOABIGP = other.JFBKCOABIGP;
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
          case 64: {
            OPNFPLBOMIE = input.ReadUInt32();
            break;
          }
          case 88: {
            JFBKCOABIGP = input.ReadUInt32();
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
          case 64: {
            OPNFPLBOMIE = input.ReadUInt32();
            break;
          }
          case 88: {
            JFBKCOABIGP = input.ReadUInt32();
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
