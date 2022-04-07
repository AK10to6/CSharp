using System;
using System.Threading;                                                   //Includes all threading classes
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreadingg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
