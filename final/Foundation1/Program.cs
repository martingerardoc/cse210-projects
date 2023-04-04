using System;
using System.Collections.Generic;

class Comment {
    public string Name { get; set; }
    public string Text { get; set; }
}

class Video {
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
    
    public int NumComments() {
        return Comments.Count;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video {
            Title = "First Video",
            Author = "John Doe",
            Length = 120
        };
        video1.Comments.Add(new Comment { Name = "Alice", Text = "Great video!" });
        video1.Comments.Add(new Comment { Name = "Bob", Text = "I learned a lot from this." });
        video1.Comments.Add(new Comment { Name = "Charlie", Text = "Can you make a tutorial on this?" });
        
        Video video2 = new Video {
            Title = "Second Video",
            Author = "Jane Smith",
            Length = 180
        };
        video2.Comments.Add(new Comment { Name = "Dave", Text = "This was so helpful, thanks!" });
        video2.Comments.Add(new Comment { Name = "Eve", Text = "I've been looking for a video like this!" });
        video2.Comments.Add(new Comment { Name = "Frank", Text = "I love your videos, keep up the good work!" });
        
        Video video3 = new Video {
            Title = "Third Video",
            Author = "Amy Lee",
            Length = 90
        };
        video3.Comments.Add(new Comment { Name = "George", Text = "Short and sweet, just what I needed." });
        video3.Comments.Add(new Comment { Name = "Hannah", Text = "You make this look so easy!" });
        video3.Comments.Add(new Comment { Name = "Isaac", Text = "Can't wait to try this out myself." });
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        foreach (Video video in videos) {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of comments: " + video.NumComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments) {
                Console.WriteLine(comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }

    }
}