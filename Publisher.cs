using Newtonsoft.Json;
using WebSocketSharp;

namespace PubSubGUI
{
    public class Publisher
    {
        private WebSocket webSocket;
        private bool serverClosed;

        public Publisher(string ip)
        {
            webSocket = new WebSocket("ws://" + ip + "/BrokerController");
            serverClosed = false;
            webSocket.OnMessage += WebSocket_OnMessage;
            webSocket.Connect();

            if (!serverClosed)
            {
                Message message = new Message("New Publisher");
                webSocket.Send(JsonConvert.SerializeObject(message));
            }
        }

        public bool newTopic(string topic)
        {
            if (serverClosed) return false;
            Message message = new Message("New Topic");
            message.topic = topic;
            webSocket.Send(JsonConvert.SerializeObject(message));
            return true;
        }

        public bool deleteTopic(string topic)
        {
            if (serverClosed) return false;
            Message message = new Message("Delete Topic", topic);
            webSocket.Send(JsonConvert.SerializeObject(message));
            return true;
        }

        public bool closeConnection()
        {
            if (serverClosed) return false;
            webSocket.Close();
            return true;
        }

        public bool newPost(string topic, string date, string messageString)
        {
            if (serverClosed) return false;
            Post post = new Post(topic, date, messageString);
            Message message = new Message("New Post", post);
            webSocket.Send(JsonConvert.SerializeObject(message));
            return true;
        }

        private void WebSocket_OnMessage(object sender, MessageEventArgs e)
        {
            Message message = JsonConvert.DeserializeObject<Message>(e.Data);
            if(message.type == "serverClosed")
            {
                serverClosed = true;
            }
        }
    }
}
