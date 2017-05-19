using System.Collections.Generic;

namespace WeebWrap
{
    public class Post
    {   
        public int ID { get; internal set; }
        
        public string SourceUrl { get; internal set; }
        
        public string FileUrl { get; internal set; }
        
        public string PreviewUrl { get; internal set; }
       
        public string SampleUrl { get; internal set; }
        
        public string JpegUrl { get; internal set; }

        public string PostUrl { get; internal set; }

        public List<string> Tags { get; internal set; }

        public int Score { get; internal set; }

        public Rating Rating { get; internal set; }

        public string Author { get; internal set; }

        public string Provider { get; internal set; }

        public static Post GenerateNull()
        {
            var post = new Post();
            post.Author = "null";
            post.FileUrl = "null";
            post.ID = 0;
            post.JpegUrl= "null";
            post.PostUrl= "null";
            post.PreviewUrl= "null";
            post.Rating= Rating.NA;
            post.SampleUrl = "null";
            post.Score = 0;
            post.Provider = "null";
            post.Tags = new List<string>();
            post.Tags.Add("null");
            return post;
        }

        public override string ToString()
        {
            string tags = string.Empty;
            Tags.ForEach(t => tags += $"{t}, ");
            string str = string.Empty;
            str += $"Author     : {Author}\n";
            str += $"FileUrl    : {FileUrl}\n";
            str += $"ID         : {ID}\n";
            str += $"JpegUrl    : {JpegUrl}\n";
            str += $"PostUrl    : {PostUrl}\n";
            str += $"PreviewUrl : {PreviewUrl}\n";
            str += $"Rating     : {Rating}\n";
            str += $"SampleUrl  : {SampleUrl}\n";
            str += $"Provider   : {Provider}\n";
            str += $"Score      : {Score}\n";
            str += $"Tags       : {tags}\n";
            return str;
        }
    }
}
