// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: companies.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Companies {

  /// <summary>Holder for reflection information generated from companies.proto</summary>
  public static partial class CompaniesReflection {

    #region Descriptor
    /// <summary>File descriptor for companies.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompaniesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9jb21wYW5pZXMucHJvdG8SCWNvbXBhbmllcyJMCgdDb21wYW55EgwKBHV1",
            "aWQYASABKAkSDAoEbmFtZRgCIAEoCRIRCglwZXJtYWxpbmsYAyABKAkSEgoK",
            "Y3JlYXRlZF9hdBgTIAEoBCItChhHZXRDb21wYW55QnlQZXJtYWxpbmtSZXES",
            "EQoJcGVybWFsaW5rGAEgASgJIkAKGUdldENvbXBhbnlCeVBlcm1hbGlua1Jl",
            "c3ASIwoHY29tcGFueRgBIAEoCzISLmNvbXBhbmllcy5Db21wYW55MnEKCUNv",
            "bXBhbmllcxJkChVHZXRDb21wYW55QnlQZXJtYWxpbmsSIy5jb21wYW5pZXMu",
            "R2V0Q29tcGFueUJ5UGVybWFsaW5rUmVxGiQuY29tcGFuaWVzLkdldENvbXBh",
            "bnlCeVBlcm1hbGlua1Jlc3AiAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Companies.Company), global::Companies.Company.Parser, new[]{ "Uuid", "Name", "Permalink", "CreatedAt" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Companies.GetCompanyByPermalinkReq), global::Companies.GetCompanyByPermalinkReq.Parser, new[]{ "Permalink" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Companies.GetCompanyByPermalinkResp), global::Companies.GetCompanyByPermalinkResp.Parser, new[]{ "Company" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Company represents a client site inside of Namely, for example "namely".
  ///  It includes basic information about the company such as its name and
  ///  permalink.
  /// </summary>
  public sealed partial class Company : pb::IMessage<Company> {
    private static readonly pb::MessageParser<Company> _parser = new pb::MessageParser<Company>(() => new Company());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Company> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Companies.CompaniesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Company() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Company(Company other) : this() {
      uuid_ = other.uuid_;
      name_ = other.name_;
      permalink_ = other.permalink_;
      createdAt_ = other.createdAt_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Company Clone() {
      return new Company(this);
    }

    /// <summary>Field number for the "uuid" field.</summary>
    public const int UuidFieldNumber = 1;
    private string uuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uuid {
      get { return uuid_; }
      set {
        uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "permalink" field.</summary>
    public const int PermalinkFieldNumber = 3;
    private string permalink_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Permalink {
      get { return permalink_; }
      set {
        permalink_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 19;
    private ulong createdAt_;
    /// <summary>
    ///  A unix timestamp of the time this company was created in Namely
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Company);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Company other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uuid != other.Uuid) return false;
      if (Name != other.Name) return false;
      if (Permalink != other.Permalink) return false;
      if (CreatedAt != other.CreatedAt) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Permalink.Length != 0) hash ^= Permalink.GetHashCode();
      if (CreatedAt != 0UL) hash ^= CreatedAt.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Permalink.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Permalink);
      }
      if (CreatedAt != 0UL) {
        output.WriteRawTag(152, 1);
        output.WriteUInt64(CreatedAt);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Permalink.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Permalink);
      }
      if (CreatedAt != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(CreatedAt);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Company other) {
      if (other == null) {
        return;
      }
      if (other.Uuid.Length != 0) {
        Uuid = other.Uuid;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Permalink.Length != 0) {
        Permalink = other.Permalink;
      }
      if (other.CreatedAt != 0UL) {
        CreatedAt = other.CreatedAt;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Uuid = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Permalink = input.ReadString();
            break;
          }
          case 152: {
            CreatedAt = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetCompanyByPermalinkReq : pb::IMessage<GetCompanyByPermalinkReq> {
    private static readonly pb::MessageParser<GetCompanyByPermalinkReq> _parser = new pb::MessageParser<GetCompanyByPermalinkReq>(() => new GetCompanyByPermalinkReq());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCompanyByPermalinkReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Companies.CompaniesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCompanyByPermalinkReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCompanyByPermalinkReq(GetCompanyByPermalinkReq other) : this() {
      permalink_ = other.permalink_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCompanyByPermalinkReq Clone() {
      return new GetCompanyByPermalinkReq(this);
    }

    /// <summary>Field number for the "permalink" field.</summary>
    public const int PermalinkFieldNumber = 1;
    private string permalink_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Permalink {
      get { return permalink_; }
      set {
        permalink_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetCompanyByPermalinkReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCompanyByPermalinkReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Permalink != other.Permalink) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Permalink.Length != 0) hash ^= Permalink.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Permalink.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Permalink);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Permalink.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Permalink);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCompanyByPermalinkReq other) {
      if (other == null) {
        return;
      }
      if (other.Permalink.Length != 0) {
        Permalink = other.Permalink;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Permalink = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetCompanyByPermalinkResp : pb::IMessage<GetCompanyByPermalinkResp> {
    private static readonly pb::MessageParser<GetCompanyByPermalinkResp> _parser = new pb::MessageParser<GetCompanyByPermalinkResp>(() => new GetCompanyByPermalinkResp());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCompanyByPermalinkResp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Companies.CompaniesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCompanyByPermalinkResp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCompanyByPermalinkResp(GetCompanyByPermalinkResp other) : this() {
      Company = other.company_ != null ? other.Company.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCompanyByPermalinkResp Clone() {
      return new GetCompanyByPermalinkResp(this);
    }

    /// <summary>Field number for the "company" field.</summary>
    public const int CompanyFieldNumber = 1;
    private global::Companies.Company company_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Companies.Company Company {
      get { return company_; }
      set {
        company_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetCompanyByPermalinkResp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCompanyByPermalinkResp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Company, other.Company)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (company_ != null) hash ^= Company.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (company_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Company);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (company_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Company);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCompanyByPermalinkResp other) {
      if (other == null) {
        return;
      }
      if (other.company_ != null) {
        if (company_ == null) {
          company_ = new global::Companies.Company();
        }
        Company.MergeFrom(other.Company);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (company_ == null) {
              company_ = new global::Companies.Company();
            }
            input.ReadMessage(company_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code