using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovelo
{
    class Program
    {
        [STAThread]
       static void Main()
        {

            Bike first_bike=new Bike("city","RED",26);
            //Console.WriteLine("first_bike :");
            //Console.WriteLine(first_bike.Type);
            //Console.WriteLine(first_bike.Color);
            //Console.WriteLine(first_bike.Size);
            first_bike.Color="GREEN";
            first_bike.Type="explorer";
            first_bike.Size=28;
            //Console.WriteLine("first_bike changed :");
            //Console.WriteLine(first_bike.Type);
            //Console.WriteLine(first_bike.Color);
            //Console.WriteLine(first_bike.Size);

        }
    }
}
