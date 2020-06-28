using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class Vehicle
    {
        private int CarID;
        private string Brand;
        private string Model;
        private string Engine;
        private string Body;
        private DateTime ManuDate;
        private int Doors;
        private string Fuel;
        private string Drive;
        private string Gearbox;

        public int CarID1 { get => CarID; set => CarID = value; }
        public string Brand1 { get => Brand; set => Brand = value; }
        public string Model1 { get => Model; set => Model = value; }
        public string Engine1 { get => Engine; set => Engine = value; }
        public string Body1 { get => Body; set => Body = value; }
        public DateTime ManuDate1 { get => ManuDate; set => ManuDate = value; }
        public int Doors1 { get => Doors; set => Doors = value; }
        public string Fuel1 { get => Fuel; set => Fuel = value; }
        public string Drive1 { get => Drive; set => Drive = value; }
        public string Gearbox1 { get => Gearbox; set => Gearbox = value; }

        public Vehicle(int carID, string brand, string model, string engine, string body, DateTime manuDate, int doors, string fuel, string drive, string gearbox)
        {
            CarID = carID;
            Brand = brand;
            Model1 = model;
            Engine = engine;
            Body = body;
            ManuDate = manuDate;
            Doors = doors;
            Fuel = fuel;
            Drive = drive;
            Gearbox = gearbox;
        }
        public Vehicle( string brand, string model, string engine, string body, DateTime manuDate, int doors, string fuel, string drive, string gearbox)
        {
            Brand = brand;
            Model1 = model;
            Engine = engine;
            Body = body;
            ManuDate = manuDate;
            Doors = doors;
            Fuel = fuel;
            Drive = drive;
            Gearbox = gearbox;
        }
        public Vehicle()
        {
            CarID = 0;
            Brand = "";
            Model1 = "";
            Engine = "";
            Body = "";
            ManuDate = DateTime.Now;
            Doors = 0;
            Fuel = "";
            Drive = "";
            Gearbox = "";
        }

        public string NoIDToString()
        {
            return $"{Brand1}, {Model1}, {Engine1}, {Body1}, {ManuDate1.ToShortDateString()}, {Doors1}, {Fuel1}, {Drive1}, {Gearbox1}";

        }

        public override string ToString()
        {
            return $"{CarID1}, {Brand1}, {Model1}, {Engine1}, {Body1}, {ManuDate1.ToShortDateString()}, {Doors1}, {Fuel1}, {Drive1}, {Gearbox1}";
        }
    }
}
