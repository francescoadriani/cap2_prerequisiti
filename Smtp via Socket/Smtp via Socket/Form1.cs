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

namespace Smtp_via_Socket
{
    public partial class Form1 : Form
    {
        public Socket client = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];

            IPHostEntry ipHostInfo = Dns.GetHostEntry(textBox1.Text);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, int.Parse(textBox2.Text));
            // Create a TCP/IP  socket.  
            client = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(remoteEP);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox5.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                button1.Enabled = false;

            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes(textBox3.Text + Environment.NewLine);

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox6.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes(textBox4.Text + Environment.NewLine) ;

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox7.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes(textBox8.Text + Environment.NewLine);

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox9.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            }
            catch (Exception ex)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes(textBox10.Text + Environment.NewLine);

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox11.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            }
            catch (Exception ex)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes(textBox12.Text + Environment.NewLine);

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox13.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            }
            catch (Exception ex)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes(textBox14.Text + Environment.NewLine);

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox15.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            }
            catch (Exception ex)
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes("EXIT" + Environment.NewLine);

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                String endMessage = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                // Release the socket.  
                client.Shutdown(SocketShutdown.Both);
                client.Close();

                button1.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes(textBox20.Text + Environment.NewLine);

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox21.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            }
            catch (Exception ex)
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes(textBox18.Text + Environment.NewLine);

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox19.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            }
            catch (Exception ex)
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try
            {
                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes(textBox16.Text + Environment.NewLine);

                // Send the data through the socket.  
                int bytesSent = client.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = client.Receive(bytes);
                textBox17.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            }
            catch (Exception ex)
            {

            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
