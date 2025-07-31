using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatClientApp
{
    public class ChatServer
    {
        static readonly object consoleLock = new object();

        static void Main()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 5000);
            server.Start();
            Console.WriteLine("Server started. Waiting for connection...");

            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Client connected.");

            NetworkStream stream = client.GetStream();
            Thread receiveThread = new Thread(() => ReceiveMessages(stream));
            receiveThread.Start();

            SendMessages(stream);
        }

        static void ReceiveMessages(NetworkStream stream)
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                lock (consoleLock)
                {
                    Console.WriteLine($"\nClient: {message}");
                    Console.Write("> ");
                }
            }
        }

        static void SendMessages(NetworkStream stream)
        {
            while (true)
            {
                Console.Write("> ");
                string message = Console.ReadLine();
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
