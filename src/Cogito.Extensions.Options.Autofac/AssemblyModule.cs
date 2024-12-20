using Autofac;

using Cogito.Autofac;
using Cogito.Autofac.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;

namespace Cogito.Extensions.Options.Autofac
{

    public class AssemblyModule : ModuleBase
    {

        protected override void Register(ContainerBuilder builder)
        {
            builder.Populate(s => s.AddOptions());
            builder.RegisterFromAttributes(typeof(AssemblyModule).Assembly);
        }

    }

}
