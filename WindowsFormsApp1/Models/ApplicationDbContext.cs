using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
  internal class ApplicationDbContext:DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var sqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
       @"McProtocol_EntityFrameworkCoreNet2_Database_Update\\database.db");

      if (!Directory.Exists(sqlitePath)) Directory.CreateDirectory(sqlitePath); optionsBuilder.UseSqlite("Data Source=" + sqlitePath + "\\database.db");

    }
    public DbSet<Student> Students { get; set; }
  }
}
