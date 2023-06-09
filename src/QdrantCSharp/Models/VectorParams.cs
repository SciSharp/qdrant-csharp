using System.Text.Json.Serialization;

namespace QdrantCSharp.Models;

public class VectorParams
{
    public int Size { get; set; }

    public string Distance { get; set; }

    [JsonPropertyName("on_disk")]
    public bool OnDisk { get; set; }

    [JsonPropertyName("hnsw_config")]
    public HnswConfig HnswConfig { get; set; }

    [JsonPropertyName("quantization_config")]
    public ScalarQuantization QuantizationConfig { get; set; }

    public VectorParams(int size, string distance, bool onDisk = true)
    {
        Size = size;
        Distance = distance;
        OnDisk = onDisk;
    }
}