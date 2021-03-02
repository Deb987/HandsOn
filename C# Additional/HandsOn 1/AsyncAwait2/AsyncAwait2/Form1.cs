using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AsyncAwait2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("D:/C# Additional/HandsOn 1/DataForAsyncAwait2.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            label1.Text = "Processing File. Please wait...";
            int count = await task;
            label1.Text = count.ToString() + " characters in the file.";
        }
    }
}
