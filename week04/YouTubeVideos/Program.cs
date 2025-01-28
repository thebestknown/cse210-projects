using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video1 = new Video("C# Basics", "Programming Academy", 300);
        Video video2 = new Video("Object-Oriented Programming", "Code Master", 420);
        Video video3 = new Video("Design Patterns Explained", "Tech Guru", 600);

        video1.AddComment(new Comment("Abish", "Great explanation!"));
        video1.AddComment(new Comment("Mateo", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Carlos", "Can you make more videos like this?"));

        video2.AddComment(new Comment("David", "This helped me understand OOP better."));
        video2.AddComment(new Comment("Evelyn", "Thanks for the clear explanation!"));

        video3.AddComment(new Comment("Frank", "Awesome video, keep it up!"));
        video3.AddComment(new Comment("Genesis", "Super useful, thank you!"));
        video3.AddComment(new Comment("Luca", "Love your content!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.DisplayDetails();
        }
    }
}
