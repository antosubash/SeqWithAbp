using SeqWithAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SeqWithAbp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SeqWithAbpEntityFrameworkCoreModule),
        typeof(SeqWithAbpApplicationContractsModule)
        )]
    public class SeqWithAbpDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
