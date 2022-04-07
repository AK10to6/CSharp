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

namespace Asynchronous_program_with_Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharacter()                                    //Method to Count character length in file
        {                                                       
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\New folder\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(3000);
            };
            return count;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread thread = new Thread(() => { count = CountCharacter();         //Creating new thread with lambda expression
                                                                                 //which executes count character 
               Action action = () => label1.Text = count.ToString() + " characters in file.";
               this.BeginInvoke(action);                                        //Executing action delegate asynchmorously
                                                                                //to change the label text
            });
            thread.Start();
            label1.Text = "Processing file. Please wait...";
        }
    }
}
