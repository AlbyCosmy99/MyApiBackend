using Autofac;
using MyApiBackend.Services;

namespace MyApiBackend.AppConfig
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UsersService>().As<IUsersService>();
            // Add other registrations as needed
        }
    }

}
