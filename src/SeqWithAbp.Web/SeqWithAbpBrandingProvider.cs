using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SeqWithAbp.Web
{
    [Dependency(ReplaceServices = true)]
    public class SeqWithAbpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SeqWithAbp";
    }
}
