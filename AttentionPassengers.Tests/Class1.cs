using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using AttentionPassengers;

namespace AttentionPassengers.Tests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Class1
    {
        AttentionPassengers attentionPassengers;

        public Class1()
        {
            attentionPassengers = new AttentionPassengers();
        }

        [Fact]
        public async void ServerTimeTest()
        {
            DateTime serverTime = await attentionPassengers.ServerTime();
            Assert.True(serverTime < DateTime.Now);
        }
    }
}
