// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: dotbpe_option.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DotBPE.Extra.Protobuf {

  /// <summary>Holder for reflection information generated from dotbpe_option.proto</summary>
  public static partial class DotbpeOptionReflection {

    #region Descriptor
    /// <summary>File descriptor for dotbpe_option.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DotbpeOptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNkb3RicGVfb3B0aW9uLnByb3RvEgZkb3RicGUaIGdvb2dsZS9wcm90b2J1",
            "Zi9kZXNjcmlwdG9yLnByb3RvInUKDUh0dHBBcGlPcHRpb24SDAoEcGF0aBgB",
            "IAEoCRIOCgZtZXRob2QYAiABKAkSEwoLZGVzY3JpcHRpb24YAyABKAkSDwoH",
            "dGltZW91dBgEIAEoBRIOCgZwbHVnaW4YBSABKAkSEAoIY2F0ZWdvcnkYBiAB",
            "KAk6NQoKc2VydmljZV9pZBIfLmdvb2dsZS5wcm90b2J1Zi5TZXJ2aWNlT3B0",
            "aW9ucxi5jgMgASgFOjgKDXNlcnZpY2VfZ3JvdXASHy5nb29nbGUucHJvdG9i",
            "dWYuU2VydmljZU9wdGlvbnMYuo4DIAEoCTo0CgptZXNzYWdlX2lkEh4uZ29v",
            "Z2xlLnByb3RvYnVmLk1ldGhvZE9wdGlvbnMYuo4DIAEoBTpQCg9odHRwX2Fw",
            "aV9vcHRpb24SHi5nb29nbGUucHJvdG9idWYuTWV0aG9kT3B0aW9ucxi7jgMg",
            "ASgLMhUuZG90YnBlLkh0dHBBcGlPcHRpb246MQoHdGltZW91dBIeLmdvb2ds",
            "ZS5wcm90b2J1Zi5NZXRob2RPcHRpb25zGLyOAyABKAU6PAoUZ2VuZXJpY19t",
            "YXJrZG93bl9kb2MSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMYvY4D",
            "IAEoCDo+ChZnZW5lcmljX2Fic3RyYWN0X2NsYXNzEhwuZ29vZ2xlLnByb3Rv",
            "YnVmLkZpbGVPcHRpb25zGL6OAyABKAg6PwoXZ2VuZXJpY19odHRwX2FwaV9y",
            "b3V0ZXMSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMYv44DIAEoCDo1",
            "Cg1jb21tb25fZmllbGRzEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25z",
            "GMCOAyABKAlCGKoCFURvdEJQRS5FeHRyYS5Qcm90b2J1ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { pbr::FileDescriptor.DescriptorProtoFileDescriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DotBPE.Extra.Protobuf.HttpApiOption), global::DotBPE.Extra.Protobuf.HttpApiOption.Parser, new[]{ "Path", "Method", "Description", "Timeout", "Plugin", "Category" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// </summary>
  public sealed partial class HttpApiOption : pb::IMessage<HttpApiOption> {
    private static readonly pb::MessageParser<HttpApiOption> _parser = new pb::MessageParser<HttpApiOption>(() => new HttpApiOption());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HttpApiOption> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DotBPE.Extra.Protobuf.DotbpeOptionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpApiOption() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpApiOption(HttpApiOption other) : this() {
      path_ = other.path_;
      method_ = other.method_;
      description_ = other.description_;
      timeout_ = other.timeout_;
      plugin_ = other.plugin_;
      category_ = other.category_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpApiOption Clone() {
      return new HttpApiOption(this);
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 1;
    private string path_ = "";
    /// <summary>
    /// 路径
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Path {
      get { return path_; }
      set {
        path_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "method" field.</summary>
    public const int MethodFieldNumber = 2;
    private string method_ = "";
    /// <summary>
    ///请求的方法
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Method {
      get { return method_; }
      set {
        method_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    ///注释说明
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timeout" field.</summary>
    public const int TimeoutFieldNumber = 4;
    private int timeout_;
    /// <summary>
    ///调用超时配置
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Timeout {
      get { return timeout_; }
      set {
        timeout_ = value;
      }
    }

    /// <summary>Field number for the "plugin" field.</summary>
    public const int PluginFieldNumber = 5;
    private string plugin_ = "";
    /// <summary>
    ///插件
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Plugin {
      get { return plugin_; }
      set {
        plugin_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 6;
    private string category_ = "";
    /// <summary>
    /// Api分类
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Category {
      get { return category_; }
      set {
        category_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HttpApiOption);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HttpApiOption other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Path != other.Path) return false;
      if (Method != other.Method) return false;
      if (Description != other.Description) return false;
      if (Timeout != other.Timeout) return false;
      if (Plugin != other.Plugin) return false;
      if (Category != other.Category) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Path.Length != 0) hash ^= Path.GetHashCode();
      if (Method.Length != 0) hash ^= Method.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Timeout != 0) hash ^= Timeout.GetHashCode();
      if (Plugin.Length != 0) hash ^= Plugin.GetHashCode();
      if (Category.Length != 0) hash ^= Category.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Path.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Path);
      }
      if (Method.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Method);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (Timeout != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Timeout);
      }
      if (Plugin.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Plugin);
      }
      if (Category.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Category);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Path.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path);
      }
      if (Method.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Method);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Timeout != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Timeout);
      }
      if (Plugin.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Plugin);
      }
      if (Category.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Category);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HttpApiOption other) {
      if (other == null) {
        return;
      }
      if (other.Path.Length != 0) {
        Path = other.Path;
      }
      if (other.Method.Length != 0) {
        Method = other.Method;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Timeout != 0) {
        Timeout = other.Timeout;
      }
      if (other.Plugin.Length != 0) {
        Plugin = other.Plugin;
      }
      if (other.Category.Length != 0) {
        Category = other.Category;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Path = input.ReadString();
            break;
          }
          case 18: {
            Method = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 32: {
            Timeout = input.ReadInt32();
            break;
          }
          case 42: {
            Plugin = input.ReadString();
            break;
          }
          case 50: {
            Category = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code