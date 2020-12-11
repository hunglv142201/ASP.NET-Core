using System;
using System.Linq;
using ShopVinhUniversity.Entities;

namespace ShopVinhUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            User admin = new User();
            admin.ID = Guid.NewGuid().ToString();
            admin.FullName = "Le Viet Hung";
            admin.Username = "admin";
            admin.Password = "abc123";

            context.Users.Add(admin);
            context.SaveChanges();
        }
    }
}
