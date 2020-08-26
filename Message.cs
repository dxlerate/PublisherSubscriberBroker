using Newtonsoft.Json;

namespace PubSubGUI
{
    public class Message
    {
        [JsonProperty]
        public string type;
        [JsonProperty]
        public string topic;
        [JsonProperty]
        public Post post;

        public Message(string type)
        {
            this.type = type;
        }

        public Message(string type, string topic)
        {
            this.type = type;
            this.topic = topic;
        }

        public Message(string type, Post post)
        {
            this.type = type;
            this.post = post;
        }

        [JsonConstructor]
        public Message(string type, string topic, Post post)
        {
            this.type = type;
            this.topic = topic;
            this.post = post;
        }
    }
}
