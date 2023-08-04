using CrudEfCoreNet6.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudEfCoreNet6.Controllers;

[ApiController]
[Route("[controller]")]
public class TeamController: ControllerBase
{
    private static List<Team> teams = new List<Team>
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
  
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(teams);
    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        var team = teams.FirstOrDefault(x => x.Id == id);

        if (team == null)
            return BadRequest($"There is no team in this ID: {id}");

        return Ok(team);
    }

    [HttpPost]
    public IActionResult Post(Team team)
    {
        if (team == null)
            return BadRequest("You cannot specify team");
        
        teams.Add(team);

        return CreatedAtAction("Get", team.Id, team);
    }
}