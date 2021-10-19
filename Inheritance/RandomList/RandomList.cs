using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class RandomList : List<string>
    {
        public string RandomString()
        {
            var index = GetRandomIndex(0, base.Count);
            var str = base[index];
            base.RemoveAt(index);

            return str;
        }

        private int GetRandomIndex(int startIndex, int count)
        {
            var rnd = new Random();
            return rnd.Next(startIndex, count); 
        }
    }
}
