using Penguin.DependencyInjection;
using Penguin.DependencyInjection.ServiceProviders;
using Penguin.Web.Mvc.Abstractions;
using Penguin.Web.Mvc;
using Penguin.DependencyInjection.Abstractions.Interfaces;
using Penguin.DependencyInjection.Abstractions.Enums;
using Penguin.Web.Mvc.Abstractions.Interfaces;

namespace Penguin.Cms.Web.Mail.EmailRenderer.DependencyInjection
{
    /// <summary>
    /// Registers dependencies for this assembly
    /// </summary>
    public class DependencyRegistrations : IRegisterDependencies
    {
        /// <summary>
        /// Registers dependencies for this assembly
        /// </summary>
        public void RegisterDependencies(IServiceRegister serviceRegister)
        {
            if (serviceRegister is null)
            {
                throw new System.ArgumentNullException(nameof(serviceRegister));
            }

            serviceRegister.Register<IViewRenderService, ViewRenderService>(ServiceLifetime.Scoped);
        }
    }
}