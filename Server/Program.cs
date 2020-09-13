using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        const int port = 8888; // порт для прослушивания подключений
        static async Task Main(string[] args)
        {

            await Listen();
        }
        private static async Task Listen()
        {
                TcpListener server = null;
                try
                {
                    IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                    server = new TcpListener(localAddr, port);

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

                        string response = "Привет мир";
                        byte[] data = Encoding.UTF8.GetBytes(response);

                        // отправка сообщения
                        await stream.WriteAsync(data, 0, data.Length);

                        stream.Close();
                        client.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (server != null)
                        server.Stop();
                }
        }
    }
}