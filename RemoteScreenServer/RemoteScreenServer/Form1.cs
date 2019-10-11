using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace RemoteScreenServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static byte[] ReadImageFile(String img)
        {
            FileInfo fileinfo = new FileInfo(img);
            byte[] buf = new byte[fileinfo.Length];
            FileStream fs = new FileStream(img, FileMode.Open, FileAccess.Read);
            fs.Read(buf, 0, buf.Length);
            fs.Close();
            GC.ReRegisterForFinalize(fileinfo);
            GC.ReRegisterForFinalize(fs);
            return buf;
        }

        private void Btn_startServer_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(textBox1.Text), 8765);
            Console.WriteLine("ServerEndPoint = " + iep.ToString());
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(iep);
            server.Listen(10);
            Console.WriteLine("Waiting for connection...");

            Socket client = server.Accept();

            NetworkStream ns = new NetworkStream(client);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            this.Hide();
            int cont = 0;
            while (true)
            {
                Thread.Sleep(1000/60);
                byte[] buffer = ImageToByte(ImprPant());
                client.Send(buffer, buffer.Length, SocketFlags.None);
                Console.WriteLine("Fotograma " + cont++ + " enviado.");
                sw.Flush();
            }
        }

        private Bitmap ImprPant()
        {
            Bitmap screen = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
            Graphics gr = Graphics.FromImage(screen);
            gr.CopyFromScreen(0, 0, 0, 0, screen.Size);
            return screen;
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
