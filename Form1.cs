using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShip
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }




        private void button_NewShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
        }

        private void updateUI()
        {
            progressBar1.Maximum = ship.Capacity;
            if (ship.getShipLoad() <= ship.Capacity)
                progressBar1.Value = ship.getShipLoad();

            label_shipLabel.Text = ship.ToString();


            //Value
            label_cycleCount.Text = ship.MotorCycleCount.ToString();
            label_carCount.Text = ship.CarCount.ToString();
            label_truckCount.Text = ship.TruckCount.ToString();
            label_trainCarCount.Text = ship.TrainCarCount.ToString();

            if (ship.OverUnder()==0)
            {
                progressBar1.ForeColor = Color.Green;
            }
            if (ship.OverUnder() > 0)
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            if (ship.OverUnder() < 0)
            {
                progressBar1.ForeColor = Color.Red;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void track_MotorCycle_Scroll(object sender, EventArgs e)
        {
            ship.MotorCycleCount = track_MotorCycle.Value;
            updateUI();
        }

        private void track_Car_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_Car.Value;
            updateUI();
        }

        private void track_Truck_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_Truck.Value;
            updateUI();
        }

        private void track_TrainCar_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_TrainCar.Value;
            updateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
        }
    }


}
