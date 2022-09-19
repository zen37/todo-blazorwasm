using System.Text.Json.Serialization;

public class launch {
    [JsonPropertyName("id")]
    public string Id { get; set;}

    [JsonPropertyName("launch_date_local")]
    public DateTimeOffset launchDate{get; set;}

    [JsonPropertyName("mission_name")]
    public string Mission {get; set;}

}