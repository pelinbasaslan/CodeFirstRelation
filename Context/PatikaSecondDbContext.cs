using CodeFirstRelation.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {

        }

        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}