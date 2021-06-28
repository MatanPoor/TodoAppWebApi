using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppWebApi.DataModel;

namespace TodoAppWebApi.DataAccess
{
    public class ToDoAppDataContext : DbContext
    {
        public DbSet<List> Lists { get; set; }
        public DbSet<Item> Items { get; set; }

        public ToDoAppDataContext()
        {

        }
        public ToDoAppDataContext(DbContextOptions<ToDoAppDataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-B1CO1K7;Initial Catalog=TodosApp;Integrated Security=True");
            }
        }
    }
}
