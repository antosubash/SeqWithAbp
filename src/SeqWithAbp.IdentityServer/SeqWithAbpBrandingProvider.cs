using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SeqWithAbp
{
    [Dependency(ReplaceServices = true)]
    public class SeqWithAbpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SeqWithAbp";
    }
}
