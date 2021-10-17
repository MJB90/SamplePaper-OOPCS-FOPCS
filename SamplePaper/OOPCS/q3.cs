using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class q3
    {
        public static void Main()
        {
            Time12 t1 = new Time12(1);
            Time12 t2 = new Time12(1, 2);
            Time12 t3 = new Time12(1, 2, 3);
            Time12 t4 = new Time12(1, 2, 3, false);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            int second, minute, hour, timezone;
            bool isAM = false;
            string inputStr;
            while (true)
            {
                Console.WriteLine("Enter input(second,minute,hour,isAM(0 = false,1=true),timezone) separated by comma(e to exit): ");
                inputStr = Console.ReadLine();
                if (inputStr[0] == 'e') break;

                string[] values = inputStr.Split(',');
                second = Convert.ToInt32(values[0]);
                minute = Convert.ToInt32(values[1]);
                hour = Convert.ToInt32(values[2]);
                if (values[3].ToCharArray()[0] == '1') isAM = true;
                timezone = Convert.ToInt32(values[4]);

                try
                {
                    Time12ZN timeObject = new Time12ZN(second, minute, hour, isAM, timezone);
                    timeObject.DisplayTime24();
                }
                catch(InvalidSecondException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(InvalidMinuteException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(InvalidTimeZoneException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
