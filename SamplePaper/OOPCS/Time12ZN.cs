using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class Time12ZN : Time12
    {
        public int timezone { get; set; }
        public Time12ZN() : base(0, 0, 0)
        {
            timezone = 0;
        }
        public Time12ZN(int second,int minute,int hour,bool isAM,int timezone):base(second,minute,hour,isAM)
        {
            if (timezone < -12 || timezone > 14) throw new InvalidTimeZoneException("The timezone is invalid");
            this.timezone = timezone;
        }
        public override void DisplayTime24()
        {
            base.DisplayTime24();
            Console.WriteLine("Timezone :" + timezone);
        }
    }
}
