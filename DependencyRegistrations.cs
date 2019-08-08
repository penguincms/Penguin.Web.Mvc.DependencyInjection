using Penguin.DependencyInjection.Abstractions;
using Penguin.DependencyInjection;
using Penguin.DependencyInjection.ServiceProviders;
using Penguin.Web.Mvc.Abstractions;
using Penguin.Web.Mvc;

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
        public void RegisterDependencies()
        {
            Engine.Register<IViewRenderService, ViewRenderService>(typeof(ScopedServiceProvider));

        }
    }
}
