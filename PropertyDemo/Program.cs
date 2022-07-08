using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    internal class Program
    {
        double _radius=2.0;

        //get access
        public void setRadius(double r)
        {
            _radius = r;
        }

        //set access
        public double getRadius()
        {
            return _radius;  
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value > _radius)
                {
                    _radius = value;
                }
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.setRadius(21.2);
            double d = p.getRadius();
            Console.WriteLine("Radius = " + d);

            double d1 = p.Radius;
            Console.WriteLine(d1);
            Console.ReadLine(); 
        }
    }
}
