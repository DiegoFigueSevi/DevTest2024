using Back.Domain.Dto;
using Back.Domain.models;
using Back.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace Back.API;

[ApiController]
[Route("api/[controller]")]
public class PollController : ControllerBase
{
    
    private readonly IPollService _pollService;

    public PollController(IPollService pollService)
    {
        _pollService = pollService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var polls = await _pollService.GetAllPolls();
            return Ok(polls);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreatePollDto poll)
    {
        try
        {
            var newPool = await _pollService.CreatePoll(poll);
            return Ok(newPool);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
   
    
}