// See https://aka.ms/new-console-template for more information

using QdrantCSharp;
using QdrantCSharp.Models;
using System.Drawing;

var client = new QdrantHttpClient
    (
        url: "https://808bac29-e17d-4f4e-bcc5-2bb3f873b1a1.us-east-1-0.aws.cloud.qdrant.io:6333",
        apiKey: ""
);
var result1 = await client.CreateCollection("my_collection", new VectorParams(size: 100, distance: Distance.COSINE));
var result2 = await client.GetCollections();

Console.ReadLine();