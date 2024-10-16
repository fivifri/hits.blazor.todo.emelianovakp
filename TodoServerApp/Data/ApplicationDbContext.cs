using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<TaskItem>().HasData([
				new() {Id = 1, Title="Pet the cat", Description="100 times", CreatedDate=DateTime.Now, FinishDate=DateTime.Today.AddDays(1)},
				new() {Id = 2, Title="Finish this course", Description="Or not?", CreatedDate=DateTime.Now, FinishDate= new DateTime(2024, 12, 31)},
				new() {Id = 3, Title="Homework", Description=".-.", CreatedDate=DateTime.Now, FinishDate=new DateTime(2024, 10, 26)},
			]);
		}
	}
}