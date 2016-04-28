using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using ServiceLayer.Properties;

namespace ServiceLayer.Authentication.Communications
{
    [UsedImplicitly]
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            return Task.FromResult(0);
        }
    }
}