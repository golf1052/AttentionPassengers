using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttentionPassengers;
using AttentionPassengers.Dto.Alerts;

namespace AttentionPassengersConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AttentionPassengers.AttentionPassengers attnpass = new AttentionPassengers.AttentionPassengers();
            Task.Run(async () => {
                AlertsObject alerts = await attnpass.Alerts(true, true);
                System.Diagnostics.Debug.WriteLine("");
            }).Wait();
        }
    }
}
