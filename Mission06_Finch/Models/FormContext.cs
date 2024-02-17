using Microsoft.EntityFrameworkCore;

namespace Mission06_Finch.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base (options) //Constructor
        {
        }

        public DbSet<Form> Forms { get; set; }
    }
}
