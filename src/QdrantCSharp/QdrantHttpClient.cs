using QdrantCSharp.QdrantRestAPIs;
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

    public QdrantHttpClient(string url, string apiKey)
    {
        _url = url;
        _apiKey = apiKey;
    }

    public async Task<QdrantHttpResponse<CollectionsResponse>> GetCollections()
        => await _collectionApi.GetCollections();

    public async Task<QdrantHttpResponse<bool>> CreateCollection(string collectionName, VectorParams vectorsConfig)
    {
        var result = await _collectionApi.CreateCollection(collectionName, new CollectCreationRequest
        {
            Vectors = vectorsConfig
        });
        return result;
    }
}
