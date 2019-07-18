using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CosmosFunction
{
    public static class Function1
    {
        [FunctionName("CosmosAuditFunction")]
        public static async System.Threading.Tasks.Task RunAsync([CosmosDBTrigger(
            databaseName: "coffeeDatabase",
            collectionName: "coffeeCollection",
            ConnectionStringSetting = "CosmosConnection",
            LeaseCollectionName = "leases",
            CreateLeaseCollectionIfNotExists = true)]IReadOnlyList<Document> input, ILogger log)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("<your event grid url>")
            };
            client.DefaultRequestHeaders.Add("aeg-sas-key", "<your event grid sas key>");

            foreach (var document in input)
            {
                var order = JsonConvert.DeserializeObject<OrderModel>(document.ToString());
                foreach (var item in order.OrderItems)
                {
                    var aegEvent = new
                    {
                        Id = 1,
                        Subject = item.ItemName,
                        EventType = item.ItemType.ToString(),
                        EventTime = DateTime.UtcNow,
                        Data = "new order item received"
                    };
                    var response = await client.PostAsJsonAsync("", new[] { aegEvent });
                }
            }
            
        }
    }
}
