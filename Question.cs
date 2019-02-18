// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: question.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Message {

  /// <summary>Holder for reflection information generated from question.proto</summary>
  public static partial class QuestionReflection {

    #region Descriptor
    /// <summary>File descriptor for question.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5xdWVzdGlvbi5wcm90bxIHbWVzc2FnZRoMYW5zd2VyLnByb3RvIloKCFF1",
            "ZXN0aW9uEgwKBGd1aWQYASABKAkSEAoIcXVlc3Rpb24YAiABKAkSIAoHYW5z",
            "d2VycxgDIAMoCzIPLm1lc3NhZ2UuQW5zd2VyEgwKBFRpbWUYBCABKAViBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Message.AnswerReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.Question), global::Message.Question.Parser, new[]{ "Guid", "Question_", "Answers", "Time" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Question : pb::IMessage<Question> {
    private static readonly pb::MessageParser<Question> _parser = new pb::MessageParser<Question>(() => new Question());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Question> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.QuestionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Question() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Question(Question other) : this() {
      guid_ = other.guid_;
      question_ = other.question_;
      answers_ = other.answers_.Clone();
      time_ = other.time_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Question Clone() {
      return new Question(this);
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 1;
    private string guid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Guid {
      get { return guid_; }
      set {
        guid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "question" field.</summary>
    public const int Question_FieldNumber = 2;
    private string question_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Question_ {
      get { return question_; }
      set {
        question_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "answers" field.</summary>
    public const int AnswersFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Message.Answer> _repeated_answers_codec
        = pb::FieldCodec.ForMessage(26, global::Message.Answer.Parser);
    private readonly pbc::RepeatedField<global::Message.Answer> answers_ = new pbc::RepeatedField<global::Message.Answer>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Message.Answer> Answers {
      get { return answers_; }
    }

    /// <summary>Field number for the "Time" field.</summary>
    public const int TimeFieldNumber = 4;
    private int time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Question);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Question other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (Question_ != other.Question_) return false;
      if(!answers_.Equals(other.answers_)) return false;
      if (Time != other.Time) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid.Length != 0) hash ^= Guid.GetHashCode();
      if (Question_.Length != 0) hash ^= Question_.GetHashCode();
      hash ^= answers_.GetHashCode();
      if (Time != 0) hash ^= Time.GetHashCode();
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
      if (Guid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Guid);
      }
      if (Question_.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Question_);
      }
      answers_.WriteTo(output, _repeated_answers_codec);
      if (Time != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Time);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Guid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Guid);
      }
      if (Question_.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Question_);
      }
      size += answers_.CalculateSize(_repeated_answers_codec);
      if (Time != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Time);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Question other) {
      if (other == null) {
        return;
      }
      if (other.Guid.Length != 0) {
        Guid = other.Guid;
      }
      if (other.Question_.Length != 0) {
        Question_ = other.Question_;
      }
      answers_.Add(other.answers_);
      if (other.Time != 0) {
        Time = other.Time;
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
            Guid = input.ReadString();
            break;
          }
          case 18: {
            Question_ = input.ReadString();
            break;
          }
          case 26: {
            answers_.AddEntriesFrom(input, _repeated_answers_codec);
            break;
          }
          case 32: {
            Time = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
