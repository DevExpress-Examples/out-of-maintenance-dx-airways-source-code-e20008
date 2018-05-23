using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DXAirways.UnmannedConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DX Airways monitor console started.");
            Console.WriteLine("Monitoring airline operations.");

            AirlineMonitor monitor = new AirlineMonitor();

            TimerCallback aircraftCallback = new TimerCallback(monitor.MonitorAircraft);

            Timer aircraftTimer = new Timer(aircraftCallback, null, 1000, 5000);

            Console.WriteLine("Press [Enter] to exit monitor console.");
            Console.ReadLine();

            aircraftTimer.Dispose();
        }
       
    }

    internal class AirlineMonitor
    {
        internal void MonitorAircraft(object stateInfo)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
