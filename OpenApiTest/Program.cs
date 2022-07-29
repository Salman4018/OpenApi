using OpenApi.Client;

await Task.Delay(2000);
Console.WriteLine("Starting the Service !!");

var client = new HttpClient();

var testClient = new Client("https://localhost:7132/", client);

var testData = await testClient.GetAllEmployeesAsync();

foreach (var data in testData)
{
    Console.WriteLine($"Id {data.Id} : Firstname: {data.FirstName}");
}

while (true)
{
    try
    {
        Console.WriteLine("Enter Pet Id (int) ....... try 1,2 or 3 (May be some Ids are missing)");
        var id = Console.ReadLine();
        var petData = await testClient.GetPetByIdAsync(Convert.ToInt32(id));
        Console.WriteLine($"Id {petData.Id} : Name: {petData.Name}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unable to find mentioned Id");
       
    }
}

