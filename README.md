# Qdrant .NET Client
This project contains a .NET client for the [Qdrant vector database](https://qdrant.tech/). This client supports HTTP in either blocking or non-blocking fashion.

[![NuGet](https://img.shields.io/nuget/dt/Qdrant.Client.svg)](https://www.nuget.org/packages/Qdrant.Client) 

#### How to use Qdrant client in .NET
```csharp
using QdrantCSharp;

var client = new QdrantHttpClient
    (
        url: "", 
        apiKey: ""
    );

var collectionName = "my_collection";

// Create a new collection
await client.CreateCollection(collectionName, new VectorParams(size: 4, distance: Distance.DOT));

// List all the collections
var collections = await client.GetCollections();

// Insert vectors
await client.Upsert(collectionName, points: new List<PointStruct>
{
    new PointStruct(id:1, vector: new float[]{ 0.05f, 0.61f, 0.76f, 0.74f }),
    new PointStruct(id:2, vector: new float[]{ 0.19f, 0.81f, 0.75f, 0.11f }),
    new PointStruct(id:3, vector: new float[]{ 0.36f, 0.55f, 0.47f, 0.94f }),
    new PointStruct(id:4, vector: new float[]{ 0.18f, 0.01f, 0.85f, 0.80f }),
    new PointStruct(id:5, vector: new float[]{ 0.24f, 0.18f, 0.22f, 0.44f }),
    new PointStruct(id:6, vector: new float[]{ 0.35f, 0.08f, 0.11f, 0.44f })
});

// Get collection info
var collectionInfo = await client.GetCollection(collectionName);

Console.WriteLine($"Upserted {collectionInfo.Result.VectorsCount} points");

// Vector search
var result = await client.Search
(
    collectionName,
    new float[] { 0.2f, 0.1f, 0.9f, 0.7f },
    limit: 3
);

// Delete collection
await client.DeleteCollection(collectionName);
```
