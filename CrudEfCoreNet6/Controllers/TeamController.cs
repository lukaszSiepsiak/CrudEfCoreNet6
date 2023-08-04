using CrudEfCoreNet6.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudEfCoreNet6.Controllers;

[ApiController]
[Route("[controller]")]
public class TeamController: ControllerBase
{
    private List<Team> teams = new List<Team>
    {
        new Team()
        {
            Id = 1,
            Country = "Poland",
            Name = "Fiat",
            TeamPrinciple = "Fiat is the best!"
        },
        new Team()
        {
            Id = 2,
            Country = "England",
            Name = "Ferrari",
            TeamPrinciple = "Ferrari rules!"
        },
        new Team()
        {
            Id = 3,
            Country = "Italy",
            Name = "Alfa Romeo",
            TeamPrinciple = "Romeo best!"
        }
    };
  
    [HttpGet("{id:int}")]
    public IActionResult Get(string id)
    {
        return Ok(teams);
    }

    [HttpGet]
    public IActionResult Get(int Id)
    {
        var team = teams.FirstOrDefault(x => x.Id == Id);

        if (team == null)
            return BadRequest($"There is no team in this ID: {Id}");

        return Ok(team);
    }
}