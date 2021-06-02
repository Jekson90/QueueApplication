using MonitorApp.Communication;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MonitorApp
{
    public partial class MainWindow : Form
    {
        static Queue<bool> queue;
        static List<PictureBox> boxList;
        static Thread dataThread;
        delegate string Receiver();
        static Receiver rec;

        public MainWindow()
        {
            InitializeComponent();

            queue = new();
            boxList = new List<PictureBox>{ box1, box2, box3, box4, box5};

            //creating thread for updating box color
            dataThread = new Thread(new ThreadStart(UpdatingData));

            //technology for receive data with queue from first application "action"
            //this raplaced if it need
            rec = MemoryMappedFilesReceiver.ToReceive;
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            UpdateColor();
            dataThread.Start();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) => dataThread.Interrupt();

        //updating color boxes in window
        static void UpdateColor()
        {
            IEnumerator e = queue.GetEnumerator();
            e.Reset();
            bool next = e.MoveNext();

            for (int i = 0; i < 5; i++)
            {
                if (next)
                {
                    if ((bool)e.Current)
                        boxList[i].BackColor = Color.Green;
                    else
                        boxList[i].BackColor = Color.Orange;
                    next = e.MoveNext();
                }
                else
                    boxList[i].BackColor = Color.Gray;
            }
        }

        //refresh queue with new data
        static void FillQueue(string data)
        {
            //clear queue
            while (queue.Count != 0)
                queue.Dequeue();

            //contain queue new data
            for (int i = 0; i < data.Length; i++)
                queue.Enqueue(data[i] == '1');
        }

        //receive data from first app
        //update queue information and boxes color in window
        static void UpdatingData()
        {
            string currentData = "";

            while (true)
            {
                string newData;
                
                try
                {
                    newData = rec();
                }
                catch (System.IO.FileNotFoundException)
                {
                    newData = "";
                }

                if (newData != currentData)
                {
                    currentData = newData;
                    FillQueue(currentData);
                    UpdateColor();
                }

                Thread.Sleep(100);
            }
        }
    }
}
