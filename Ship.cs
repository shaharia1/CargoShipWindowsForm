using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShip
{
    class Ship
    {
        // values
        const int MotorCycle_Weight = 3;
        const int Car_Weight = 5;
        const int Truck_Weight = 11;
        const int TrainCar_Weight = 17;

        const int Max_Weight = 10;

        // property 
        public int Capacity { get; set; }

        public int MotorCycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCarCount { get; set; }

        Random random = new Random();



        //method
        public int getShipLoad()
        {
            //caculate the total weight of the cargo on the ship
            return MotorCycleCount * MotorCycle_Weight + CarCount * Car_Weight + TruckCount * Truck_Weight + TrainCarCount* TrainCar_Weight;
        }

        //constructor - called when a new instance is create

        public Ship()
        {
            MotorCycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCarCount = 0;

            // create a random size ship
            Capacity = random.Next(Max_Weight) * MotorCycle_Weight + random.Next(Max_Weight) * Car_Weight + random.Next(Max_Weight) * Truck_Weight + random.Next(Max_Weight) * TrainCar_Weight;
        }

        public int OverUnder()
        {
            //return a value how loaded a ship is 

            return Capacity - getShipLoad();
        }

        public override string ToString()
        {
            return "Capacity =" + Capacity + ",CurrentLoad =" + getShipLoad();
        }
    }
}
