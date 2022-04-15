using Gas_Station.EF.Context;
using Gas_Station.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController
    {
        private GasStationContext _context;

        public UsersController(GasStationContext context)
        {
            _context = context;
        }
        
        [HttpGet("{username}/{password}")]
        public async Task<UserViewModel> Get(string username, string password)
        {
            UserViewModel user = new();
            var found = await _context.Users.FirstOrDefaultAsync(user => user.Username == username && user.Password == password);
            if (found == null)
                return user;
            user.Username = found.Username;
            user.Role = found.Role;
            user.IsAuth = true;
            return user;
        }
    }
}
