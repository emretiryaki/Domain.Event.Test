using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Domain.Event.Test.Domain;
using Domain.Event.Test.DomainService;

namespace Domain.Event.Test
{
    class Program
    {

        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());

            var applicationDomainService = new ApplicationDomainService();
            applicationDomainService.Add(1,"Adidas");

            Console.WriteLine(string.Format("Current Application Name {0} ,and Current  Default Node : {1}", Application.Name, Application.Nodes.First().Name));
        }
    }
}
