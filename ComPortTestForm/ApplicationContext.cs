using System.IO;
using Microsoft.EntityFrameworkCore;

namespace ComPortTestForm
{
    public class ApplicationContext : DbContext
    {
        //представляет набор сущностей, хранящихся в базе данных
        public DbSet<GetValues> Users { get; set; }
        private string DBPath = "DataBaseSupply.db";

        public ApplicationContext()
        {
            if (!File.Exists(DBPath))
            {
                Database.EnsureCreated();
            }

        }

        //Переопределение у класса контекста данных метода
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source = {DBPath}"); //В этот метод передается объект DbContextOptionsBuilder,

        // который позволяет создать параметры подключения. Для их создания вызывается метод UseSqlServer, в который передается строка подключения.
    }
}