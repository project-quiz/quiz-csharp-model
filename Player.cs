// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: player.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Message {

  /// <summary>Holder for reflection information generated from player.proto</summary>
  public static partial class PlayerReflection {

    #region Descriptor
    /// <summary>File descriptor for player.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxwbGF5ZXIucHJvdG8SB21lc3NhZ2UiKAoGUGxheWVyEgwKBGd1aWQYASAB",
            "KAkSEAoIbmlja25hbWUYAiABKAkiHgoKUGxheWVySm9pbhIQCghuaWNrbmFt",
            "ZRgBIAEoCSI9CgxQbGF5ZXJKb2luZWQSDAoEZ3VpZBgBIAEoCRIfCgZwbGF5",
            "ZXIYAiABKAsyDy5tZXNzYWdlLlBsYXllciI7CgpQbGF5ZXJMZWZ0EgwKBGd1",
            "aWQYASABKAkSHwoGcGxheWVyGAIgASgLMg8ubWVzc2FnZS5QbGF5ZXIiRwoW",
            "UGxheWVyc05pY2tOYW1lQ2hhbmdlZBIMCgRndWlkGAEgASgJEh8KBnBsYXll",
            "chgCIAEoCzIPLm1lc3NhZ2UuUGxheWVyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.Player), global::Message.Player.Parser, new[]{ "Guid", "Nickname" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.PlayerJoin), global::Message.PlayerJoin.Parser, new[]{ "Nickname" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.PlayerJoined), global::Message.PlayerJoined.Parser, new[]{ "Guid", "Player" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.PlayerLeft), global::Message.PlayerLeft.Parser, new[]{ "Guid", "Player" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.PlayersNickNameChanged), global::Message.PlayersNickNameChanged.Parser, new[]{ "Guid", "Player" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Player : pb::IMessage<Player> {
    private static readonly pb::MessageParser<Player> _parser = new pb::MessageParser<Player>(() => new Player());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Player> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.PlayerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Player() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Player(Player other) : this() {
      guid_ = other.guid_;
      nickname_ = other.nickname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Player Clone() {
      return new Player(this);
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

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 2;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Player);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Player other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (Nickname != other.Nickname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid.Length != 0) hash ^= Guid.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
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
      if (Nickname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Nickname);
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
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Player other) {
      if (other == null) {
        return;
      }
      if (other.Guid.Length != 0) {
        Guid = other.Guid;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
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
            Nickname = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PlayerJoin : pb::IMessage<PlayerJoin> {
    private static readonly pb::MessageParser<PlayerJoin> _parser = new pb::MessageParser<PlayerJoin>(() => new PlayerJoin());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerJoin> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.PlayerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerJoin() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerJoin(PlayerJoin other) : this() {
      nickname_ = other.nickname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerJoin Clone() {
      return new PlayerJoin(this);
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 1;
    private string nickname_ = "";
    /// <summary>
    ///Add all data that the user needs to fill in before joining. (avatar? etc.)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerJoin);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerJoin other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nickname != other.Nickname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
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
      if (Nickname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Nickname);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerJoin other) {
      if (other == null) {
        return;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
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
            Nickname = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PlayerJoined : pb::IMessage<PlayerJoined> {
    private static readonly pb::MessageParser<PlayerJoined> _parser = new pb::MessageParser<PlayerJoined>(() => new PlayerJoined());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerJoined> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.PlayerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerJoined() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerJoined(PlayerJoined other) : this() {
      guid_ = other.guid_;
      player_ = other.player_ != null ? other.player_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerJoined Clone() {
      return new PlayerJoined(this);
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

    /// <summary>Field number for the "player" field.</summary>
    public const int PlayerFieldNumber = 2;
    private global::Message.Player player_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Message.Player Player {
      get { return player_; }
      set {
        player_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerJoined);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerJoined other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (!object.Equals(Player, other.Player)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid.Length != 0) hash ^= Guid.GetHashCode();
      if (player_ != null) hash ^= Player.GetHashCode();
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
      if (player_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Player);
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
      if (player_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerJoined other) {
      if (other == null) {
        return;
      }
      if (other.Guid.Length != 0) {
        Guid = other.Guid;
      }
      if (other.player_ != null) {
        if (player_ == null) {
          player_ = new global::Message.Player();
        }
        Player.MergeFrom(other.Player);
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
            if (player_ == null) {
              player_ = new global::Message.Player();
            }
            input.ReadMessage(player_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PlayerLeft : pb::IMessage<PlayerLeft> {
    private static readonly pb::MessageParser<PlayerLeft> _parser = new pb::MessageParser<PlayerLeft>(() => new PlayerLeft());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerLeft> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.PlayerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerLeft() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerLeft(PlayerLeft other) : this() {
      guid_ = other.guid_;
      player_ = other.player_ != null ? other.player_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerLeft Clone() {
      return new PlayerLeft(this);
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

    /// <summary>Field number for the "player" field.</summary>
    public const int PlayerFieldNumber = 2;
    private global::Message.Player player_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Message.Player Player {
      get { return player_; }
      set {
        player_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerLeft);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerLeft other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (!object.Equals(Player, other.Player)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid.Length != 0) hash ^= Guid.GetHashCode();
      if (player_ != null) hash ^= Player.GetHashCode();
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
      if (player_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Player);
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
      if (player_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerLeft other) {
      if (other == null) {
        return;
      }
      if (other.Guid.Length != 0) {
        Guid = other.Guid;
      }
      if (other.player_ != null) {
        if (player_ == null) {
          player_ = new global::Message.Player();
        }
        Player.MergeFrom(other.Player);
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
            if (player_ == null) {
              player_ = new global::Message.Player();
            }
            input.ReadMessage(player_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PlayersNickNameChanged : pb::IMessage<PlayersNickNameChanged> {
    private static readonly pb::MessageParser<PlayersNickNameChanged> _parser = new pb::MessageParser<PlayersNickNameChanged>(() => new PlayersNickNameChanged());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayersNickNameChanged> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.PlayerReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayersNickNameChanged() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayersNickNameChanged(PlayersNickNameChanged other) : this() {
      guid_ = other.guid_;
      player_ = other.player_ != null ? other.player_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayersNickNameChanged Clone() {
      return new PlayersNickNameChanged(this);
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

    /// <summary>Field number for the "player" field.</summary>
    public const int PlayerFieldNumber = 2;
    private global::Message.Player player_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Message.Player Player {
      get { return player_; }
      set {
        player_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayersNickNameChanged);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayersNickNameChanged other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (!object.Equals(Player, other.Player)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid.Length != 0) hash ^= Guid.GetHashCode();
      if (player_ != null) hash ^= Player.GetHashCode();
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
      if (player_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Player);
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
      if (player_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayersNickNameChanged other) {
      if (other == null) {
        return;
      }
      if (other.Guid.Length != 0) {
        Guid = other.Guid;
      }
      if (other.player_ != null) {
        if (player_ == null) {
          player_ = new global::Message.Player();
        }
        Player.MergeFrom(other.Player);
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
            if (player_ == null) {
              player_ = new global::Message.Player();
            }
            input.ReadMessage(player_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
