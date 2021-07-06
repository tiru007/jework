using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Service.Function
{
    public static class PostService
    {
        [FunctionName("PostService")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "postservice")] HttpRequest req,
             [CosmosDB(
                databaseName: "Customer",
                collectionName: "Customer",
                ConnectionStringSetting = "CosmosDbConnectionString")]
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a Customer.");

                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                ServiceDetails serviceDetails = JsonConvert.DeserializeObject<ServiceDetails>(requestBody);

           await documentsOut.AddAsync(serviceDetails);            

            return new OkResult();
        }
    }
}
