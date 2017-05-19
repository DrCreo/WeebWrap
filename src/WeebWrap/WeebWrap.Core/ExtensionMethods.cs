using System.Collections.Generic;

namespace WeebWrap
{
    internal static class ExtensionMethods
    {
        // Yandere
        internal static Post ToPost(this YanderePost yanderePost)
        {
            var post = new Post();

            post.Author = yanderePost.Author;
            post.FileUrl = yanderePost.FileUrl;
            post.ID = yanderePost.ID;
            post.JpegUrl = yanderePost.JpegUrl;
            post.PostUrl = yanderePost.PostUrl;
            post.PreviewUrl = yanderePost.PreviewUrl;
            post.Rating = yanderePost.Rating;
            post.SampleUrl = yanderePost.SampleUrl;
            post.Score = yanderePost.Score;
            post.Provider = "yande.re";
            post.SourceUrl = yanderePost.SourceUrl;
            post.Tags = yanderePost.Tags;

            return post;
        }

        internal static List<Post> ToPostList(this List<YanderePost> yanderPosts)
        {
            var postList = new List<Post>();

            yanderPosts.ForEach(p => postList.Add(p.ToPost()));
            return postList;
        }

        // Konachan
        internal static Post ToPost(this KonachanPost konachanPost)
        {
            var post = new Post();

            post.Author = konachanPost.Author;
            post.FileUrl = konachanPost.FileUrl;
            post.ID = konachanPost.ID;
            post.JpegUrl = konachanPost.JpegUrl;
            post.PostUrl = konachanPost.PostUrl;
            post.PreviewUrl = konachanPost.PreviewUrl;
            post.Rating = konachanPost.Rating;
            post.SampleUrl = konachanPost.SampleUrl;
            post.Score = konachanPost.Score;
            post.Provider = "konachan.com";
            post.SourceUrl = konachanPost.SourceUrl;
            post.Tags = konachanPost.Tags;

            return post;
        }

        internal static List<Post> ToPostList(this List<KonachanPost> konachanPosts)
        {
            var postList = new List<Post>();

            konachanPosts.ForEach(p => postList.Add(p.ToPost()));
            return postList;
        }

        // Danbooru
        internal static Post ToPost(this DanbooruPost danbooru)
        {
            var post = new Post();

            post.Author = danbooru.Author;
            post.FileUrl = danbooru.FileUrl;
            post.ID = danbooru.ID;
            post.JpegUrl = danbooru.JpegUrl;
            post.PostUrl = danbooru.PostUrl;
            post.PreviewUrl = danbooru.PreviewUrl;
            post.Rating = danbooru.Rating;
            post.SampleUrl = danbooru.SampleUrl;
            post.Score = danbooru.Score;
            post.SourceUrl = danbooru.SourceUrl;
            post.Provider = "danbooru.donmai.us";
            post.Tags = danbooru.Tags;

            return post;
        }

        internal static List<Post> ToPostList(this List<DanbooruPost> danbooru)
        {
            var postList = new List<Post>();

            danbooru.ForEach(p => postList.Add(p.ToPost()));
            return postList;
        }
    }
}
