using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelloLib;

namespace TelloDrone
{
    using WebEye.Controls.WinForms.StreamPlayerControl;

    public partial class Form1 : Form
    {
        static float sensitivity = 0.5f;

        public Form1()
        {
            InitializeComponent();


            //droneStream.StartPlay(new Uri("rtsp://184.72.239.149/vod/mp4:BigBuckBunny_115k.mov"));

            Tello.onConnection += (Tello.ConnectionState newState) =>
            {
                if (newState != Tello.ConnectionState.Connected)
                {
                }
                if (newState == Tello.ConnectionState.Connected)
                {
                    Tello.setMaxHeight(5);
                }
                label1.Text = ("Tello " + newState.ToString());
            };
            Tello.startConnecting();

            var videoClient = UdpUser.ConnectTo("127.0.0.1", 7038);

            Tello.onVideoData += (byte[] data) =>
            {
                try
                {
                    videoClient.Send(data.Skip(2).ToArray());//Skip 2 byte header and send to ffplay. 
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in Video Feed: " + ex.ToString());
                }
            };

            droneStream.StartPlay(new Uri("udp://127.0.0.1:7038"));
            //var videoClient = UdpUser.ConnectTo("192.168.10.1", 11111);
            //droneStream.StartPlay(new Uri("udp://192.168.10.1:11111"));
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            float[] axis = new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
            switch (keyData)
            {

                case Keys.W:                   
                    axis[3] = sensitivity;         
                    break;

                case Keys.A:                   
                    axis[2] = -sensitivity;         
                    break;

                case Keys.S:
                    axis[3] = -sensitivity;
                    break;

                case Keys.D:
                    axis[2] = sensitivity;
                    break;

                case Keys.Q:                    
                    axis[0] = sensitivity;                    
                    break;

                case Keys.E:                    
                    axis[0] = -sensitivity;
                    break;

                case Keys.Z:                    
                    axis[1] = sensitivity;                    
                    break;

                case Keys.X:                    
                    axis[1] = -sensitivity;                    
                    break;

                case Keys.D1:                    
                    if (sensitivity + 0.25f <= 1f)
                        sensitivity += 0.25f;
                    break;

                case Keys.D2:
                    if (sensitivity - 0.25f >= 0.0f)
                        sensitivity -= 0.25f;
                    break;

                case Keys.Enter:
                    takepic();
                    break;

                case Keys.P:
                    sensitivity = 0.5f;
                    break;

                case Keys.Tab:
                    {
                        if (Tello.connected)
                        {
                            if (Tello.state.flying)
                            {
                                Tello.land();
                            }
                            else
                            {
                                Tello.takeOff();
                            }
                        }
                    }
                    break;
            }
            Tello.controllerState.setAxis(axis[0], axis[1], axis[2], axis[3]);

            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private void takepic()
        {
            Bitmap img = droneStream.GetCurrentFrame();
            img.Save(@"C:\Users\Mohamad K\Desktop\pic.png", ImageFormat.Png);
        }


        private void BttnPic_Click(object sender, EventArgs e)
        {
            takepic();
        }
    }
}
