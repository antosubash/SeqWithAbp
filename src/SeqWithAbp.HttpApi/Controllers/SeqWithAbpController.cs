using SeqWithAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SeqWithAbp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SeqWithAbpController : AbpController
    {
        protected SeqWithAbpController()
        {
            LocalizationResource = typeof(SeqWithAbpResource);
        }
    }
}