using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ojihugyftdx
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var request = new HttpRequestMessage(new HttpMethod("GetAll"), new Uri("/api/Pizzas/"));
            Console.WriteLine(request);
            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(request);
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
