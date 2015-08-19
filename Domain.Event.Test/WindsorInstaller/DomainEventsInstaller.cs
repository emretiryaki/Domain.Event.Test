using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Domain.Event.Test.EventAdd;
using Domain.Event.Test.Events;

namespace Domain.Event.Test.WindsorInstaller
{
    public class DomainEventsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            DomainEvents.SetDispatcher(new EventDispatcher(container));

            container.Register(Classes.FromAssemblyInThisApplication()
                .BasedOn(typeof(IDomainHandler<>))
                .WithServiceBase()
                .LifestyleTransient());

        }
    }
}