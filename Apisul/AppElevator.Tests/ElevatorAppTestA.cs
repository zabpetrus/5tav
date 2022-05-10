using AppElevator.Application.AppService;
using AppElevator.Domain.Service;
using AppElevator.Infra.Data;
using Moq;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Xunit;

namespace AppElevator.Tests
{
    public class ElevatorAppTestA
    {
        [Fact]
        public void AccessTestIsNull()
        {
            ReadJsonData readJsonData = new ReadJsonData("C:/input.json");
            Assert.NotNull(readJsonData);
        }

        [Fact]
        public void AccessTestIsJArray()
        {
            ReadJsonData readJsonData = new ReadJsonData("C:/input.json");
            JArray getdata = readJsonData.GetData();

            Assert.NotNull(getdata);
        }


    }
}
