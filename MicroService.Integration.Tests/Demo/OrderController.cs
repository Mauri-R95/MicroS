using FluentAssertions;
using MicroS;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroService.Integration.Tests
{
    [TestClass]
    public class OrderController
    {
        //para levantar un servidor de test
        private readonly TestServer _server;
        //para simmular una consulta HTTP
        private readonly HttpClient _client;

        public OrderController()
        {
            _server = new TestServer(WebHost.CreateDefaultBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }
        
        [TestMethod]
        public async Task Dado_Id_devolver_una_order()
        {
            //Arrange
            var response = await _client.GetAsync("/api/Order/1");
            //Fluent
            Assert.IsTrue((int)response.StatusCode == 200);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [TestMethod]
        public async Task devolver_todas_las_order()
        {
            //Arrange
            var response = await _client.GetAsync("/api/Order");
            //Fluent
            Assert.IsTrue((int)response.StatusCode == 200);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
