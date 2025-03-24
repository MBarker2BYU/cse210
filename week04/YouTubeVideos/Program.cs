using System;
using YouTubeVideos;
using YouTubeVideos.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var _random = new Random();
        
        var persons = new List<Person>
        {
            new("Becky", "McDonnell"),
            new("Jeff", "Brown"),
            new("Steve", "Smith"),
            new("Kevin", "Parker"),
            new("Kim", "Cooper")
        };

        var videoNames = new List<string>
        {
            "How to make a paper airplane",
            "How to make a paper boat",
            "How to make a paper cup",
            "How to make a paper flower",
            "How to make a paper hat"
        };

        var comments = new List<string>
        {
            "This is a great video! I learned a lot from it.",
            "This is an excellent video! I learned a lot from it.",
            "This is a super video! I learned a lot from it.",
            "This is an informative video! I learned a lot from it.",
            "This is an awesome great video! I learned a lot from it."
        };
        
        
        var videos = new Videos();

        foreach (var videoName in videoNames)
        {
            videos.Add(videoName, persons[4], _random.Next(150, 301));
        }

        foreach (var video in videos)
        {
            for (var index = 0; index < _random.Next(3,6); index++)
            {
                video.AddComment(new Comment(persons[_random.Next(0, 4)], comments[_random.Next(0, 5)], (byte)_random.Next(4, 6)));
            }
        }
      
        videos.Display();
        
    }
}