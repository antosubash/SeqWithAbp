using Volo.Abp.Modularity;

namespace SeqWithAbp
{
    [DependsOn(
        typeof(SeqWithAbpApplicationModule),
        typeof(SeqWithAbpDomainTestModule)
        )]
    public class SeqWithAbpApplicationTestModule : AbpModule
    {

    }
}