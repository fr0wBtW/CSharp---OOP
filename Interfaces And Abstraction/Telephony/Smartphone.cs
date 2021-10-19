using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public Smartphone(List<string> numbers, List<string> websites)
        {
            this.Numbers = numbers;
            this.Websites = websites;
        }

        public List<string> Numbers { get; set; }
        public List<string> Websites { get; set; }

        public string Browse()
        {
            var sb = new StringBuilder();

            foreach (var site in Websites)
            {
                if(site.Any(e => char.IsDigit(e)))
                {
                    sb.AppendLine("Invalid URL!");
                }
                else
                {
                    sb.AppendLine($"Browsing: {site}");
                }
            }
            var result = sb.ToString().TrimEnd();

            return result;
        }

        public string Call()
        {
            var sb = new StringBuilder();

            foreach (var number in Numbers)
            {
                if(number.Any(e => !char.IsDigit(e)))
                {
                    sb.AppendLine("Ivalid number!");
                }
                else
                {
                    sb.AppendLine($"Calling... {number}");
                }
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }
    }
}
