using SeqWithAbp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SeqWithAbp.Web.Pages
{
    public abstract class SeqWithAbpPageModel : AbpPageModel
    {
        protected SeqWithAbpPageModel()
        {
            LocalizationResourceType = typeof(SeqWithAbpResource);
        }
    }
}