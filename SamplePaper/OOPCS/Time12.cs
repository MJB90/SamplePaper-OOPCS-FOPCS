using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class Time12
    {
        public int second { get; set; }
        public int minute { get; set; }
        public int hour { get; set; }
        public bool isAM { get; set; }

        public Time12(int second)
        {
            this.second = second;
            isAM = true;
            checkInput();
        }
        public Time12(int second, int minute)
        {
            this.second = second;
            this.minute = minute;
            isAM = true;
            checkInput();
        }
        public Time12(int second, int minute, int hour)
        {
            this.second = second;
            this.minute = minute;
            this.hour = hour;
            isAM = true;
            checkInput();
        }
        public Time12(int second, int minute, int hour, bool isAM)
        {
            this.second = second;
            this.minute = minute;
            this.hour = hour;
            this.isAM = isAM;
            checkInput();
        }
        public override string ToString()
        {
            string toReturn = $"{hour} hour(s), {minute} minute(s), {second} second(s), ";
            return isAM ? toReturn + "AM" : toReturn + "PM";
        }

        public void checkInput()
        {
            if (second < 0 || second > 59) throw new InvalidSecondException("The second is invalid.");
            if (minute < 0 || minute > 59) throw new InvalidMinuteException("The minute is invalid.");
        }

        public virtual void DisplayTime24()
        {
            int hour24;
            if (isAM)
            {
                if (hour == 12)
                    hour24 = 0;
                else
                    hour24 = hour;
            }
            else
            {
                if (hour == 12)
                    hour24 = hour;
                else
                    hour24 = hour + 12;
            }

            string hourStr = (hour24 < 10) ? "0" + hour24 : "" + hour24;
            string minuteStr = (minute < 10) ? "0" + minute : "" + minute;
            string secondStr = (second < 10) ? "0" + second : "" + second;
            Console.WriteLine("{0}:{1}:{2}", hourStr, minuteStr, secondStr);

        }
    }
    }
