using System;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

class Program
{
    private static readonly string endpointUri = "https://cosmos-dev-k4vzvmdkaowv4.documents.azure.com:443/";
    private static readonly string primaryKey = "2a6zMCYLNLeRZzURCXVdHVZCZoL4k5R4QU3Lz8qqQgTB6uAtR8pIImn5f9pQ6DhofSbiLVhgqYvoACDbY123g==;";
    private static readonly string databaseId = "SampleDB";
    private static readonly string containerId = "SampleContainer";

    static async Task Main(string[] args)
    {
        CosmosClient client = new CosmosClient(endpointUri, primaryKey);

        Database database = await client.CreateDatabaseIfNotExistsAsync(databaseId);
        Container container = await database.CreateContainerIfNotExistsAsync(containerId, "/partitionKey");

        Console.WriteLine($"Connected to container: {container.Id}");
    }
}
