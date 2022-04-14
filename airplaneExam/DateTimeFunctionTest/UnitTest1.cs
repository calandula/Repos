using airplaneExam;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tests;
using Xunit;

namespace Tests1
{
    public class UnitTest1
    {
        [Fact]
        public async Task TestMethod1Async()
        {
            IActionResult actionResult = await Function1.Run(TestFactory.CreateHttpRequest("sample", "sample"));
            OkObjectResult okResult = actionResult as OkObjectResult;
            Assert.Equal(200, okResult.StatusCode);
        }
    }
}