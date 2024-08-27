﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace SSW.GitSkills.GitHub;

public partial class GetOrgQuery
{
    [JsonProperty("organization")]
    public Organization Organization { get; set; }
}

public partial class Organization
{
    [JsonProperty("__typename")]
    public OrganizationTypename Typename { get; set; }

    [JsonProperty("membersWithRole")]
    public OrganizationMemberConnection MembersWithRole { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public partial class OrganizationMemberConnection
{
    [JsonProperty("__typename")]
    public OrganizationMemberConnectionTypename Typename { get; set; }

    [JsonProperty("nodes")]
    public List<User> Nodes { get; set; }
}

public partial class User
{
    [JsonProperty("__typename")]
    public UserTypename Typename { get; set; }

    [JsonProperty("contributionsCollection")]
    public ContributionsCollection ContributionsCollection { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public partial class ContributionsCollection
{
    [JsonProperty("__typename")]
    public ContributionsCollectionTypename Typename { get; set; }

    [JsonProperty("commitContributionsByRepository")]
    public List<CommitContributionByRepository> CommitContributionsByRepository { get; set; }
}

public partial class CommitContributionByRepository
{
    [JsonProperty("__typename")]
    public CommitContributionByRepositoryTypename Typename { get; set; }

    [JsonProperty("contributions")]
    public CreatedContributionCommitConnection Contributions { get; set; }

    [JsonProperty("repository")]
    public Repository Repository { get; set; }
}

public partial class CreatedContributionCommitConnection
{
    [JsonProperty("__typename")]
    public CreatedContributionCommitConnectionTypename Typename { get; set; }

    [JsonProperty("totalCount")]
    public double TotalCount { get; set; }
}

public partial class Repository
{
    [JsonProperty("__typename")]
    public RepositoryTypename Typename { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("languages")]
    public LanguageConnection Languages { get; set; }

    [JsonProperty("repositoryTopics")]
    public RepositoryTopicConnection RepositoryTopics { get; set; }
}

public partial class LanguageConnection
{
    [JsonProperty("__typename")]
    public LanguageConnectionTypename Typename { get; set; }

    [JsonProperty("nodes")]
    public List<Language> Nodes { get; set; }
}

public partial class Language
{
    [JsonProperty("__typename")]
    public LanguageTypename Typename { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public partial class RepositoryTopicConnection
{
    [JsonProperty("__typename")]
    public RepositoryTopicConnectionTypename Typename { get; set; }

    [JsonProperty("nodes")]
    public List<RepositoryTopic> Nodes { get; set; }
}

public partial class RepositoryTopic
{
    [JsonProperty("__typename")]
    public RepositoryTopicTypename Typename { get; set; }

    [JsonProperty("topic")]
    public Topic Topic { get; set; }
}

public partial class Topic
{
    [JsonProperty("__typename")]
    public TopicTypename Typename { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public enum CreatedContributionCommitConnectionTypename { CreatedCommitContributionConnection };

public enum LanguageTypename { Language };

public enum LanguageConnectionTypename { LanguageConnection };

public enum TopicTypename { Topic };

public enum RepositoryTopicTypename { RepositoryTopic };

public enum RepositoryTopicConnectionTypename { RepositoryTopicConnection };

public enum RepositoryTypename { Repository };

public enum CommitContributionByRepositoryTypename { CommitContributionsByRepository };

public enum ContributionsCollectionTypename { ContributionsCollection };

public enum UserTypename { User };

public enum OrganizationMemberConnectionTypename { OrganizationMemberConnection };

public enum OrganizationTypename { Organization };

public partial class Language
{
    public static Language FromJson(string json) => JsonConvert.DeserializeObject<Language>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class LanguageConnection
{
    public static LanguageConnection FromJson(string json) => JsonConvert.DeserializeObject<LanguageConnection>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class Topic
{
    public static Topic FromJson(string json) => JsonConvert.DeserializeObject<Topic>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class RepositoryTopic
{
    public static RepositoryTopic FromJson(string json) => JsonConvert.DeserializeObject<RepositoryTopic>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class RepositoryTopicConnection
{
    public static RepositoryTopicConnection FromJson(string json) => JsonConvert.DeserializeObject<RepositoryTopicConnection>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class Repository
{
    public static Repository FromJson(string json) => JsonConvert.DeserializeObject<Repository>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class CreatedContributionCommitConnection
{
    public static CreatedContributionCommitConnection FromJson(string json) => JsonConvert.DeserializeObject<CreatedContributionCommitConnection>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class CommitContributionByRepository
{
    public static CommitContributionByRepository FromJson(string json) => JsonConvert.DeserializeObject<CommitContributionByRepository>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class ContributionsCollection
{
    public static ContributionsCollection FromJson(string json) => JsonConvert.DeserializeObject<ContributionsCollection>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class User
{
    public static User FromJson(string json) => JsonConvert.DeserializeObject<User>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class OrganizationMemberConnection
{
    public static OrganizationMemberConnection FromJson(string json) => JsonConvert.DeserializeObject<OrganizationMemberConnection>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class Organization
{
    public static Organization FromJson(string json) => JsonConvert.DeserializeObject<Organization>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public partial class GetOrgQuery
{
    public static GetOrgQuery FromJson(string json) => JsonConvert.DeserializeObject<GetOrgQuery>(json, SSW.GitSkills.GitHub.Converter.Settings);
}

public static class Serialize
{
    public static string ToJson(this Language self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this LanguageConnection self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this Topic self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this RepositoryTopic self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this RepositoryTopicConnection self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this Repository self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this CreatedContributionCommitConnection self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this CommitContributionByRepository self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this ContributionsCollection self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this User self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this OrganizationMemberConnection self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this Organization self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
    public static string ToJson(this GetOrgQuery self) => JsonConvert.SerializeObject(self, SSW.GitSkills.GitHub.Converter.Settings);
}

internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            LanguageTypenameConverter.Singleton,
            LanguageConnectionTypenameConverter.Singleton,
            TopicTypenameConverter.Singleton,
            RepositoryTopicTypenameConverter.Singleton,
            RepositoryTopicConnectionTypenameConverter.Singleton,
            RepositoryTypenameConverter.Singleton,
            CreatedContributionCommitConnectionTypenameConverter.Singleton,
            CommitContributionByRepositoryTypenameConverter.Singleton,
            ContributionsCollectionTypenameConverter.Singleton,
            UserTypenameConverter.Singleton,
            OrganizationMemberConnectionTypenameConverter.Singleton,
            OrganizationTypenameConverter.Singleton,
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
    };
}

internal class LanguageTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(LanguageTypename) || t == typeof(LanguageTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "Language")
        {
            return LanguageTypename.Language;
        }
        throw new Exception("Cannot unmarshal type LanguageTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (LanguageTypename)untypedValue;
        if (value == LanguageTypename.Language)
        {
            serializer.Serialize(writer, "Language");
            return;
        }
        throw new Exception("Cannot marshal type LanguageTypename");
    }

    public static readonly LanguageTypenameConverter Singleton = new LanguageTypenameConverter();
}

internal class LanguageConnectionTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(LanguageConnectionTypename) || t == typeof(LanguageConnectionTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "LanguageConnection")
        {
            return LanguageConnectionTypename.LanguageConnection;
        }
        throw new Exception("Cannot unmarshal type LanguageConnectionTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (LanguageConnectionTypename)untypedValue;
        if (value == LanguageConnectionTypename.LanguageConnection)
        {
            serializer.Serialize(writer, "LanguageConnection");
            return;
        }
        throw new Exception("Cannot marshal type LanguageConnectionTypename");
    }

    public static readonly LanguageConnectionTypenameConverter Singleton = new LanguageConnectionTypenameConverter();
}

internal class TopicTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(TopicTypename) || t == typeof(TopicTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "Topic")
        {
            return TopicTypename.Topic;
        }
        throw new Exception("Cannot unmarshal type TopicTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (TopicTypename)untypedValue;
        if (value == TopicTypename.Topic)
        {
            serializer.Serialize(writer, "Topic");
            return;
        }
        throw new Exception("Cannot marshal type TopicTypename");
    }

    public static readonly TopicTypenameConverter Singleton = new TopicTypenameConverter();
}

internal class RepositoryTopicTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(RepositoryTopicTypename) || t == typeof(RepositoryTopicTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "RepositoryTopic")
        {
            return RepositoryTopicTypename.RepositoryTopic;
        }
        throw new Exception("Cannot unmarshal type RepositoryTopicTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (RepositoryTopicTypename)untypedValue;
        if (value == RepositoryTopicTypename.RepositoryTopic)
        {
            serializer.Serialize(writer, "RepositoryTopic");
            return;
        }
        throw new Exception("Cannot marshal type RepositoryTopicTypename");
    }

    public static readonly RepositoryTopicTypenameConverter Singleton = new RepositoryTopicTypenameConverter();
}

internal class RepositoryTopicConnectionTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(RepositoryTopicConnectionTypename) || t == typeof(RepositoryTopicConnectionTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "RepositoryTopicConnection")
        {
            return RepositoryTopicConnectionTypename.RepositoryTopicConnection;
        }
        throw new Exception("Cannot unmarshal type RepositoryTopicConnectionTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (RepositoryTopicConnectionTypename)untypedValue;
        if (value == RepositoryTopicConnectionTypename.RepositoryTopicConnection)
        {
            serializer.Serialize(writer, "RepositoryTopicConnection");
            return;
        }
        throw new Exception("Cannot marshal type RepositoryTopicConnectionTypename");
    }

    public static readonly RepositoryTopicConnectionTypenameConverter Singleton = new RepositoryTopicConnectionTypenameConverter();
}

internal class RepositoryTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(RepositoryTypename) || t == typeof(RepositoryTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "Repository")
        {
            return RepositoryTypename.Repository;
        }
        throw new Exception("Cannot unmarshal type RepositoryTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (RepositoryTypename)untypedValue;
        if (value == RepositoryTypename.Repository)
        {
            serializer.Serialize(writer, "Repository");
            return;
        }
        throw new Exception("Cannot marshal type RepositoryTypename");
    }

    public static readonly RepositoryTypenameConverter Singleton = new RepositoryTypenameConverter();
}

internal class CreatedContributionCommitConnectionTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(CreatedContributionCommitConnectionTypename) || t == typeof(CreatedContributionCommitConnectionTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "CreatedCommitContributionConnection")
        {
            return CreatedContributionCommitConnectionTypename.CreatedCommitContributionConnection;
        }
        throw new Exception("Cannot unmarshal type CreatedContributionCommitConnectionTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (CreatedContributionCommitConnectionTypename)untypedValue;
        if (value == CreatedContributionCommitConnectionTypename.CreatedCommitContributionConnection)
        {
            serializer.Serialize(writer, "CreatedCommitContributionConnection");
            return;
        }
        throw new Exception("Cannot marshal type CreatedContributionCommitConnectionTypename");
    }

    public static readonly CreatedContributionCommitConnectionTypenameConverter Singleton = new CreatedContributionCommitConnectionTypenameConverter();
}

internal class CommitContributionByRepositoryTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(CommitContributionByRepositoryTypename) || t == typeof(CommitContributionByRepositoryTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "CommitContributionsByRepository")
        {
            return CommitContributionByRepositoryTypename.CommitContributionsByRepository;
        }
        throw new Exception("Cannot unmarshal type CommitContributionByRepositoryTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (CommitContributionByRepositoryTypename)untypedValue;
        if (value == CommitContributionByRepositoryTypename.CommitContributionsByRepository)
        {
            serializer.Serialize(writer, "CommitContributionsByRepository");
            return;
        }
        throw new Exception("Cannot marshal type CommitContributionByRepositoryTypename");
    }

    public static readonly CommitContributionByRepositoryTypenameConverter Singleton = new CommitContributionByRepositoryTypenameConverter();
}

internal class ContributionsCollectionTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(ContributionsCollectionTypename) || t == typeof(ContributionsCollectionTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "ContributionsCollection")
        {
            return ContributionsCollectionTypename.ContributionsCollection;
        }
        throw new Exception("Cannot unmarshal type ContributionsCollectionTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (ContributionsCollectionTypename)untypedValue;
        if (value == ContributionsCollectionTypename.ContributionsCollection)
        {
            serializer.Serialize(writer, "ContributionsCollection");
            return;
        }
        throw new Exception("Cannot marshal type ContributionsCollectionTypename");
    }

    public static readonly ContributionsCollectionTypenameConverter Singleton = new ContributionsCollectionTypenameConverter();
}

internal class UserTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(UserTypename) || t == typeof(UserTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "User")
        {
            return UserTypename.User;
        }
        throw new Exception("Cannot unmarshal type UserTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (UserTypename)untypedValue;
        if (value == UserTypename.User)
        {
            serializer.Serialize(writer, "User");
            return;
        }
        throw new Exception("Cannot marshal type UserTypename");
    }

    public static readonly UserTypenameConverter Singleton = new UserTypenameConverter();
}

internal class OrganizationMemberConnectionTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(OrganizationMemberConnectionTypename) || t == typeof(OrganizationMemberConnectionTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "OrganizationMemberConnection")
        {
            return OrganizationMemberConnectionTypename.OrganizationMemberConnection;
        }
        throw new Exception("Cannot unmarshal type OrganizationMemberConnectionTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (OrganizationMemberConnectionTypename)untypedValue;
        if (value == OrganizationMemberConnectionTypename.OrganizationMemberConnection)
        {
            serializer.Serialize(writer, "OrganizationMemberConnection");
            return;
        }
        throw new Exception("Cannot marshal type OrganizationMemberConnectionTypename");
    }

    public static readonly OrganizationMemberConnectionTypenameConverter Singleton = new OrganizationMemberConnectionTypenameConverter();
}

internal class OrganizationTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(OrganizationTypename) || t == typeof(OrganizationTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "Organization")
        {
            return OrganizationTypename.Organization;
        }
        throw new Exception("Cannot unmarshal type OrganizationTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (OrganizationTypename)untypedValue;
        if (value == OrganizationTypename.Organization)
        {
            serializer.Serialize(writer, "Organization");
            return;
        }
        throw new Exception("Cannot marshal type OrganizationTypename");
    }

    public static readonly OrganizationTypenameConverter Singleton = new OrganizationTypenameConverter();
}

