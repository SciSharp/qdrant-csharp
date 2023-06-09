using System.Text.Json.Serialization;

namespace QdrantCSharp.Models;

public class CollectionInfo
{
    public string Status { get; set; }
    [JsonPropertyName("optimizer_status")]
    public string OptimizerStatus { get; set; }
    [JsonPropertyName("vectors_count")]
    public int VectorsCount { get; set; }
    [JsonPropertyName("indexed_vectors_count")]
    public int IndexedVectorsCount { get; set; }
    [JsonPropertyName("points_count")]
    public int PointsCount { get; set; }
    [JsonPropertyName("segments_count")]
    public int SegmentsCount { get; set; }
    public CollectionConfig Config { get; set; }
}
