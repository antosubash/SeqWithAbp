using System.Threading.Tasks;

namespace SeqWithAbp.Data
{
    public interface ISeqWithAbpDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
