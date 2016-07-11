using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //First method I tried

            //int days;
            //int hours;
            //int minutes;
            //int seconds;
            //int totalseconds;
            //string input;

            //Console.WriteLine("Please input a number of seconds");

            //input = Console.ReadLine();
            //totalseconds = int.Parse(input);
            //days = (totalseconds / 86400);
            //hours = ((totalseconds - (days * 86400)) / 3600);
            //minutes = ((totalseconds - (days * 86400) - (hours * 3600)) / 60);
            //seconds = ((totalseconds - (days * 86400) - (hours * 3600) - (minutes * 60)));

            //Console.WriteLine("Days: {0} Hours: {1} Minutes: {2} Seconds: {3}", days, hours, minutes, seconds);
            //Console.ReadLine();

            //Second method I tried which was much shorter and less math
            
            int totalseconds;
            string input;
            
            Console.WriteLine("Please input a number of seconds");

            input = Console.ReadLine();
            totalseconds = int.Parse(input);
            var ts = TimeSpan.FromSeconds(totalseconds);
            Console.WriteLine("Days: {0} Hours: {1} Minutes: {2} Seconds: {3}", ts.Days,ts.Hours,ts.Minutes,ts.Seconds);
            Console.ReadLine();
            
        }
    }
}
