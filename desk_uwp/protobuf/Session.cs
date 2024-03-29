// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: session.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace deskx_uwp.protobuf {

  /// <summary>Holder for reflection information generated from session.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class SessionReflection {

    #region Descriptor
    /// <summary>File descriptor for session.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1zZXNzaW9uLnByb3RvEgRkZXNrIloKB1Nlc3Npb24SCgoCaWQYASABKAUS",
            "EAoIdXNlcm5hbWUYAiABKAkSEQoJdGltZVN0YXJ0GAMgASgJEg8KB3RpbWVF",
            "bmQYBCABKAkSDQoFdGl0bGUYBSABKAkiMQoLU2Vzc2lvbkxpc3QSIgoLc2Vz",
            "c2lvbkxpc3QYASADKAsyDS5kZXNrLlNlc3Npb24ibQoNU2Vzc2lvbk9iamVj",
            "dBIeCgdzZXNzaW9uGAEgASgLMg0uZGVzay5TZXNzaW9uEgwKBHR5cGUYAiAB",
            "KAkSEgoKaW5zZXJ0VGltZRgDIAEoCRIMCgRkYXRhGAQgASgJEgwKBHVzZXIY",
            "BSABKAkiRwoWU2Vzc2lvbk9iamVjdENvbnRhaW5lchItChBzZXNzaW9uQ29u",
            "dGFpbmVyGAEgAygLMhMuZGVzay5TZXNzaW9uT2JqZWN0InMKFVNlc3Npb25P",
            "YmplY3RNb3ZlbWVudBIqCg1zZXNzaW9uT2JqZWN0GAEgASgLMhMuZGVzay5T",
            "ZXNzaW9uT2JqZWN0EgwKBHR5cGUYAiABKAkSEgoKaW5zZXJ0VGltZRgDIAEo",
            "CRIMCgRkYXRhGAQgASgJIjEKD1Nlc3Npb25SZXNwb25zZRIPCgdtZXNzYWdl",
            "GAEgASgJEg0KBWVycm9yGAIgASgIQhWqAhJkZXNreF91d3AucHJvdG9idWZi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::deskx_uwp.protobuf.Session), global::deskx_uwp.protobuf.Session.Parser, new[]{ "Id", "Username", "TimeStart", "TimeEnd", "Title" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::deskx_uwp.protobuf.SessionList), global::deskx_uwp.protobuf.SessionList.Parser, new[]{ "SessionList_" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::deskx_uwp.protobuf.SessionObject), global::deskx_uwp.protobuf.SessionObject.Parser, new[]{ "Session", "Type", "InsertTime", "Data", "User" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::deskx_uwp.protobuf.SessionObjectContainer), global::deskx_uwp.protobuf.SessionObjectContainer.Parser, new[]{ "SessionContainer" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::deskx_uwp.protobuf.SessionObjectMovement), global::deskx_uwp.protobuf.SessionObjectMovement.Parser, new[]{ "SessionObject", "Type", "InsertTime", "Data" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::deskx_uwp.protobuf.SessionResponse), global::deskx_uwp.protobuf.SessionResponse.Parser, new[]{ "Message", "Error" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Session : pb::IMessage<Session> {
    private static readonly pb::MessageParser<Session> _parser = new pb::MessageParser<Session>(() => new Session());
    public static pb::MessageParser<Session> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::deskx_uwp.protobuf.SessionReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Session() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Session(Session other) : this() {
      id_ = other.id_;
      username_ = other.username_;
      timeStart_ = other.timeStart_;
      timeEnd_ = other.timeEnd_;
      title_ = other.title_;
    }

    public Session Clone() {
      return new Session(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 2;
    private string username_ = "";
    public string Username {
      get { return username_; }
      set {
        username_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timeStart" field.</summary>
    public const int TimeStartFieldNumber = 3;
    private string timeStart_ = "";
    public string TimeStart {
      get { return timeStart_; }
      set {
        timeStart_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timeEnd" field.</summary>
    public const int TimeEndFieldNumber = 4;
    private string timeEnd_ = "";
    public string TimeEnd {
      get { return timeEnd_; }
      set {
        timeEnd_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 5;
    private string title_ = "";
    public string Title {
      get { return title_; }
      set {
        title_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Session);
    }

    public bool Equals(Session other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Username != other.Username) return false;
      if (TimeStart != other.TimeStart) return false;
      if (TimeEnd != other.TimeEnd) return false;
      if (Title != other.Title) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (TimeStart.Length != 0) hash ^= TimeStart.GetHashCode();
      if (TimeEnd.Length != 0) hash ^= TimeEnd.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Username.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Username);
      }
      if (TimeStart.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TimeStart);
      }
      if (TimeEnd.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TimeEnd);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Title);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (TimeStart.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeStart);
      }
      if (TimeEnd.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeEnd);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      return size;
    }

    public void MergeFrom(Session other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.TimeStart.Length != 0) {
        TimeStart = other.TimeStart;
      }
      if (other.TimeEnd.Length != 0) {
        TimeEnd = other.TimeEnd;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Username = input.ReadString();
            break;
          }
          case 26: {
            TimeStart = input.ReadString();
            break;
          }
          case 34: {
            TimeEnd = input.ReadString();
            break;
          }
          case 42: {
            Title = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SessionList : pb::IMessage<SessionList> {
    private static readonly pb::MessageParser<SessionList> _parser = new pb::MessageParser<SessionList>(() => new SessionList());
    public static pb::MessageParser<SessionList> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::deskx_uwp.protobuf.SessionReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SessionList() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SessionList(SessionList other) : this() {
      sessionList_ = other.sessionList_.Clone();
    }

    public SessionList Clone() {
      return new SessionList(this);
    }

    /// <summary>Field number for the "sessionList" field.</summary>
    public const int SessionList_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::deskx_uwp.protobuf.Session> _repeated_sessionList_codec
        = pb::FieldCodec.ForMessage(10, global::deskx_uwp.protobuf.Session.Parser);
    private readonly pbc::RepeatedField<global::deskx_uwp.protobuf.Session> sessionList_ = new pbc::RepeatedField<global::deskx_uwp.protobuf.Session>();
    public pbc::RepeatedField<global::deskx_uwp.protobuf.Session> SessionList_ {
      get { return sessionList_; }
    }

    public override bool Equals(object other) {
      return Equals(other as SessionList);
    }

    public bool Equals(SessionList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sessionList_.Equals(other.sessionList_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= sessionList_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      sessionList_.WriteTo(output, _repeated_sessionList_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += sessionList_.CalculateSize(_repeated_sessionList_codec);
      return size;
    }

    public void MergeFrom(SessionList other) {
      if (other == null) {
        return;
      }
      sessionList_.Add(other.sessionList_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            sessionList_.AddEntriesFrom(input, _repeated_sessionList_codec);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SessionObject : pb::IMessage<SessionObject> {
    private static readonly pb::MessageParser<SessionObject> _parser = new pb::MessageParser<SessionObject>(() => new SessionObject());
    public static pb::MessageParser<SessionObject> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::deskx_uwp.protobuf.SessionReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SessionObject() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SessionObject(SessionObject other) : this() {
      Session = other.session_ != null ? other.Session.Clone() : null;
      type_ = other.type_;
      insertTime_ = other.insertTime_;
      data_ = other.data_;
      user_ = other.user_;
    }

    public SessionObject Clone() {
      return new SessionObject(this);
    }

    /// <summary>Field number for the "session" field.</summary>
    public const int SessionFieldNumber = 1;
    private global::deskx_uwp.protobuf.Session session_;
    public global::deskx_uwp.protobuf.Session Session {
      get { return session_; }
      set {
        session_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private string type_ = "";
    public string Type {
      get { return type_; }
      set {
        type_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "insertTime" field.</summary>
    public const int InsertTimeFieldNumber = 3;
    private string insertTime_ = "";
    public string InsertTime {
      get { return insertTime_; }
      set {
        insertTime_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 4;
    private string data_ = "";
    public string Data {
      get { return data_; }
      set {
        data_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 5;
    private string user_ = "";
    public string User {
      get { return user_; }
      set {
        user_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SessionObject);
    }

    public bool Equals(SessionObject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Session, other.Session)) return false;
      if (Type != other.Type) return false;
      if (InsertTime != other.InsertTime) return false;
      if (Data != other.Data) return false;
      if (User != other.User) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (session_ != null) hash ^= Session.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (InsertTime.Length != 0) hash ^= InsertTime.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (User.Length != 0) hash ^= User.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (session_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Session);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      if (InsertTime.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(InsertTime);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Data);
      }
      if (User.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(User);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (session_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Session);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (InsertTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InsertTime);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Data);
      }
      if (User.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(User);
      }
      return size;
    }

    public void MergeFrom(SessionObject other) {
      if (other == null) {
        return;
      }
      if (other.session_ != null) {
        if (session_ == null) {
          session_ = new global::deskx_uwp.protobuf.Session();
        }
        Session.MergeFrom(other.Session);
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.InsertTime.Length != 0) {
        InsertTime = other.InsertTime;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      if (other.User.Length != 0) {
        User = other.User;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (session_ == null) {
              session_ = new global::deskx_uwp.protobuf.Session();
            }
            input.ReadMessage(session_);
            break;
          }
          case 18: {
            Type = input.ReadString();
            break;
          }
          case 26: {
            InsertTime = input.ReadString();
            break;
          }
          case 34: {
            Data = input.ReadString();
            break;
          }
          case 42: {
            User = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SessionObjectContainer : pb::IMessage<SessionObjectContainer> {
    private static readonly pb::MessageParser<SessionObjectContainer> _parser = new pb::MessageParser<SessionObjectContainer>(() => new SessionObjectContainer());
    public static pb::MessageParser<SessionObjectContainer> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::deskx_uwp.protobuf.SessionReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SessionObjectContainer() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SessionObjectContainer(SessionObjectContainer other) : this() {
      sessionContainer_ = other.sessionContainer_.Clone();
    }

    public SessionObjectContainer Clone() {
      return new SessionObjectContainer(this);
    }

    /// <summary>Field number for the "sessionContainer" field.</summary>
    public const int SessionContainerFieldNumber = 1;
    private static readonly pb::FieldCodec<global::deskx_uwp.protobuf.SessionObject> _repeated_sessionContainer_codec
        = pb::FieldCodec.ForMessage(10, global::deskx_uwp.protobuf.SessionObject.Parser);
    private readonly pbc::RepeatedField<global::deskx_uwp.protobuf.SessionObject> sessionContainer_ = new pbc::RepeatedField<global::deskx_uwp.protobuf.SessionObject>();
    public pbc::RepeatedField<global::deskx_uwp.protobuf.SessionObject> SessionContainer {
      get { return sessionContainer_; }
    }

    public override bool Equals(object other) {
      return Equals(other as SessionObjectContainer);
    }

    public bool Equals(SessionObjectContainer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sessionContainer_.Equals(other.sessionContainer_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= sessionContainer_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      sessionContainer_.WriteTo(output, _repeated_sessionContainer_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += sessionContainer_.CalculateSize(_repeated_sessionContainer_codec);
      return size;
    }

    public void MergeFrom(SessionObjectContainer other) {
      if (other == null) {
        return;
      }
      sessionContainer_.Add(other.sessionContainer_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            sessionContainer_.AddEntriesFrom(input, _repeated_sessionContainer_codec);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SessionObjectMovement : pb::IMessage<SessionObjectMovement> {
    private static readonly pb::MessageParser<SessionObjectMovement> _parser = new pb::MessageParser<SessionObjectMovement>(() => new SessionObjectMovement());
    public static pb::MessageParser<SessionObjectMovement> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::deskx_uwp.protobuf.SessionReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SessionObjectMovement() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SessionObjectMovement(SessionObjectMovement other) : this() {
      SessionObject = other.sessionObject_ != null ? other.SessionObject.Clone() : null;
      type_ = other.type_;
      insertTime_ = other.insertTime_;
      data_ = other.data_;
    }

    public SessionObjectMovement Clone() {
      return new SessionObjectMovement(this);
    }

    /// <summary>Field number for the "sessionObject" field.</summary>
    public const int SessionObjectFieldNumber = 1;
    private global::deskx_uwp.protobuf.SessionObject sessionObject_;
    public global::deskx_uwp.protobuf.SessionObject SessionObject {
      get { return sessionObject_; }
      set {
        sessionObject_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private string type_ = "";
    public string Type {
      get { return type_; }
      set {
        type_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "insertTime" field.</summary>
    public const int InsertTimeFieldNumber = 3;
    private string insertTime_ = "";
    public string InsertTime {
      get { return insertTime_; }
      set {
        insertTime_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 4;
    private string data_ = "";
    public string Data {
      get { return data_; }
      set {
        data_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SessionObjectMovement);
    }

    public bool Equals(SessionObjectMovement other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SessionObject, other.SessionObject)) return false;
      if (Type != other.Type) return false;
      if (InsertTime != other.InsertTime) return false;
      if (Data != other.Data) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (sessionObject_ != null) hash ^= SessionObject.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (InsertTime.Length != 0) hash ^= InsertTime.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (sessionObject_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SessionObject);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      if (InsertTime.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(InsertTime);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Data);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (sessionObject_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SessionObject);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (InsertTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InsertTime);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Data);
      }
      return size;
    }

    public void MergeFrom(SessionObjectMovement other) {
      if (other == null) {
        return;
      }
      if (other.sessionObject_ != null) {
        if (sessionObject_ == null) {
          sessionObject_ = new global::deskx_uwp.protobuf.SessionObject();
        }
        SessionObject.MergeFrom(other.SessionObject);
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.InsertTime.Length != 0) {
        InsertTime = other.InsertTime;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (sessionObject_ == null) {
              sessionObject_ = new global::deskx_uwp.protobuf.SessionObject();
            }
            input.ReadMessage(sessionObject_);
            break;
          }
          case 18: {
            Type = input.ReadString();
            break;
          }
          case 26: {
            InsertTime = input.ReadString();
            break;
          }
          case 34: {
            Data = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SessionResponse : pb::IMessage<SessionResponse> {
    private static readonly pb::MessageParser<SessionResponse> _parser = new pb::MessageParser<SessionResponse>(() => new SessionResponse());
    public static pb::MessageParser<SessionResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::deskx_uwp.protobuf.SessionReflection.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SessionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SessionResponse(SessionResponse other) : this() {
      message_ = other.message_;
      error_ = other.error_;
    }

    public SessionResponse Clone() {
      return new SessionResponse(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 2;
    private bool error_;
    public bool Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SessionResponse);
    }

    public bool Equals(SessionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (Error != other.Error) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Error != false) hash ^= Error.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (Error != false) {
        output.WriteRawTag(16);
        output.WriteBool(Error);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Error != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(SessionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Error != false) {
        Error = other.Error;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 16: {
            Error = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
