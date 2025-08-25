using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment
{
    [Table("Books")]
    internal class Book
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string title { get; set; }

        [Required]
        [MaxLength(20)]
        public string author { get; set; }

        [Required]
        public int price { get; set; }
    }


    class BookContext : DbContext
    {
        //  Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FNFTraining;Integrated Security=True;Encrypt=False;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data -Tables products


        public DbSet<Book> myBooks { get; set; }

        IConfigurationRoot? Configuration {  get; set; }

        private void ConfigureServices()
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .Build();

            if(conf == null)
            {
                throw new Exception("Config Failed");
            }
            Configuration = conf;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            ConfigureServices();
            var connectionstring = Configuration["ConnectionStrings"];
            optionsBuilder.UseSqlServer(connectionstring);
        }
            

    }
 }