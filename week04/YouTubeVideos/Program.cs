using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "CodeWithRae", 612);
        video1.AddComment(new Comment("Chidi", "Very clear explanation, thank you!"));
        video1.AddComment(new Comment("Amaka", "I finally understand classes."));
        video1.AddComment(new Comment("Tunde", "Please do one on interfaces next."));
        videos.Add(video1);

        Video video2 = new Video("Budget Laptop Review 2026", "TechNaija", 845);
        video2.AddComment(new Comment("Ngozi", "Which model has the best battery?"));
        video2.AddComment(new Comment("Ibrahim", "Great comparison of prices."));
        video2.AddComment(new Comment("Funke", "Is it good for coding?"));
        video2.AddComment(new Comment("Emeka", "Subscribed!"));
        videos.Add(video2);

        Video video3 = new Video("Easy Jollof Rice at Home", "KitchenStories", 530);
        video3.AddComment(new Comment("Blessing", "Made this today and it was perfect."));
        video3.AddComment(new Comment("Segun", "The smoky flavor tip is gold."));
        video3.AddComment(new Comment("Halima", "My family loved it."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}