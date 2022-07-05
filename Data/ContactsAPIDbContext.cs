using Microsoft.EntityFrameworkCore;
using web_api_crud_dotnet_6.Models;

namespace web_api_crud_dotnet_6.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Contact> Contacts { get; set; }
    }
}
