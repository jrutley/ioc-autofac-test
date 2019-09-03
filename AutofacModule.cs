using Autofac;

namespace iocTest
{
    internal class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OtherService>().AsSelf();
        }
    }
}