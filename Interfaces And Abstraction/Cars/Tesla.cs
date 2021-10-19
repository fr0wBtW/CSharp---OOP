using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public int Battery { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        string ICar.Start { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICar.Stop { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Engline stop";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {nameof(Tesla)} {this.Model} with {this.Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            var result = sb.ToString().TrimEnd();

            return result;
        }
    }
}
