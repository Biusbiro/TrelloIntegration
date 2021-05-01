using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Root
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("desc")]
    public string Desc { get; set; }

    [JsonPropertyName("descData")]
    public object DescData { get; set; }

    [JsonPropertyName("closed")]
    public bool Closed { get; set; }

    [JsonPropertyName("dateClosed")]
    public object DateClosed { get; set; }

    [JsonPropertyName("idOrganization")]
    public string IdOrganization { get; set; }

    [JsonPropertyName("idEnterprise")]
    public object IdEnterprise { get; set; }

    [JsonPropertyName("limits")]
    public object Limits { get; set; }

    [JsonPropertyName("pinned")]
    public object Pinned { get; set; }

    [JsonPropertyName("shortLink")]
    public string ShortLink { get; set; }

    [JsonPropertyName("powerUps")]
    public List<object> PowerUps { get; set; }

    [JsonPropertyName("dateLastActivity")]
    public DateTime DateLastActivity { get; set; }

    [JsonPropertyName("idTags")]
    public List<object> IdTags { get; set; }

    [JsonPropertyName("datePluginDisable")]
    public object DatePluginDisable { get; set; }

    [JsonPropertyName("creationMethod")]
    public object CreationMethod { get; set; }

    [JsonPropertyName("ixUpdate")]
    public object IxUpdate { get; set; }

    [JsonPropertyName("enterpriseOwned")]
    public bool EnterpriseOwned { get; set; }

    [JsonPropertyName("idBoardSource")]
    public string IdBoardSource { get; set; }

    [JsonPropertyName("idMemberCreator")]
    public string IdMemberCreator { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("starred")]
    public bool Starred { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("prefs")]
    public Prefs Prefs { get; set; }

    [JsonPropertyName("subscribed")]
    public bool Subscribed { get; set; }

    [JsonPropertyName("labelNames")]
    public LabelNames LabelNames { get; set; }

    [JsonPropertyName("dateLastView")]
    public DateTime DateLastView { get; set; }

    [JsonPropertyName("shortUrl")]
    public string ShortUrl { get; set; }

    [JsonPropertyName("templateGallery")]
    public object TemplateGallery { get; set; }

    [JsonPropertyName("premiumFeatures")]
    public List<object> PremiumFeatures { get; set; }

    [JsonPropertyName("memberships")]
    public List<Membership> Memberships { get; set; }
}