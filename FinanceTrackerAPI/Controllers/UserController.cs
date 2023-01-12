using FinanceTracker.Models;
using FinanceTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTrackerAPI.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("{id}")]
        public User GetById(int id)
        {
            return _userService.GetById(id);
        }
    }
}