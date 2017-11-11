using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RedBallTracker
{
    static class ResponseThread
    {
        static void Setup()
        {
            while (true)
            {
                HttpListenerContext context = HttpListener.listener.GetContext(); // get a context
                                                                                  // Now, you'll find the request URL in context.Request.Url
                byte[] _responseArray = Encoding.UTF8.GetBytes("<html><head><title>Localhost server -- port 5000</title></head>" +
                "<body>Welcome to the <strong>Localhost server</strong> -- <em>port 5000!</em></body></html>"); // get the bytes to response
                context.Response.OutputStream.Write(_responseArray, 0, _responseArray.Length); // write bytes to the output stream
                context.Response.KeepAlive = false; // set the KeepAlive bool to false
                context.Response.Close(); // close the connection
                Console.WriteLine("Respone given to a request.");
            }
        }
        public static Thread Create()
        {
            Thread responseThread = new Thread(Setup);
            return responseThread;
        }
    }
}
