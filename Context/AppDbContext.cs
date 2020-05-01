using API_EXAMEN.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace API_EXAMEN.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Instrumento> Instrumento { get; set; }
    }
}
