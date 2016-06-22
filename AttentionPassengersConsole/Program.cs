using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttentionPassengers;

namespace AttentionPassengersConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AttentionPassengers.AttentionPassengers attnpass = new AttentionPassengers.AttentionPassengers();
            Task.Run(async () => {
                await attnpass.Routes();
            }).Wait();
        }
    }
}
