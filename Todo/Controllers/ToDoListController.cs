using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoListController : ControllerBase
{
    private readonly ILogger<ToDoListController> _logger;
    public ToDoListController(ILogger<ToDoListController> logger)
    {
        _logger = logger;
    }
}