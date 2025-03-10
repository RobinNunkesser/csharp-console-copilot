using System.Net.Http.Json;

namespace CopilotExamples;

public class JSONPlaceholderNoArch
{
    private readonly HttpClient _httpClient;

    public JSONPlaceholderNoArch(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetPostsAsync()
    {
        var response =
            await _httpClient.GetAsync(
                "https://jsonplaceholder.typicode.com/posts");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> GetPostByIdAsync(int id)
    {
        var response =
            await _httpClient.GetAsync(
                $"https://jsonplaceholder.typicode.com/posts/{id}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> CreatePostAsync(string title, string body,
        int userId)
    {
        var post = new
        {
            title,
            body,
            userId
        };
        var response =
            await _httpClient.PostAsJsonAsync(
                "https://jsonplaceholder.typicode.com/posts", post);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> UpdatePostAsync(int id, string title, string body,
        int userId)
    {
        var post = new
        {
            id,
            title,
            body,
            userId
        };
        var response = await _httpClient.PutAsJsonAsync(
            $"https://jsonplaceholder.typicode.com/posts/{id}", post);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> DeletePostAsync(int id)
    {
        var response =
            await _httpClient.DeleteAsync(
                $"https://jsonplaceholder.typicode.com/posts/{id}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}