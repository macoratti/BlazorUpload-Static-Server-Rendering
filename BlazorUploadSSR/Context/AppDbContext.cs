using BlazorUploadSSR.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorUploadSSR.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    { }
    public DbSet<ArquivoDatabase> ArquivosUploads { get; set; }
}
