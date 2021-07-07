using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectBL;
using ProjectDL;
using ProjectDL.Entities;

namespace ProjectUI{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json")
            .Build();

            string connectionString = configuration.GetConnectionString("Reference2DB");

            DbContextOptions<DemoDbContext> options = new DbContextOptionsBuilder<DemoDbContext>()
            .UseSqlServer(connectionString)
            .Options;
            
            switch(p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustMenu:
                    return new CustMenu();
                case MenuType.AddCustomerMenu:
                    return new AddCustomerMenu(new ProjectBL(new Repository(new DemoDbContext(options))));
                default:
                    return null;
            }
        }
    }
}