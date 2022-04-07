using System;
using System.Threading;
using System.Windows.Forms;

namespace Multithreading
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;                                        //Disabling buttons

            Thread workerThread = new Thread(TimeConsuming);                //Creating new thread to execute time consuming thread
            workerThread.Start();                                           //starting that thread separately to unload the work from main thread

            //*TimeConsuming();                                             //this will put main thread to sleep for 5 seconds  

            button1.Enabled = true;                                         //Enabling buttons
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)                                  //Printing numbers on listbox on button 2 click
            {
                listBox1.Items.Add(i);
            }
        }

        private void TimeConsuming() { Thread.Sleep(5000); }              //Method to put process to sleep for 5 second

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
