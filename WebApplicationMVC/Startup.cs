using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.DataProtection;
using ObjectFactory;
using ObjectFactory.MVC;
using Owin;
using ServiceLayer.Authentication.Role.Manager;
using ServiceLayer.Authentication.User.Manager;
using StructureMap.Web;

[assembly: OwinStartup(typeof (WebApplicationMVC.Startup))]

namespace WebApplicationMVC
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }


        private static void ConfigureAuth(IAppBuilder app)
        {
            MvcAppObjectFactory.Container.Configure(config =>
                config.For<IDataProtectionProvider>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use(() => app.GetDataProtectionProvider()));

            //Seed Data Base Add admin If not exists
            MvcAppObjectFactory.Container.GetInstance<IApplicationUserManager>().SeedDatabase();
            MvcAppObjectFactory.Container.GetInstance<IApplicationRoleManager>().SeedDataBase();


            // Configure the db context, user manager and role manager to use a single instance per request
            app.CreatePerOwinContext(() => MvcAppObjectFactory.Container.GetInstance<IApplicationUserManager>());

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            // Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Authentication/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    // Enables the application to validate the security stamp when the user logs in.
                    // This is a security feature which is used when you change a password or add an external login to your account.
                    OnValidateIdentity =
                        MvcAppObjectFactory.Container.GetInstance<IApplicationUserManager>().OnValidateIdentity()
                }
            });

            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Enables the application to temporarily store user information when they are verifying the second factor in the two-factor authentication process.
            app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5));

            // Enables the application to remember the second login verification factor such as phone or email.
            // Once you check this option, your second step of verification during the login process will be remembered on the device where you logged in from.
            // This is similar to the RememberMe option when you log in.
            app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);
        }
    }
}