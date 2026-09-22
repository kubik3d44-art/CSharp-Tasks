using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ClientCOnosle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Communicate("localhost", 8888);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            finally
            { Console.ReadLine(); }
        }

        static void Communicate(string hostname, int port)
        {
            //Буфер для входящих данных
            byte[] bytes = new byte[1024];

            //Соединяемся с удалённым сервером

            //Устанавливаем удаленную точку (сервер) для сокета
            IPHostEntry ipHost = Dns.GetHostEntry(hostname);
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

            Socket sock = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            //Подключаемся к серверу
            sock.Connect(ipEndPoint);

            Console.Write("Введите сообщение: ");
            string message = Console.ReadLine();

            Console.WriteLine("Подключаемся к порту {0} ", sock.RemoteEndPoint.ToString());

            byte[] data = Encoding.UTF8.GetBytes(message);

            //Получаем кол-во отправленных байтов
            int bytesSent = sock.Send(data);

            //Получаем ответ от сервера, bytesRec - кол-во принятых байтов
            int bytesRec = sock.Receive(bytes);

            Console.WriteLine("\nОтвет сервера: {0}\n\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));

            //Вызываем Communicate() ещё
            if (message.IndexOf("<TheEnd>") == 1)
            { Communicate(hostname, port); }

            //Освобождаем сокет
            sock.Shutdown(SocketShutdown.Both);
            sock.Close();
        }
    }
}
