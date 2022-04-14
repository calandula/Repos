using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace airplaneExam
{
    public static class Function1
    {
        [FunctionName("DateTime")]
        public async static
            Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {

            string responseMessage = DateTime.UtcNow.ToString("o");

            return new OkObjectResult(responseMessage);
        }
    }
}