
namespace CargoShip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_shipLabel = new System.Windows.Forms.Label();
            this.button_NewShip = new System.Windows.Forms.Button();
            this.track_MotorCycle = new System.Windows.Forms.TrackBar();
            this.track_Car = new System.Windows.Forms.TrackBar();
            this.track_Truck = new System.Windows.Forms.TrackBar();
            this.track_TrainCar = new System.Windows.Forms.TrackBar();
            this.label_cycleCount = new System.Windows.Forms.Label();
            this.label_carCount = new System.Windows.Forms.Label();
            this.label_truckCount = new System.Windows.Forms.Label();
            this.label_trainCarCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_MotorCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Truck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_TrainCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CargoShip.Properties.Resources.cargoship;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(142, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(571, 105);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 45;
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.Location = new System.Drawing.Point(139, 178);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(35, 13);
            this.label_shipLabel.TabIndex = 6;
            this.label_shipLabel.Text = "label1";
            // 
            // button_NewShip
            // 
            this.button_NewShip.Location = new System.Drawing.Point(72, 442);
            this.button_NewShip.Name = "button_NewShip";
            this.button_NewShip.Size = new System.Drawing.Size(75, 23);
            this.button_NewShip.TabIndex = 7;
            this.button_NewShip.Text = "New Ship";
            this.button_NewShip.UseVisualStyleBackColor = true;
            this.button_NewShip.Click += new System.EventHandler(this.button_NewShip_Click);
            // 
            // track_MotorCycle
            // 
            this.track_MotorCycle.Location = new System.Drawing.Point(72, 291);
            this.track_MotorCycle.Name = "track_MotorCycle";
            this.track_MotorCycle.Size = new System.Drawing.Size(239, 45);
            this.track_MotorCycle.TabIndex = 8;
            this.track_MotorCycle.Scroll += new System.EventHandler(this.track_MotorCycle_Scroll);
            // 
            // track_Car
            // 
            this.track_Car.Location = new System.Drawing.Point(364, 291);
            this.track_Car.Name = "track_Car";
            this.track_Car.Size = new System.Drawing.Size(239, 45);
            this.track_Car.TabIndex = 8;
            this.track_Car.Scroll += new System.EventHandler(this.track_Car_Scroll);
            // 
            // track_Truck
            // 
            this.track_Truck.Location = new System.Drawing.Point(72, 360);
            this.track_Truck.Name = "track_Truck";
            this.track_Truck.Size = new System.Drawing.Size(239, 45);
            this.track_Truck.TabIndex = 8;
            this.track_Truck.Scroll += new System.EventHandler(this.track_Truck_Scroll);
            // 
            // track_TrainCar
            // 
            this.track_TrainCar.Location = new System.Drawing.Point(364, 360);
            this.track_TrainCar.Name = "track_TrainCar";
            this.track_TrainCar.Size = new System.Drawing.Size(239, 45);
            this.track_TrainCar.TabIndex = 8;
            this.track_TrainCar.Scroll += new System.EventHandler(this.track_TrainCar_Scroll);
            // 
            // label_cycleCount
            // 
            this.label_cycleCount.AutoSize = true;
            this.label_cycleCount.Location = new System.Drawing.Point(98, 272);
            this.label_cycleCount.Name = "label_cycleCount";
            this.label_cycleCount.Size = new System.Drawing.Size(35, 13);
            this.label_cycleCount.TabIndex = 9;
            this.label_cycleCount.Text = "label1";
            // 
            // label_carCount
            // 
            this.label_carCount.AutoSize = true;
            this.label_carCount.Location = new System.Drawing.Point(390, 272);
            this.label_carCount.Name = "label_carCount";
            this.label_carCount.Size = new System.Drawing.Size(35, 13);
            this.label_carCount.TabIndex = 10;
            this.label_carCount.Text = "label2";
            // 
            // label_truckCount
            // 
            this.label_truckCount.AutoSize = true;
            this.label_truckCount.Location = new System.Drawing.Point(101, 343);
            this.label_truckCount.Name = "label_truckCount";
            this.label_truckCount.Size = new System.Drawing.Size(35, 13);
            this.label_truckCount.TabIndex = 11;
            this.label_truckCount.Text = "label3";
            // 
            // label_trainCarCount
            // 
            this.label_trainCarCount.AutoSize = true;
            this.label_trainCarCount.Location = new System.Drawing.Point(393, 343);
            this.label_trainCarCount.Name = "label_trainCarCount";
            this.label_trainCarCount.Size = new System.Drawing.Size(35, 13);
            this.label_trainCarCount.TabIndex = 12;
            this.label_trainCarCount.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Motor Cycle (3 Units)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Car (5 Units)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Truck (11 Units)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Train Cars (17 Units)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 479);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_trainCarCount);
            this.Controls.Add(this.label_truckCount);
            this.Controls.Add(this.label_carCount);
            this.Controls.Add(this.label_cycleCount);
            this.Controls.Add(this.track_TrainCar);
            this.Controls.Add(this.track_Truck);
            this.Controls.Add(this.track_Car);
            this.Controls.Add(this.track_MotorCycle);
            this.Controls.Add(this.button_NewShip);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Load The Ship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_MotorCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Truck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_TrainCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_shipLabel;
        private System.Windows.Forms.Button button_NewShip;
        private System.Windows.Forms.TrackBar track_MotorCycle;
        private System.Windows.Forms.TrackBar track_Car;
        private System.Windows.Forms.TrackBar track_Truck;
        private System.Windows.Forms.TrackBar track_TrainCar;
        private System.Windows.Forms.Label label_cycleCount;
        private System.Windows.Forms.Label label_carCount;
        private System.Windows.Forms.Label label_truckCount;
        private System.Windows.Forms.Label label_trainCarCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

