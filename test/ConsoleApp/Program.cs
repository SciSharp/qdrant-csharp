// See https://aka.ms/new-console-template for more information

using QdrantCSharp;
using QdrantCSharp.Models;

var client = new QdrantHttpClient
    (
        url: "https://808bac29-e17d-4f4e-bcc5-2bb3f873b1a1.us-east-1-0.aws.cloud.qdrant.io:6333",
        apiKey: ""
);
// await client.CreateCollection("my_collection", new VectorParams(size: 4, distance: Distance.COSINE));
var collections = await client.GetCollections();
await client.Upsert("my_collection", points: new List<PointStruct>
{
    new PointStruct(id:1, vector: new float[]{ 0.05f, 0.61f, 0.76f, 0.74f }),
    new PointStruct(id:2, vector: new float[]{ 0.19f, 0.81f, 0.75f, 0.11f }),
    new PointStruct(id:3, vector: new float[]{ 0.36f, 0.55f, 0.47f, 0.94f }),
    new PointStruct(id:4, vector: new float[]{ 0.18f, 0.01f, 0.85f, 0.80f }),
    new PointStruct(id:5, vector: new float[]{ 0.24f, 0.18f, 0.22f, 0.44f }),
    new PointStruct(id:6, vector: new float[]{ 0.35f, 0.08f, 0.11f, 0.44f })
});
var collectionInfo = await client.GetCollection("my_collection");
Console.WriteLine($"Upserted {collectionInfo.Result.VectorsCount} points");
// await client.DeleteCollection("my_collection");
collections = await client.GetCollections();

Console.ReadLine();