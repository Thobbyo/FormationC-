using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectAvancer
{
    [Serializable]
    public class MyPair<T, U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public MyPair(T premier, U deuxieme){
            this.First = premier;
            this.Second = deuxieme;
        }

        public override string ToString()
        {
            return $"Value 1 : {this.First} – Value 2 : {this.Second}";
        }
    }
}
