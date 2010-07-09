using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackgroundWorkerComponent.Classes;
using System.Threading;

namespace BackgroundWorkerComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessData_Click(object sender, EventArgs e)
        {
            try
            {
                AddParams args = new AddParams(int.Parse(FirstNumber.Text), int.Parse(SecondNumber.Text));
                BackgroundProcessor.RunWorkerAsync(args);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessDataWithoutSecondThread_Click(object sender, EventArgs e)
        {
            AddParams args = new AddParams(int.Parse(FirstNumber.Text), int.Parse(SecondNumber.Text));
            int answer = args.Numb2 + args.Numb1;
            Thread.Sleep(5000);
            MessageBox.Show(answer.ToString(), "Your Result is");
        }

        private void BackgroundProcessor_DoWork(object sender, DoWorkEventArgs e)
        {
            AddParams args = (AddParams)e.Argument;
            Thread.Sleep(5000);
            e.Result = args.Numb1 + args.Numb2;
        }

        private void BackgroundProcessor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString(), "Your Result is");
        }
    }
}
