// See https://aka.ms/new-console-template for more information

using SwaggerApiClient.Client;


Console.WriteLine("Starting the Service !!");

var client = new HttpClient();

var testClient = new Client(client);

var petData = await testClient.GetPetByIdAsync(1);

Console.WriteLine($"Id {petData.Id} : name: {petData.Name} , Tags: {string.Join(",", petData.Tags.Select(n=> n.Id))}");

Console.WriteLine("Stopping the Service !!");