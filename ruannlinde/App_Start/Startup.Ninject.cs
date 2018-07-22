namespace RL
{
    using System;

    using Ninject;
    using Ninject.Extensions.Logging.Log4net;
    using Ninject.Modules;

    using Owin;

    public partial class Startup
    {
        public void ConfigureNinject(IAppBuilder app)
        {
            //log4net.Config.XmlConfigurator.Configure();
//            app.Use()

        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel(new NinjectSettings
            {
                InjectNonPublic = true,
                InjectParentPrivateProperties = true,
                LoadExtensions = false
            }, new INinjectModule[] { new Log4NetModule() });

            try
            {
                RegisterServices(kernel);
                return kernel;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            //log4net
            //kernel.Bind<ILogger>().To<Log4NetLogger>().InSingletonScope();
            //kernel.Bind<ILog>().ToMethod(context => LogManager.GetLogger(context.Request.ParentContext?.Request.Service.FullName)).InSingletonScope();
        }
    }
}