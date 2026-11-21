using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project."); 
        // list of videos and comment
        List<Video> listOfVideos = new List<Video>(); 
        
        // Video1 and comments
        Video video1 = new Video();
        Comment comment1 = new Comment();
        

        // video1
        video1.AddVideo("love", "John", 20);
        // add comment 1
        comment1.AddComment("Gborie", "Lol!");
        // add comment to video
        video1.AddComment(comment1);
        // comment2
        Comment comment2 = new Comment();
        comment2.AddComment("Alpha Sankoh", "HAHAHA");
        video1.AddComment(comment2);
        // comment3
        Comment comment3 = new Comment();
        comment3.AddComment("Mr. Josh", "I love this video1");
        video1.AddComment(comment3);

        // add video1 to list of videos
        listOfVideos.Add(video1);

        // Video2 and its comment
        Video video2 = new Video();
        video2.AddVideo("BYU-Pathway", "Apostle David A Bednar", 45);
        // comment 1
        Comment comment1v2 = new Comment();
        comment1v2.AddComment("Isaac", "I would love to try BYU-Pathway.");
        video2.AddComment(comment1v2);
        // comment 2-v2
        Comment comment2v2 = new Comment();
        comment2v2.AddComment("Fayia", "Byu-Pathway has change my life. try it!");
        video2.AddComment(comment2v2);
        // comment 3-v2
        Comment comment3v2 = new Comment();
        comment3v2.AddComment("Elizabeth", "Thank you for sharing this.");
        video2.AddComment(comment3v2);
        // comment 4
        Comment comment4v2 = new Comment();
        comment4v2.AddComment("Kelvin", "I'm 35, can i register for pathway? ");
        video2.AddComment(comment4v2);
        // add video2 to list of videos
        listOfVideos.Add(video2);

        // Video3 and its comment
        Video video3 = new Video();
        video3.AddVideo("Jesus Christ", "President Abibu Charles", 45);
        // comment 1 video3
        Comment comment1v3 = new Comment();
        comment1v3.AddComment("Gborie", "ohh, The Message was wonderful!");
        video3.AddComment(comment1v3);
        // comment 2
        Comment comment2v3 = new Comment();
        comment2v3.AddComment("Abigial", "Jesus Christ is my saviour");
        video3.AddComment(comment2v3);
        // comment 3
        Comment comment3v3 = new Comment();
        comment3v3.AddComment("Alpha", "He Lives");
        video3.AddComment(comment3v3);
        // comment 4
        Comment comment4v3 = new Comment();
        comment4v3.AddComment("John", "I love Jesus Christ");
        video3.AddComment(comment4v3);

        // add video 3 to list of videos
        listOfVideos.Add(video3);

        // list of videos loop
        foreach (Video item in listOfVideos)
        {
            // title 
            string title = item.GetTitle(); 
            // author
            string author = item.GetAuthor();
            // length
            int length = item.GetLength();
            // number of comments
            int numOfComments = item.GetCommentCount();
            Console.WriteLine($"Video Title: {title} | Author: {author}, Video Length: {length} | Total Comments: {numOfComments}");
            Console.WriteLine($"=====Comment Section=====");
 
            foreach (Comment com in item.GetComments())
            {
                string commenter = com.GetCommenter();
                string text = com.GetText();
                Console.WriteLine($"Name: {commenter}, {text}");
            }
 
            // spaces
            Console.WriteLine();
        }
    }
}