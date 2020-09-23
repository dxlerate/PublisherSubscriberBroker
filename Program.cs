using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubSubGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        //[STAThread]

        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("Press Enter to close.");
            string input = Console.ReadLine();
            if(input == "GUI")
            {
                new Thread(PublisherForm).Start();
            }
        }

        private static void PublisherForm()
        {
            PublisherControls publisherControls = new PublisherControls();
            publisherControls.addPublisher();
            PublisherGUI publisherGUI = new PublisherGUI(publisherControls);
        }
    }
}
