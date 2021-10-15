using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smtp_via_SOcket_2
{
    public partial class Form1 : Form
    {
        public SocketSSL client = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            byte[] bytes = new byte[1024];

            IPHostEntry ipHostInfo = Dns.GetHostEntry(textBox1.Text);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, int.Parse(textBox2.Text));
            // Create a TCP/IP  socket.  
            client = new SocketSSL(textBox1.Text, ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(remoteEP);

                button1.Enabled = false;

                byte[] msg = Encoding.ASCII.GetBytes("HELO SmtpViaSocketV2" + Environment.NewLine);
                int bytesSent = client.Send(msg);
                int bytesRec = client.Receive(bytes);
                String message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                listBox1.Items.Add(message);

                msg = Encoding.ASCII.GetBytes("EHLO SmtpViaSocketV2" + Environment.NewLine); //textBox3.Text + 
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                listBox1.Items.Add(message);

                msg = Encoding.ASCII.GetBytes("auth login" + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                listBox1.Items.Add(message);

                msg = Encoding.ASCII.GetBytes(Base64Encode(textBox3.Text) + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                listBox1.Items.Add(message);

                msg = Encoding.ASCII.GetBytes(Base64Encode(textBox4.Text) + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                listBox1.Items.Add(message);

                msg = Encoding.ASCII.GetBytes("MAIL FROM: <" + textBox5.Text + ">" + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                listBox1.Items.Add(message);

                msg = Encoding.ASCII.GetBytes("RCPT TO: <" + textBox6.Text + ">" + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                listBox1.Items.Add(message);

                msg = Encoding.ASCII.GetBytes("DATA" + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                listBox1.Items.Add(message);

                msg = Encoding.ASCII.GetBytes(textBox18.Text + Environment.NewLine + "." + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                listBox1.Items.Add(message);

                // Release the socket.  
                client.Shutdown(SocketShutdown.Both);
                client.Close();

                button1.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
