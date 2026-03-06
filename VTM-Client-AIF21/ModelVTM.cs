using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VTM_Client_AIF21
{
    internal class ModelVTM
    {
        private static IPAddress ipAddress = IPAddress.Parse("127.0.0.1"); //ipHostInfo.AddressList[0];
        private IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);
        private Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        private Socket client   = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        public async void DatenSenden(string message= "0,0,0,0,0,0,0,0<EOF>")
        {
            try
            {
                if (!client.IsBound)
                {
                    await client.ConnectAsync(localEndPoint);
                }
                ArraySegment<byte> messageBytes = new ArraySegment<byte>(Encoding.UTF8.GetBytes(message));
                //_ = await client.SendAsync(messageBytes, SocketFlags.None);
                _ = await client.SendAsync(messageBytes, SocketFlags.None);
                MessageBox.Show("Socket client sent message:" + message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //client.Shutdown(SocketShutdown.Both);
                //client.Close();
            }
        }
        public async void DatenEmpfangen()
        {
            //// Receive ack.
            //var buffer = new byte[1_024];
            //var received = await client.ReceiveAsync(buffer, SocketFlags.None);
            //var response = Encoding.UTF8.GetString(buffer, 0, received);
            //if (response == "<|ACK|>")
            //{
            //    Console.WriteLine(
            //        $"Socket client received acknowledgment: \"{response}\"");
            //    break;
            //}
            //}
            //client.Shutdown(SocketShutdown.Both);
        }


    }
}
