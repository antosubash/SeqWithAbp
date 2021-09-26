using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SeqWithAbp.Data
{
    /* This is used if database provider does't define
     * ISeqWithAbpDbSchemaMigrator implementation.
     */
    public class NullSeqWithAbpDbSchemaMigrator : ISeqWithAbpDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}