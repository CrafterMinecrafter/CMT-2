using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static async Task Main(string[] args)
        {

            await ListenToken();
            await Chat.ListenChat();
        }
        public static class Chat
        {
            private static string ChatBuffer = "";
            public static async Task ListenChat()
            {
                TcpListener server = null;
                List<TcpClient> users = new List<TcpClient>();
                List<NetworkStream> stream = new List<NetworkStreams>();
                try
                {
                    IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                    server = new TcpListener(localAddr, 9090);

                    // запуск слушателя
                    server.Start();

                    while (true)
                    {
                        Console.WriteLine("Waiting for connections ");

                        // получаем входящее подключение
                        var client = server.AcceptTcpClient();
                        users.Add(client);
                        Console.WriteLine("Client connected. Sending request");

                        // получаем сетевой поток для чтения и записи
                        stream.Add(client.GetStream());

                        var tokens = Encoding.UTF8.GetBytes(ChatBuffer);
                        // отправка сообщения
                        await s.WriteAsync(tokens, 0, tokens.Length);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private static async Task ListenToken()
        {
            TcpListener server = null;
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, 9090);

                // запуск слушателя
                server.Start();

                while (true)
                {
                    Console.WriteLine("Waiting for connections ");

                    // получаем входящее подключение
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Client connected. Sending request");

                    // получаем сетевой поток для чтения и записи
                    NetworkStream stream = client.GetStream();

                    var tokens = await File.ReadAllTextAsync("./Pro_tokens");
                    // отправка сообщения
                    await stream.WriteAsync(tokens, 0, tokens.Length);

                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}