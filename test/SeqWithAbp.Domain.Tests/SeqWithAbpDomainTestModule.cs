using SeqWithAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SeqWithAbp
{
    [DependsOn(
        typeof(SeqWithAbpEntityFrameworkCoreTestModule)
        )]
    public class SeqWithAbpDomainTestModule : AbpModule
    {

    }
}