using System;

namespace RedBallTracker
{
    static class HttpListener
    {
        public static System.Net.HttpListener listener = new System.Net.HttpListener();
        public static void Init()
        {
            Console.WriteLine("Setting up listener");
            listener.Prefixes.Add("http://172.24.3.145:5000/api/scores");
            listener.Start();
            if (listener.IsListening)
            {
                Console.WriteLine("HTTP listener set up");
            }
            else Console.WriteLine("Failed to set up HTTP listener");
        }
    }
}
