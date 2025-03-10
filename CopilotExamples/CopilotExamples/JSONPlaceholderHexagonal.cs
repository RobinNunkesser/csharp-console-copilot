using System.Net.Http.Json;

namespace CopilotExamples;

public class JSONPlaceholderHexagonal
{
    private readonly IPostPort _postPort;

    public JSONPlaceholderHexagonal(IPostPort postPort)
    {
        _postPort = postPort;
    }

    public interface IPostPort
    {
        Task<Post> GetPostAsync(int id);
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<Post> CreatePostAsync(Post post);
        Task<Post> UpdatePostAsync(Post post);
        Task<bool> DeletePostAsync(int id);
    }

    public record Post
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string Body { get; init; }
        public int UserId { get; init; }
    }
}

public class JSONPlaceholderAdapter : JSONPlaceholderHexagonal.IPostPort
{
    private const string BaseUrl = "https://jsonplaceholder.typicode.com/posts";
    private readonly HttpClient _httpClient;

    public JSONPlaceholderAdapter(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<JSONPlaceholderHexagonal.Post> GetPostAsync(int id)
    {
        var response =
            await _httpClient.GetFromJsonAsync<JSONPlaceholderHexagonal.Post>(
                $"{BaseUrl}/{id}");
        return response ??
               throw new InvalidOperationException(
                   $"Post with id {id} not found");
    }

    public async Task<IEnumerable<JSONPlaceholderHexagonal.Post>>
        GetAllPostsAsync()
    {
        var response =
            await _httpClient
                .GetFromJsonAsync<IEnumerable<JSONPlaceholderHexagonal.Post>>(
                    BaseUrl);
        return response ?? Enumerable.Empty<JSONPlaceholderHexagonal.Post>();
    }

    public async Task<JSONPlaceholderHexagonal.Post> CreatePostAsync(
        JSONPlaceholderHexagonal.Post post)
    {
        var response = await _httpClient.PostAsJsonAsync(BaseUrl, post);
        response.EnsureSuccessStatusCode();
        return await response.Content
                   .ReadFromJsonAsync<JSONPlaceholderHexagonal.Post>()
               ?? throw new InvalidOperationException("Failed to create post");
    }

    public async Task<JSONPlaceholderHexagonal.Post> UpdatePostAsync(
        JSONPlaceholderHexagonal.Post post)
    {
        var response =
            await _httpClient.PutAsJsonAsync($"{BaseUrl}/{post.Id}", post);
        response.EnsureSuccessStatusCode();
        return await response.Content
                   .ReadFromJsonAsync<JSONPlaceholderHexagonal.Post>()
               ?? throw new InvalidOperationException(
                   $"Failed to update post {post.Id}");
    }

    public async Task<bool> DeletePostAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
        return response.IsSuccessStatusCode;
    }
}