using QdrantCSharp.RestAPIs;
using Refit;
using System.Net.Http;
using System.Threading.Tasks;

namespace QdrantCSharp;

public class QdrantHttpClient : IQdrantClient
{
    string _url;
    string _apiKey;


    static HttpClient _httpClient;

    HttpClient GetHttpClient()
    {
        if (_httpClient == null)
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(_url)
            };
            _httpClient.DefaultRequestHeaders.Add("api-key", _apiKey);
        }

        return _httpClient;
    }

    IQdrantCollectionApi _collectionApi
        => RestService.For<IQdrantCollectionApi>(GetHttpClient());

    IQdrantPointApi _pointsApi
        => RestService.For<IQdrantPointApi>(GetHttpClient());

    public QdrantHttpClient(string url, string apiKey)
    {
        _url = url;
        _apiKey = apiKey;
    }

    public async Task<QdrantHttpResponse<CollectionList>> GetCollections()
        => await _collectionApi.GetCollections();

    public async Task<QdrantHttpResponse<CollectionInfo>> GetCollection(string collectionName)
        => await _collectionApi.GetCollection(collectionName);

    public async Task<QdrantHttpResponse<bool>> CreateCollection(string collectionName, VectorParams vectorsConfig)
    {
        var result = await _collectionApi.CreateCollection(collectionName, new CollectCreationBody
        {
            Vectors = vectorsConfig
        });
        return result;
    }

    public async Task<QdrantHttpResponse<bool>> DeleteCollection(string collectionName)
        => await _collectionApi.DeleteCollection(collectionName);

    public async Task<QdrantHttpResponse<UpdateResult>> Upsert(string collectionName, List<PointStruct> points)
        => await _pointsApi.Upsert(collectionName, new PointsUpsertBody
        {
            Points = points
        });

    public async Task<QdrantHttpResponse<ScoredPoint[]>> Search(string collectionName, float[] queryVector, int limit = 10, int offset = 0)
        => await _pointsApi.Search(collectionName, new SearchBody
        {
            Limit = limit,
            Offset = offset,
            Vector = queryVector
        });
}
