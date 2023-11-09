using Microsoft.AspNetCore.Mvc;
using myfirstapi.Models;
using myfirstapi.Repositories;

namespace myfirstapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;

    public UserController(IUserRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<UserModel> result = _repository.Get();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        UserModel? result = _repository.Get(id);
        return (result == null) ? NotFound() : Ok(result);
    }

    [HttpPut]
    public IActionResult Add([FromBody] UserModel user)
    {
        _repository.Add(user);
        return Ok();
    }

    [HttpPatch("{id}")]
    public IActionResult Update([FromBody] UserModel user, int id)
    {
        _repository.Update(id, user);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _repository.Delete(id);
        return Ok();
    }
}
