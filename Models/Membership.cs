using System.Text.Json.Serialization;

public class Membership
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("idMember")]
    public string IdMember { get; set; }

    [JsonPropertyName("memberType")]
    public string MemberType { get; set; }

    [JsonPropertyName("unconfirmed")]
    public bool Unconfirmed { get; set; }

    [JsonPropertyName("deactivated")]
    public bool Deactivated { get; set; }
}