using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ActionApp
{
    public partial class MainWindow : Form
    {
        static ProductsQueue productsQueue = new ProductsQueue();

        public MainWindow()
        {
            InitializeComponent();
            productsQueue.Sender += SendMessage;
        }

        //method contains sender tecnology, which can be replaced if it need
        public static void SendMessage(string message)
        {
            MemoryMappedFilesSender.ToSend(message);
        }

        private void buttonCamera_Click(object sender, EventArgs e)
        {
            productsQueue.AddProduct(radioFit.Checked);
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            productsQueue.DropProduct();
        }

        //addition function for open second application "monitor", which display the queue
        private void buttonOpenMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Monitor\\MonitorApp.exe");
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Исполняемый файл не найден.");
            }
        }
    }
}
