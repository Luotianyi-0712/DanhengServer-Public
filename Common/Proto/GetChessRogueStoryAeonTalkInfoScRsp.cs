// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetChessRogueStoryAeonTalkInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetChessRogueStoryAeonTalkInfoScRsp.proto</summary>
  public static partial class GetChessRogueStoryAeonTalkInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetChessRogueStoryAeonTalkInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetChessRogueStoryAeonTalkInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilHZXRDaGVzc1JvZ3VlU3RvcnlBZW9uVGFsa0luZm9TY1JzcC5wcm90byLL",
            "AQojR2V0Q2hlc3NSb2d1ZVN0b3J5QWVvblRhbGtJbmZvU2NSc3ASSgoLR0JC",
            "Qk5GTUdOTFAYBiADKAsyNS5HZXRDaGVzc1JvZ3VlU3RvcnlBZW9uVGFsa0lu",
            "Zm9TY1JzcC5HQkJCTkZNR05MUEVudHJ5Eg8KB3JldGNvZGUYDiABKA0SEwoL",
            "S0xIRURQTUdQSkoYCCABKA0aMgoQR0JCQk5GTUdOTFBFbnRyeRILCgNrZXkY",
            "ASABKA0SDQoFdmFsdWUYAiABKA06AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetChessRogueStoryAeonTalkInfoScRsp), global::EggLink.DanhengServer.Proto.GetChessRogueStoryAeonTalkInfoScRsp.Parser, new[]{ "GBBBNFMGNLP", "Retcode", "KLHEDPMGPJJ" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetChessRogueStoryAeonTalkInfoScRsp : pb::IMessage<GetChessRogueStoryAeonTalkInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetChessRogueStoryAeonTalkInfoScRsp> _parser = new pb::MessageParser<GetChessRogueStoryAeonTalkInfoScRsp>(() => new GetChessRogueStoryAeonTalkInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetChessRogueStoryAeonTalkInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetChessRogueStoryAeonTalkInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueStoryAeonTalkInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueStoryAeonTalkInfoScRsp(GetChessRogueStoryAeonTalkInfoScRsp other) : this() {
      gBBBNFMGNLP_ = other.gBBBNFMGNLP_.Clone();
      retcode_ = other.retcode_;
      kLHEDPMGPJJ_ = other.kLHEDPMGPJJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueStoryAeonTalkInfoScRsp Clone() {
      return new GetChessRogueStoryAeonTalkInfoScRsp(this);
    }

    /// <summary>Field number for the "GBBBNFMGNLP" field.</summary>
    public const int GBBBNFMGNLPFieldNumber = 6;
    private static readonly pbc::MapField<uint, uint>.Codec _map_gBBBNFMGNLP_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 50);
    private readonly pbc::MapField<uint, uint> gBBBNFMGNLP_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> GBBBNFMGNLP {
      get { return gBBBNFMGNLP_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "KLHEDPMGPJJ" field.</summary>
    public const int KLHEDPMGPJJFieldNumber = 8;
    private uint kLHEDPMGPJJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KLHEDPMGPJJ {
      get { return kLHEDPMGPJJ_; }
      set {
        kLHEDPMGPJJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetChessRogueStoryAeonTalkInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetChessRogueStoryAeonTalkInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!GBBBNFMGNLP.Equals(other.GBBBNFMGNLP)) return false;
      if (Retcode != other.Retcode) return false;
      if (KLHEDPMGPJJ != other.KLHEDPMGPJJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= GBBBNFMGNLP.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (KLHEDPMGPJJ != 0) hash ^= KLHEDPMGPJJ.GetHashCode();
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
      gBBBNFMGNLP_.WriteTo(output, _map_gBBBNFMGNLP_codec);
      if (KLHEDPMGPJJ != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KLHEDPMGPJJ);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      gBBBNFMGNLP_.WriteTo(ref output, _map_gBBBNFMGNLP_codec);
      if (KLHEDPMGPJJ != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KLHEDPMGPJJ);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      size += gBBBNFMGNLP_.CalculateSize(_map_gBBBNFMGNLP_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (KLHEDPMGPJJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KLHEDPMGPJJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetChessRogueStoryAeonTalkInfoScRsp other) {
      if (other == null) {
        return;
      }
      gBBBNFMGNLP_.MergeFrom(other.gBBBNFMGNLP_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.KLHEDPMGPJJ != 0) {
        KLHEDPMGPJJ = other.KLHEDPMGPJJ;
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
          case 50: {
            gBBBNFMGNLP_.AddEntriesFrom(input, _map_gBBBNFMGNLP_codec);
            break;
          }
          case 64: {
            KLHEDPMGPJJ = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
          case 50: {
            gBBBNFMGNLP_.AddEntriesFrom(ref input, _map_gBBBNFMGNLP_codec);
            break;
          }
          case 64: {
            KLHEDPMGPJJ = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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