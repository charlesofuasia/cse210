using System;

namespace YouTubeTracker
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _length;
        public string _remark;
        public string _name;
        public List<Comment> _comments;

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        public int GetCommentNumbers()
        {
            return _comments.Count;
        }

        public void AddComment(string name, string remark)
        {
            Comment comment = new Comment(name, remark);
            _comments.Add(comment);
        }

        public void DisplayComments()
        {
            Console.WriteLine("Comments:");
            foreach (Comment item in _comments)
            {
                Console.WriteLine($"{item._name} - {item._remark}");
            }
        }

        public void DisplayVideoInfo()
        {
            Console.WriteLine($"\nVideo Title: {_title}\nCreated by: {_author}\nDuration: {_length} secs\nComments: {_comments.Count}");
            DisplayComments();
        }

    }
}