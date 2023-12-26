using BlazorUploadSSR.Context;
using BlazorUploadSSR.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorUploadSSR.Repositories;

public class UploadRepository : IUploadRepository
{
    private readonly AppDbContext _context;
    public UploadRepository(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task UploadArquivoDb(ArquivoDatabase arquivo)
    {
        _context.ArquivosUploads.Add(arquivo);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<ArquivoDatabase>> GetArquivos()
    {
        return await _context.ArquivosUploads.ToListAsync();
    }

    public async Task DeletaArquivo(int id)
    {
        var arquivo = await GetArquivo(id);

        if (arquivo is not null)
        {
            _context.Remove(arquivo);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<ArquivoDatabase> GetArquivo(int id)
    {
        var arquivo = await _context.ArquivosUploads.FirstOrDefaultAsync(a => a.Id == id);
        return arquivo;
    }
}
