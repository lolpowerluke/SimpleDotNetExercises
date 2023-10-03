using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Oefening_op_Generieke_Collecties<T>
    {
        List<T> container;

        internal Oefening_op_Generieke_Collecties()
        {
            container = new List<T>();
        }
        public void Opzetten(T i)
        {
            container.Add(i);
        }
        public T Afhalen()
        {
            if (container.Count == 0)
                return (T) Convert.ChangeType(int.MinValue, typeof(T));
            T even = container[0];
            container.RemoveAt(0);
            return even;
        }
        public void Leegmaken()
        {
            container.Clear();
        }
        public override string ToString()
        {
            string s = "";
            foreach (T i in container)
            {
                s += i.ToString() + "\n";
            }
            return s;
        }
    }
}
