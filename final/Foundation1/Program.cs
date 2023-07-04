using System;

namespace YouTubeTracker
{
        
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Video> videos = new List<Video>();

            Video video1 = new Video("American English Accent", "Jill Diamond", 770);
            video1.AddComment("cami-chinois9219", "Very eductive. Please upload more videos.");
            video1.AddComment("mariatrombacco", "Your videos help me improve my English");
            video1.AddComment("costarhica9132", "Great content.");
            video1.AddComment("mohammed roamy", "Great jobI love your videos");
            videos.Add(video1);

            Video video2 = new Video("American English Rhythm: Clapping", "Jill Diamond", 139);
            video2.AddComment("Gab0000", "I love your useful tips, Jill! Happy New year");
            video2.AddComment("Luzy2011", "Good idea. Thanks");
            video2.AddComment("ramzy-6566", "Good tips");
            videos.Add(video2);

            Video video3 = new Video("Test Driven Vs Behavior Driven Development", "Continous Delivery", 1121);
            video3.AddComment("Redheadtama1", "Great stuff");
            video3.AddComment("luissantos9120", "I actually think that gherkin and cucumber created more harm than helped");
            video3.AddComment("mateuszszczecinski824", "Thank you for your inspiring material");
            videos.Add(video3);

            Video video4 = new Video("The Life of an Ancient Spartan","Timeline - World History Documentries", 2887);
            video4.AddComment("georgefurman4371", " Terror was the method of domination over the slaves.");
            video4.AddComment("victormonroy33", "Love this video");
            video4.AddComment("billn.1318", "If bethany was my history teacher.I swear I would have had straight A's in history and perfect attendance with extra credit");
            video4.AddComment("schmuelsonsradang4301", "She presented it so well, detailed and lively.");
            videos.Add(video4);




            foreach (Video v in videos)
            {
                v.DisplayVideoInfo();
                Console.WriteLine();
            }
        }
    }
}