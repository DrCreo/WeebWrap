using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace WeebWrap
{
    public class KonachanPost
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("source")]
        public string SourceUrl { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("sample_url")]
        public string SampleUrl { get; set; }

        [JsonProperty("jpeg_url")]
        public string JpegUrl { get; set; }

        public string PostUrl
        {
            get
            {
                return $"http://konachan.com/post/show/{ID}";
            }
        }

        [JsonProperty("tags")]
        public string tags { get; set; }

        public List<string> Tags
        {
            get
            {
                return tags.Split(' ').ToList();
            }
        }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("rating")]
        public string rating { get; set; }

        public Rating Rating
        {
            get
            {
                switch (rating)
                {
                    case "s":
                        return Rating.S;
                    case "q":
                        return Rating.Q;
                    case "e":
                        return Rating.E;
                    default:
                        return Rating.NA;
                }
            }
        }

        [JsonProperty("author")]
        public string Author { get; set; }
    }
}
