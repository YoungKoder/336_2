using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SPS_Lab2_Server
{
    class Program
    {
        const int port = 8888;
        static TcpListener listener;
        static void Main(string[] args)
        {
            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAd = ipHostInfo.AddressList[0];

                listener = new TcpListener(ipAd, port);
                listener.Start();

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ClientObject clientObject = new ClientObject(client);

                    // создаем новый поток для обслуживания нового клиента
                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
            Console.ReadLine();
        }
    }
}
