using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using User_Profile_Management_API.Models;

namespace User_Profile_Management_API.Data
{
    public class UserProfileManagementApiContext : IdentityDbContext <User>
    {
        /* DbContextOptions (a class provided by EF Core) holds configuration settings for  UserProfileManagementApiContext */
        public UserProfileManagementApiContext (DbContextOptions<UserProfileManagementApiContext> options) : base(options)
        {
        }        

        //public DbSet<User> Users { get; set; } = null!;
        /* null! shows that Users won't actually be empty at runtime.
         * DbSet <T> represents a collection of entities of type T in the database
         where my T == User which is my entity model*/

    }
}
