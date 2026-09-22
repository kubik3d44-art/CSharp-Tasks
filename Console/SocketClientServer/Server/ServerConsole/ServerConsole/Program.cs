using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Однопоточный сервер запущен !");

            // Подготавливаем конечную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 8888);

            // Создаём потоковый сокет, протокол TCP/IP
            Socket sock = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // связываем сокет с конечной точкой
                sock.Bind(ipEndPoint);
                // начинаем прослушку сокета
                sock.Listen(10);

                // начинаем слушать соединения
                while (true)
                {
                    Console.WriteLine("Слушаем, порт {0}", ipEndPoint);

                    // Программа приостанавливается ожидая входящее соединение

                    // сокет для обмена данными с клиентом
                    Socket s = sock.Accept();

                    // сюда записываем полученные от клиента данные
                    string data = null;

                    //клиент есть, начинаем читать от него запрос
                    //массив полученных данных
                    byte[] bytes = new byte[1024];
                    //длина полученных данных
                    int bytesCount = s.Receive(bytes);

                    //декодируем строку
                    data += Encoding.UTF8.GetString(bytes, 0, bytesCount);

                    //показываем данные на консоли
                    Console.Write("Данные от клиента: " + data + "\n\n");

                    //отправляем ответ клиенту
                    string reply = "Query size: " + data.Length.ToString() + " chars";

                    //кодируем ответ сервера
                    byte[] msg = Encoding.UTF8.GetBytes(reply);

                    //отправляем ответ сервера
                    s.Send(msg);

                    if (data.IndexOf("<TheEnd>") > 1)
                    {
                        Console.WriteLine("Соединения завершено.");
                        break;
                    }

                    s.Shutdown(SocketShutdown.Both);
                    s.Close();

                }
            }
            catch (Exception ex)
            { ex.ToString(); }
            finally
            { Console.ReadLine(); }
        }
    }
}