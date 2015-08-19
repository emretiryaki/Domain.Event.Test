using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Event.Test.Domain;

namespace Domain.Event.Test.DomainService
{
    public class ApplicationDomainService
    {
        private readonly NodeDomainService _nodeDomainService;

        public ApplicationDomainService()
        {
            _nodeDomainService = new NodeDomainService();
        }

        public void Add(int id, string name)
        {
            Application.Id = id;
            Application.Name = name;
            Application.Nodes = new Collection<Node>();
            _nodeDomainService.CreateNode();

        }
    }
}
