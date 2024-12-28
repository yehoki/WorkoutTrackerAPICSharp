using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkoutTrackerAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserController : ControllerBase
{
    string? _connectionString;
    public UserController(IConfiguration config)
    {
        _connectionString = config.GetConnectionString("DefaultConnection");
    }


    #region Create
    [HttpPost]
    public async Task<IActionResult> CreateUser()
    {
        return Ok();
    }
    #endregion

    #region Read
    [HttpGet]
    public IActionResult Test()
    {
        using(SqlConnection connection = new SqlConnection(
           _connectionString))
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
            command.Connection.Open();
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {

                    Console.WriteLine(reader["Id"]);
                    Console.WriteLine(reader["Exercise"]);
                }
            }
            command.Connection.Close();
        }
        return Ok();
    }

    // GET: /<controller>/
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
    #endregion

  

    #region Update

    #endregion

    #region Delete

    #endregion
}

