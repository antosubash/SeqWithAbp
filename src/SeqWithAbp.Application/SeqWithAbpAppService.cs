using System;
using System.Collections.Generic;
using System.Text;
using SeqWithAbp.Localization;
using Volo.Abp.Application.Services;

namespace SeqWithAbp
{
    /* Inherit your application services from this class.
     */
    public abstract class SeqWithAbpAppService : ApplicationService
    {
        protected SeqWithAbpAppService()
        {
            LocalizationResource = typeof(SeqWithAbpResource);
        }
    }
}
