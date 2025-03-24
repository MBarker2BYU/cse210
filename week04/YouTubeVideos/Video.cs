using YouTubeVideos.Interfaces;

namespace YouTubeVideos;

public class Video : IVideo
{
    public Video()
    { }

    internal Video(string title, IPerson author, long length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    internal Video(string title, string firstName, string lastName, long length): this(title, new Person(firstName, lastName), length)
    {}
        
    #region Implementation of IDisplay

    public void AddComment(IComment comment)
        => ((Comments)Comments).Add(comment);


    public void AddComment(IPerson person, string text, byte stars)
        => AddComment(new Comment(person, text, stars));
    
    public void AddComment(string firstName, string lastName, string text)
        => AddComment(new Comment(firstName, lastName, text));
    
    
    public void Display()
    {
        Console.WriteLine($"Title: {Title, -35} Author: {Author, -15} Length: {Length} secs");
        Console.WriteLine($"\nComments:");

        foreach (var comment in Comments)
            comment.Display();
    }

    #endregion

    #region Implementation of IVideo

    public string Title { get; }
    public IPerson Author { get; }
    public long Length { get; }

    public IComments Comments { get; private set; } = new Comments();

    #endregion
}