using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _049AsynchronousProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadHTMLAsync("http://www.google.com");
        }




        public async Task DownloadHTMLAsync(string url){
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url); //we put await before, and find the async method

            using (var streamWriter = new StreamWriter(@"result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }





        
    }
}
/*
 * Synchronous Program Execution
 * Program is executed line by line, one at a time.
 * When a function is called, program execution has to wait until functions returns
 * Accessing database, opening a website
 * 
 * 
 * 
 * Asynchronous Program Execution
 * Program is executed without waiting.
 * Improves responsiveness of application
 * 
 * 
 * Async / Await
 * 
 * 
 
 */