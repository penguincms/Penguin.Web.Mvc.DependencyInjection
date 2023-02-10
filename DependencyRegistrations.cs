using Penguin.DependencyInjection.Abstractions.Enums;
using Penguin.DependencyInjection.Abstractions.Interfaces;
using Penguin.Web.Mvc.Abstractions.Interfaces;

namespace Penguin.Web.Mvc.DependencyInjection
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