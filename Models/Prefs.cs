using System.Text.Json.Serialization;

public class Prefs
{
    [JsonPropertyName("permissionLevel")]
    public string PermissionLevel { get; set; }

    [JsonPropertyName("hideVotes")]
    public bool HideVotes { get; set; }

    [JsonPropertyName("voting")]
    public string Voting { get; set; }

    [JsonPropertyName("comments")]
    public string Comments { get; set; }

    [JsonPropertyName("invitations")]
    public string Invitations { get; set; }

    [JsonPropertyName("selfJoin")]
    public bool SelfJoin { get; set; }

    [JsonPropertyName("cardCovers")]
    public bool CardCovers { get; set; }

    [JsonPropertyName("isTemplate")]
    public bool IsTemplate { get; set; }

    [JsonPropertyName("cardAging")]
    public string CardAging { get; set; }

    [JsonPropertyName("calendarFeedEnabled")]
    public bool CalendarFeedEnabled { get; set; }

    [JsonPropertyName("background")]
    public string Background { get; set; }

    [JsonPropertyName("backgroundImage")]
    public string BackgroundImage { get; set; }

    [JsonPropertyName("backgroundImageScaled")]
    public List<BackgroundImageScaled> BackgroundImageScaled { get; set; }

    [JsonPropertyName("backgroundTile")]
    public bool BackgroundTile { get; set; }

    [JsonPropertyName("backgroundBrightness")]
    public string BackgroundBrightness { get; set; }

    [JsonPropertyName("backgroundBottomColor")]
    public string BackgroundBottomColor { get; set; }

    [JsonPropertyName("backgroundTopColor")]
    public string BackgroundTopColor { get; set; }

    [JsonPropertyName("canBePublic")]
    public bool CanBePublic { get; set; }

    [JsonPropertyName("canBeEnterprise")]
    public bool CanBeEnterprise { get; set; }

    [JsonPropertyName("canBeOrg")]
    public bool CanBeOrg { get; set; }

    [JsonPropertyName("canBePrivate")]
    public bool CanBePrivate { get; set; }

    [JsonPropertyName("canInvite")]
    public bool CanInvite { get; set; }
}