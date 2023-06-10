namespace QdrantCSharp.Models;

public class ScoredPoint
{
    public int Id { get; set; }
    public int Version { get; set; }
    public float Score { get; set; }
    public float[] Vector { get; set; }
}
