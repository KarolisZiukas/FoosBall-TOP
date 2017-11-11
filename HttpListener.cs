using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RedBallTracker
{
    static class HttpListener
    {
        public static System.Net.HttpListener listener = new System.Net.HttpListener();
        public static void Init()
        {
            Console.WriteLine("Setting up listener");
            listener.Prefixes.Add("http://localhost:5000/");
            listener.Start();
            if (listener.IsListening)
            {
                Console.WriteLine("HTTP listener set up");
            }
            else Console.WriteLine("Failed to set up HTTP listener");
        }
    }
}
