using System.Net;
using System.Text.Json;
using JetBrains.Annotations;
using RichardSzalay.MockHttp;

namespace CopilotExamples.Tests;

[TestClass]
[TestSubject(typeof(JSONPlaceholderHexagonal))]
public class JSONPlaceholderHexagonalTest
{
    private JSONPlaceholderAdapter _adapter;
    private HttpClient _httpClient;

    private MockHttpMessageHandler _mockHttp;

    [TestInitialize]
    public void Initialize()
    {
        _mockHttp = new MockHttpMessageHandler();
        _httpClient = new HttpClient(_mockHttp);
        _adapter = new JSONPlaceholderAdapter(_httpClient);
    }

    [TestMethod]
    public async Task GetPostAsync_ReturnsPost()
    {
        var expectedPost = new JSONPlaceholderHexagonal.Post
        {
            Id = 1,
            Title = "Test Title",
            Body = "Test Body",
            UserId = 1
        };

        _mockHttp.When("https://jsonplaceholder.typicode.com/posts/1")
            .Respond("application/json",
                JsonSerializer.Serialize(expectedPost));

        var result = await _adapter.GetPostAsync(1);

        Assert.AreEqual(expectedPost.Id, result.Id);
        Assert.AreEqual(expectedPost.Title, result.Title);
        Assert.AreEqual(expectedPost.Body, result.Body);
        Assert.AreEqual(expectedPost.UserId, result.UserId);
    }

    [TestMethod]
    public async Task GetAllPostsAsync_ReturnsPostList()
    {
        var expectedPosts = new[]
        {
            new JSONPlaceholderHexagonal.Post
                { Id = 1, Title = "Title 1", Body = "Body 1", UserId = 1 },
            new JSONPlaceholderHexagonal.Post
                { Id = 2, Title = "Title 2", Body = "Body 2", UserId = 1 }
        };

        _mockHttp.When("https://jsonplaceholder.typicode.com/posts")
            .Respond("application/json",
                JsonSerializer.Serialize(expectedPosts));

        var result = await _adapter.GetAllPostsAsync();

        CollectionAssert.AreEqual(expectedPosts, result.ToArray());
    }

    [TestMethod]
    public async Task CreatePostAsync_ReturnsCreatedPost()
    {
        var postToCreate = new JSONPlaceholderHexagonal.Post
        {
            Title = "New Title",
            Body = "New Body",
            UserId = 1
        };

        var expectedPost = postToCreate with { Id = 1 };

        _mockHttp.When("https://jsonplaceholder.typicode.com/posts")
            .Respond("application/json",
                JsonSerializer.Serialize(expectedPost));

        var result = await _adapter.CreatePostAsync(postToCreate);

        Assert.AreEqual(expectedPost.Id, result.Id);
        Assert.AreEqual(expectedPost.Title, result.Title);
        Assert.AreEqual(expectedPost.Body, result.Body);
        Assert.AreEqual(expectedPost.UserId, result.UserId);
    }

    [TestMethod]
    public async Task DeletePostAsync_ReturnsTrue()
    {
        _mockHttp.When("https://jsonplaceholder.typicode.com/posts/1")
            .Respond(HttpStatusCode.OK);

        var result = await _adapter.DeletePostAsync(1);

        Assert.IsTrue(result);
    }

    [TestMethod]
    [TestCategory("Integration")]
    public async Task Integration_GetPostAsync_ReturnsPost()
    {
        var client = new HttpClient();
        var adapter = new JSONPlaceholderAdapter(client);
        var result = await adapter.GetPostAsync(1);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Id);
        Assert.IsNotNull(result.Title);
        Assert.IsNotNull(result.Body);
        Assert.AreEqual(1, result.UserId);
    }

    [TestMethod]
    [TestCategory("Integration")]
    public async Task Integration_GetAllPostsAsync_ReturnsPostList()
    {
        var client = new HttpClient();
        var adapter = new JSONPlaceholderAdapter(client);
        var result = await adapter.GetAllPostsAsync();

        Assert.IsNotNull(result);
        Assert.IsTrue(result.Any());
    }

    [TestMethod]
    [TestCategory("Integration")]
    public async Task Integration_CreatePostAsync_ReturnsCreatedPost()
    {
        var client = new HttpClient();
        var adapter = new JSONPlaceholderAdapter(client);
        var postToCreate = new JSONPlaceholderHexagonal.Post
        {
            Title = "Test Title",
            Body = "Test Body",
            UserId = 1
        };

        var result = await adapter.CreatePostAsync(postToCreate);

        Assert.IsNotNull(result);
        Assert.IsTrue(result.Id > 0);
        Assert.AreEqual(postToCreate.Title, result.Title);
        Assert.AreEqual(postToCreate.Body, result.Body);
        Assert.AreEqual(postToCreate.UserId, result.UserId);
    }

    [TestMethod]
    [TestCategory("Integration")]
    public async Task Integration_DeletePostAsync_ReturnsTrue()
    {
        var client = new HttpClient();
        var adapter = new JSONPlaceholderAdapter(client);
        var result = await adapter.DeletePostAsync(1);

        Assert.IsTrue(result);
    }
}