using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace RemoteScreen
{
    public partial class Form1 : Form
    {
        Bitmap[] frames = new Bitmap[180];
        public byte[] buffer = new byte[1048576];
        public Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            double ratioScreen = (16.0 / 9.0); //Relación del aspecto 16/9 para la pantalla
            pic_Screen.Size = new Size(Convert.ToInt32(pic_Screen.Size.Height*ratioScreen), pic_Screen.Size.Height); //Cuando se cambie el tamaño del PictureBox se multiplica por el ratio para que se mantenga
            this.Size = new Size(Convert.ToInt32(pic_Screen.Size.Width + 40), this.Size.Height); //
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            txt_ip.Text = "";
            txt_ip.ForeColor = Color.Black;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (txt_ip.Text == "")
            {
                txt_ip.Text = "Dirección IP";
                txt_ip.ForeColor = Color.Gray;
            }
        }

        private void Btn_ver_pantalla_Click(object sender, EventArgs e)
        {
            if (txt_ip.Text != "" && txt_ip.Text != "Dirección IP")
                StartClient(txt_ip.Text);
        }

        private void StartClient(String ip)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ip), 8765);
            Console.WriteLine("ClientEndPoint = " + iep.ToString());
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            client.Connect(iep);
            Console.WriteLine("Cliente conectado");

            NetworkStream ns = new NetworkStream(client);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            //int contador = 0;
            byte[] buffer = new byte[1048576];

            //MessageBox.Show("Antes de mostrar");

            timer1.Enabled = true;

            //while (true)
            //{
            //    Array.Clear(buffer, 0, buffer.Length);
            //    client.Receive(buffer, buffer.Length, SocketFlags.None);
            //    Console.WriteLine("Receive success" + contador.ToString());
            //    //FileStream fs = File.Create( contador++.ToString() +".jpg");
            //    //fs.Write(buffer, 0, buffer.Length);
            //    TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            //    //frames[contador++] = (Bitmap)tc.ConvertFrom(buffer);
            //    pic_Screen.Image = (Bitmap)tc.ConvertFrom(buffer);
            //    Thread.Sleep(2000);
            //}

            //sr.Close();
            //sw.Close();
            //ns.Close(); 
            //client.Close();
        }

        private void ViewScreen()
        {
            try
            {
                client.Receive(buffer, buffer.Length, SocketFlags.None);
                Console.WriteLine("Fotograma " + contador + " recibido.");
                //FileStream fs = File.Create( contador++.ToString() +".jpg");
                //fs.Write(buffer, 0, buffer.Length);
                TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                //frames[contador++] = (Bitmap)tc.ConvertFrom(buffer);
                pic_Screen.Image = (Bitmap)tc.ConvertFrom(buffer);
                label1.Text = contador++.ToString();
            }
            catch
            {

            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ViewScreen();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            btn_ver_pantalla.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            txt_ip.Visible = false;
            pic_Screen.Size = new Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
            pic_Screen.Location = new Point(0, 0);
        }

        private void OffFullscreen()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            btn_ver_pantalla.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            label1.Visible = true;
            txt_ip.Visible = true;
            pic_Screen.Size = new Size(640, 360);
            pic_Screen.Location = new Point(12, 41);
            this.Size = new Size(681, 455);
        }

        private void Outfullscreen_Click(object sender, EventArgs e)
        {
            OffFullscreen();
        }

    }
}
