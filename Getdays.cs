using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace MCT.Functions
{
    public static class Getdays
    {
        [FunctionName("Getdays")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "days")] HttpRequest req,
            ILogger log)
        {
            string connectionstring = Environment.GetEnvironmentVariable("SQLConnectionString");

            SqlConnection sqlConnection = new SqlConnection(Environment.GetEnvironmentVariable(connectionstring));

            return new OkObjectResult("");
        }
    }
}
