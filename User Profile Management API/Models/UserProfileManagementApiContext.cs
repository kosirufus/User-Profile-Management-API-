using Microsoft.EntityFrameworkCore;

namespace User_Profile_Management_API.Models
{
    public class UserProfileManagementApiContext : DbContext
    {
        /* DbContextOptions (a class provided by EF Core) holds configuration settings for  UserProfileManagementApiContext */
        public UserProfileManagementApiContext (DbContextOptions<UserProfileManagementApiContext> options) : base(options)
        {
        }        

        public DbSet<User> Users { get; set; } = null!;
        /* null! shows that Users won't actually be empty at runtime.
         * DbSet <T> represents a collection of entities of type T in the database
         where my T == User which is my entity model*/

    }
}
