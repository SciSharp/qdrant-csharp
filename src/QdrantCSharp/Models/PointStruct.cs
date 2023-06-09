namespace QdrantCSharp.Models;

public class PointStruct
{
    public int Id { get; set; } 
    public float[] Vector { get; set; }
    // payload

    public PointStruct(int id, float[] vector)
    {
        Id = id;
        Vector = vector;
    }
}
