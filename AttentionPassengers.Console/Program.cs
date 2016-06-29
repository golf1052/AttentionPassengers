using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttentionPassengers;
using AttentionPassengers.Dto.Alerts;

namespace AttentionPassengers.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AttentionPassengers attnpass = new AttentionPassengers();
            Task.Run(async () => {
                AlertsObject alerts = await attnpass.Alerts(true, true);
                System.Diagnostics.Debug.WriteLine("");
            }).Wait();
        }
    }
}
