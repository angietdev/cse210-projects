using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("10 Amazing Facts About Toucans", "Wild Birds Channel", 1180);
        video1.AddComment(new Comment("Sophie", "I had no idea toucans could regulate their body temperature with their beaks!"));
        video1.AddComment(new Comment("Daniel", "The colors on these birds are incredible."));
        video1.AddComment(new Comment("Emiliano", "You realize that nothing was luke, that there is a creator."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Why Sparrows Are Everywhere", "Bird Explorer", 1025);
        video2.AddComment(new Comment("Ghetthe", "Every year, a pair of sparrows return to their nest on the side of my patio to breed, and then they leave."));
        video2.AddComment(new Comment("Max", "That's why I have a garden at my house and I give them bread and tortillas."));
        video2.AddComment(new Comment("William", "There are many in Cuba. Really many, hahaha. They are very gentle birds."));
        video2.AddComment(new Comment("Ritter", "I felt an overwhelming urge to cry. Thank you so much. Excellent video, my friend."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("The Intelligence of Crows", "Nature Insights", 1450);
        video3.AddComment(new Comment("Ethan", "Crows are much smarter than I expected."));
        video3.AddComment(new Comment("Mia", "The tool-making examples were fascinating."));
        video3.AddComment(new Comment("Benjamin", "Excellent documentary, I learned a lot."));
        videos.Add(video3);

        
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}