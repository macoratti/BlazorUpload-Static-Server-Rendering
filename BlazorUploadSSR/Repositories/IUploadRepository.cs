using BlazorUploadSSR.Entities;

namespace BlazorUploadSSR.Repositories;

public interface IUploadRepository
{
    Task UploadArquivoDb(ArquivoDatabase arquivo);
    Task<IEnumerable<ArquivoDatabase>> GetArquivos();
    Task<ArquivoDatabase> GetArquivo(int id);
    Task DeletaArquivo(int id);
}
