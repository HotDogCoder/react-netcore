using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using time_of_your_life.Application.Services;
using time_of_your_life.Application.ServicesInterfaces;
using time_of_your_life.Domain.Entities;

namespace time.Controllers;

[ApiController]
[Route("[controller]")]
public class ClockController : ControllerBase
{
    private static List<ClockProps> _presets = new List<ClockProps>(){ new() };

    private readonly ILogger<ClockController> _logger;

    private readonly PresetServiceInterface _presetService;

    public ClockController(PresetServiceInterface presetService, ILogger<ClockController> logger)
    {
        _presetService = presetService;
        _logger = logger;
    }

    [HttpGet, Route("presets")]
    public IEnumerable<Preset> GetPresets()
    {
        return _presetService.GetPresets();
    }

    [HttpPost("presets")]
    public IActionResult Store([FromBody]Preset preset)
    {
        _presetService.CreatePreset(preset);
        return CreatedAtAction(nameof(Store), new { id = preset.Id }, preset);
    }

    [HttpGet("server-time")]
    public IActionResult GetServerTime()
    {
        return Ok(DateTime.UtcNow);
    }
}
