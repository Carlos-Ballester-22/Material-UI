using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.API.Models;
using backend.API.Service;

namespace backend.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        var users = await _userService.GetUsersAsync();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserById(int id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        if (user == null) return NotFound();
        return Ok(user);
    }

     [HttpPost]
    public async Task<ActionResult<User>> PostUser(User user)
    {
        var userCreate = await _userService.PostUserAsync(user);
        return Ok(userCreate);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> PutUser(int id, User user)
    {
        if (id != user.Id) return BadRequest();

        var userUpdate  = await _userService.PutUserAsync(user);
        if (userUpdate == null) return NotFound();

        return Ok(userUpdate);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteUser(int id)
    {
        var userDelete = await _userService.DeleteUserAsync(id);
        if (!userDelete) return NotFound();
        return NoContent();
    }
}