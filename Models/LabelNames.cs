using System.Text.Json.Serialization;

public class LabelNames
{
    [JsonPropertyName("green")]
    public string Green { get; set; }

    [JsonPropertyName("yellow")]
    public string Yellow { get; set; }

    [JsonPropertyName("orange")]
    public string Orange { get; set; }

    [JsonPropertyName("red")]
    public string Red { get; set; }

    [JsonPropertyName("purple")]
    public string Purple { get; set; }

    [JsonPropertyName("blue")]
    public string Blue { get; set; }

    [JsonPropertyName("sky")]
    public string Sky { get; set; }

    [JsonPropertyName("lime")]
    public string Lime { get; set; }

    [JsonPropertyName("pink")]
    public string Pink { get; set; }

    [JsonPropertyName("black")]
    public string Black { get; set; }
}