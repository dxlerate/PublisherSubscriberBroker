using Newtonsoft.Json;

namespace PubSubGUI
{
    public class Post
    {
        [JsonProperty]
        public string topic;
        [JsonProperty]
        public string date;
        [JsonProperty]
        public string message;

        [JsonConstructor]
        public Post(string topic, string date, string message)
        {
            this.topic = topic;
            this.date = date;
            this.message = message;
        }
    }
}
