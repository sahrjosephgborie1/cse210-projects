using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    
        // write a program that creates 3-4 videos, sets the appropriate values, 
        // and for each one add a list of 3-4 comments (with the commenter's name and text). 
        // Put each of these videos in a list.

        Comment comment = new Comment();
        Video video = new Video();

        List<Video> listOfVideos = new List<Video>();

        video.AddVideo("love", "John", 20);
        listOfVideos.Add(video);
        video.AddVideo("love", "John", 2000);
        listOfVideos.Add(video);
        video.AddVideo("love", "John", 200);
        listOfVideos.Add(video);

        List<Comment> commentsList = new List<Comment>();

        comment.AddComment("Gborie", "Lol!");
        video.AddComment(comment);
        comment.AddComment("Sahr", "hahaha!");
        video.AddComment(comment); 
        comment.AddComment("Joseph", "really!");
        video.AddComment(comment);  



    }
}