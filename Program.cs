using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ParsetheParcel
{

    class Program
    {
        static void Main(string[] args)
        {

            //test code
            Parcel pps = new Parcel(300, 400, 200, 10);

            Console.WriteLine(pps.CalculateParcelCost());
            Console.ReadLine();

        }
    }




}
