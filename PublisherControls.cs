using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace PubSubGUI
{
    class PublisherControls
    {
        private List<Publisher> publishers;

        public PublisherControls()
        {
            this.publishers = new List<Publisher>();
        }

        public int addPublisher()
        {
            IPAddress local;
            int port = Convert.ToInt32("8008");
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endpt = socket.LocalEndPoint as IPEndPoint;
                local = endpt.Address;
            }
            publishers.Add(new Publisher(String.Format("{0}:{1}", local, port)));
            return publishers.Count - 1;
        }

        public int addPublisher(Publisher publisher)
        {
            publishers.Add(publisher);
            return publishers.Count - 1;
        }

        public bool newTopic(int publishersIndex, string topic)
        {
            return publishers[publishersIndex].newTopic(topic);
        }

        public bool deleteTopic(int publishersIndex, string topic)
        {
            return publishers[publishersIndex].deleteTopic(topic);
        }

        public bool newPost(int publishersIndex, string topic, string date, string messageString)
        {
            return publishers[publishersIndex].newPost(topic, date, messageString);
        }

        public bool closeConnection(int publishersIndex)
        {
            return publishers[publishersIndex].closeConnection();
        }

        public bool inputHandler(string[] inputs)
        {
            if (inputs[1] == "addPublisher")
            {
                if (inputs.Length == 2) addPublisher();
                else addPublisher();
                return true;
            }
            
            return false;
        }
    }
}
