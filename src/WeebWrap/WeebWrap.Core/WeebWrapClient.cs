using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WeebWrap
{
    public class WeebWrapClient
    {

        /// <summary>
        /// Returns the first post found
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public async Task<Post> SearchOnePostAsync(Provider provider, string tags)
        {
            Post post = null;
            List<Post> posts = null;
            string jsonString;
            switch (provider)
            {
                case Provider.Yandere:
                    jsonString = await HttpHandler.GetJsonStringAsync(BaseLinks.YANDERE_SINGLE_POST + tags);
                    posts = JsonConvert.DeserializeObject<List<YanderePost>>(jsonString).ToPostList();
                    if (posts == null) break;
                    post = posts[0];
                    break;
                case Provider.Konachan:
                    jsonString = await HttpHandler.GetJsonStringAsync(BaseLinks.KONACHAN_SINGLE_POST + tags);
                    posts = JsonConvert.DeserializeObject<List<KonachanPost>>(jsonString).ToPostList();
                    if (posts == null) break;
                    post = posts[0];
                    break;
                case Provider.Danbooru:
                    jsonString = await HttpHandler.GetJsonStringAsync(BaseLinks.KONACHAN_SINGLE_POST + tags);
                    posts = JsonConvert.DeserializeObject<List<KonachanPost>>(jsonString).ToPostList();
                    if (posts == null) break;
                    post = posts[0];
                    break;
            }
            if (post == null)
                post = Post.GenerateNull();
            return post;
        }

        /// <summary>
        /// Returns a list of posts with a optional amount parameter the default is 10 the maximum is 100
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="tags"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public async Task<List<Post>> SearchGetListAsync(Provider provider, string tags, int amount = 10)
        {
            if (amount > 100)
                amount = 100;
            List<Post> posts = new List<Post>();
            string jsonString;
            switch (provider)
            {
                case Provider.Yandere:
                    jsonString = await HttpHandler.GetJsonStringAsync(BaseLinks.YANDERE_POST + $"limit={amount}&tags={tags}");
                    posts = JsonConvert.DeserializeObject<List<YanderePost>>(jsonString).ToPostList();
                    break;
                case Provider.Konachan:
                    jsonString = await HttpHandler.GetJsonStringAsync(BaseLinks.KONACHAN_POST + $"limit={amount}&tags={tags}");
                    posts = JsonConvert.DeserializeObject<List<KonachanPost>>(jsonString).ToPostList();
                    break;
                case Provider.Danbooru:
                    jsonString = await HttpHandler.GetJsonStringAsync(BaseLinks.DANBOORU_POST + $"limit={amount}&tags={tags}");
                    posts = JsonConvert.DeserializeObject<List<DanbooruPost>>(jsonString).ToPostList();
                    break;
            }
            if (posts.Count <= 0)
                posts.Add(Post.GenerateNull());
            return posts;
        }

        /// <summary>
        /// Returns a list of the newest posts with a optional amount parameter the default is 10 the maximum is 100
        /// <param name="provider"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public async Task<List<Post>> GetListAsync(Provider provider, int amount = 10)
        {
            if (amount > 100)
                amount = 100;
            List<Post> posts = new List<Post>();
            string jsonString;
            switch (provider)
            {
                case Provider.Yandere:
                    jsonString = await HttpHandler.GetJsonStringAsync(BaseLinks.YANDERE_POST + $"limit={amount}");
                    posts = JsonConvert.DeserializeObject<List<YanderePost>>(jsonString).ToPostList();
                    break;
                case Provider.Konachan:
                    jsonString = await HttpHandler.GetJsonStringAsync(BaseLinks.KONACHAN_POST + $"limit={amount}");
                    posts = JsonConvert.DeserializeObject<List<KonachanPost>>(jsonString).ToPostList();
                    break;
            }
            if (posts.Count <= 0)
                posts.Add(Post.GenerateNull());
            return posts;
        }
    }
}
