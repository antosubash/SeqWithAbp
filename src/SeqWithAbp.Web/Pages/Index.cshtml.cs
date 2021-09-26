using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace SeqWithAbp.Web.Pages
{
    public class IndexModel : SeqWithAbpPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}