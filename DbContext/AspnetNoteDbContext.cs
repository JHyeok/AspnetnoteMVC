using AspnetNote.MVC6.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AspnetNote.MVC6.DataContext
{
    public class AspnetNoteDbContext : DbContext
    {
        // Table을 생성하는 코드
        public DbSet<User> Users { get; set; }

        public DbSet<Notes> Notes { get; set; }

        public DbSet<NoteComments> NoteComments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=JAEHYUK-PC\SQLEXPRESS;Database=AspnetNoteDb;User Id=sa; Password = 1q2w3e4r;");
        }
    }
}
