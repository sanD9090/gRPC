using GrpcService1.Models;
using Microsoft.EntityFrameworkCore;

namespace GrpcService1.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<ToDoItem> ToDoItems { get; set; }  
};