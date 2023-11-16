using DataAccessLayer.Data;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace UniversityTask.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool ValidateUser(string email, string password)
        {
            User user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user != null;
        }

        public async Task<bool> CreateUserAsync(string email, string password, int universityId)
        {
            User existingUser =  await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (existingUser != null)
            {
                // User with the same email already exists
                return false;
            }

            User newUser = new User
            {
                Email = email,
                Password = password,
                UniversityId = universityId
            };

             await _context.Users.AddAsync(newUser);
             await _context.SaveChangesAsync();

            return true;
        }
    }
}