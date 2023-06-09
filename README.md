# Qdrant .NET Client
This project contains a .NET client for the [Qdrant vector database](https://qdrant.tech/). This client supports HTTP in either blocking or non-blocking fashion.

#### How to use Qdrant client in .NET
```csharp
using QdrantCSharp;

var client = new QdrantHttpClient
    (
        url: "", 
        apiKey: ""
    );

// create a new collection
await client.CreateCollection("my_collection", new VectorParams(size: 100, distance: Distance.COSINE));

// list all the collections
var collections = await client.GetCollections();
```
