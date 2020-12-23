using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCar
{
    public partial class Form1 : Form
    {
        CarSim MyCar = new CarSim(string.Empty, string.Empty,0,false,false,false,25);
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MyCar.ProductionYear = Int32.Parse(textBox3.Text);
            textBox4.Text = MyCar.GetAge().ToString();
            
        }

        public void Engine_Switch_Click(object sender, EventArgs e)
        {
            MyCar.Engine_Status = !MyCar.Engine_Status;
            Engine_Status.Checked = MyCar.Engine_Status;
        }


        private void Gas_Pedal_Click(object sender, EventArgs e)
        {
            if (MyCar.Engine_Status)
            { progressBar1.Value=MyCar.ChangeSpeed(); }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if (MyCar.Speed != 0)
            {
                Engine_Switch.Enabled = false;
            }
            else
            {
                Engine_Switch.Enabled = true;
            }
        }
    }
}
