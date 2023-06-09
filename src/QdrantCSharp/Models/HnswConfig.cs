using System.Text.Json.Serialization;

namespace QdrantCSharp.Models;

public class HnswConfig
{
    public int M { get; set; }
    [JsonPropertyName("ef_construct")]
    public int EfConstruct { get; set; }
    [JsonPropertyName("full_scan_threshold")]
    public int FullScanThreshold { get; set; }
    [JsonPropertyName("max_indexing_threads")]
    public int MaxIndexingThreads { get; set; }
    [JsonPropertyName("on_disk")]
    public bool OnDisk { get; set; }
    [JsonPropertyName("payload_m")]
    public int PayloadM { get; set; }
}
