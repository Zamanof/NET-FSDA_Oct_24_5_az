

using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

using var client = new WebClient();

var content = client.DownloadString("https://jsonplaceholder.typicode.com/posts");

var posts = JsonSerializer.Deserialize<List<Post>>(content);

posts.ForEach(Console.WriteLine);


class Post
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("body")]
    public string? Text { get; set; }

    public override string ToString()
    {
        return $"""
                    {Id}
    Title:  {Title}

Text:   {Text}

""";
    }
}