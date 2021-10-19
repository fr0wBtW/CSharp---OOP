using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
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
            return "Engine stop";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {nameof(Seat)} {this.Model}");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            var result = sb.ToString().TrimEnd();

            return result;
        }
    }
}
