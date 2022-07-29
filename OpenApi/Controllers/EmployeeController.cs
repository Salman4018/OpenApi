using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenApi;
using SwaggerApiClient.Client;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IClient _client;
    public EmployeeController(IClient client)
    {
        _client = client;
    }
    // GET: api/Employee
    [HttpGet("GetAllEmployees")]
    public async Task<IEnumerable<Employee>> Get()
    {
        return GetEmployees();
    }

    // GET: api/Employee
    [HttpGet("GetPetById")]
    public async Task<Pet> GetPetById(int id)
    {
        return await _client.GetPetByIdAsync(id);
    }

    
    private List<Employee> GetEmployees()
    {
        return new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName= "John",
                LastName = "Smith",
                EmailId ="John.Smith@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                FirstName= "Jane",
                LastName = "Doe",
                EmailId ="Jane.Doe@gmail.com"
            },
            new Employee()
            {
                Id = 3,
                FirstName= "JJ",
                LastName = "Sal",
                EmailId ="JJ.Sal@gmail.com"
            },
            new Employee()
            {
                Id = 4,
                FirstName= "Tom",
                LastName = "Doe",
                EmailId ="Tom.Doe@gmail.com"
            }
        };
    }

}