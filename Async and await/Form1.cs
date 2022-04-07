using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_and_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharacter() {                                      //Method to Count character length in file
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\New folder\\Data.txt")) { 
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(3000);
            };
            return count;
        }
        private async void button1_Click(object sender, EventArgs e)      //This is an Asynchronous method using async modifier
        {
            Task<int> task = new Task<int>(CountCharacter);
            task.Start();
            label1.Text = "Processing File. Please Wait...";
            int count = await task;                                       //await expression is used to suspend the
                                                                          //async method until the awaited task is complete  
            label1.Text = count.ToString() + " Characters in File";
        }
        private void button2_Click(object sender, EventArgs e)          //This is a Synchronous method 
        {
            label1.Text = "Processing File. Please Wait...";
            int count = CountCharacter();
            label1.Text = count.ToString() + " Characters in File";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
