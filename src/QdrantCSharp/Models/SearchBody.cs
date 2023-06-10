using System.Text.Json.Serialization;

namespace QdrantCSharp.Models;

public class SearchBody
{
    public float[] Vector { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    [JsonPropertyName("score_threshold")]
    public float ScoreThreshold { get; set; }
}
