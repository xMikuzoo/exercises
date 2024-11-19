using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_readable_duration_format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            formatDuration(0);
            formatDuration(1);
            formatDuration(62);
            formatDuration(120);
            formatDuration(3662);
            formatDuration(15731080);
            formatDuration(205851834);
            Console.ReadKey();
        }

        public static string formatDuration(int seconds)
        {
            int secondsInYear = 31536000;
            int secondsInDay = 86400;
            int secondsInHour = 3600;
            int secondsInMinute = 60;

            if (seconds == 0) Console.WriteLine("now\n-----------------");

            //int years = (seconds - (seconds % secondsInYear)) / secondsInYear;
            //int days = ((seconds - (years * secondsInYear)) - ((seconds) % secondsInDay)) / secondsInDay;
            //int hours = ((seconds - (years * secondsInYear) - (days * secondsInDay)) - ((seconds) % secondsInHour)) / secondsInHour;
            //int minutes = ((seconds - (years * secondsInYear) - (days * secondsInDay) - (hours * secondsInHour)) - ((seconds) % secondsInMinute)) / secondsInMinute;
            //seconds = (seconds - (years * secondsInYear) - (days * secondsInDay) - (hours * secondsInHour) - (minutes * secondsInMinute));
            //==
            int years = seconds / secondsInYear;
            seconds %= secondsInYear;

            int days = seconds / secondsInDay;
            seconds %= secondsInDay;

            int hours = seconds / secondsInHour;
            seconds %= secondsInHour;

            int minutes = seconds / secondsInMinute;
            seconds %= secondsInMinute;

            var result = new StringBuilder();

            var timeDictionary = new Dictionary<string, int>
            {
                { "Year", years },
                { "Day", days },
                { "Hour", hours },
                { "Minute", minutes },
                { "Second", seconds }
            };

            foreach (KeyValuePair<string, int> entry in timeDictionary)
            {
                if (entry.Value > 0)
                {
                    if (entry.Value != 1)
                        result.Append($"{entry.Value} {entry.Key}s, ");
                    else
                        result.Append($"{entry.Value} {entry.Key}, ");
                }
            }

            // Remove the trailing comma and space
            if (result.Length > 0)
            {
                result.Length -= 2;
            }
            Console.WriteLine(result);
            Console.WriteLine(result.ToString());




            return "";
        }
    }
}
