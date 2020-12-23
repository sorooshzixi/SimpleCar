using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpleCar
{ 
    public class Car
    {
        int age;
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.ProductionYear = year;

        }
        public string Make
        { get; set; }
        public string Model
        { get; set; }
        public int ProductionYear
        { get; set; }
        public int GetAge()
        {
            age = System.DateTime.Today.Year - ProductionYear;
            return (age);
        }

    }
}

