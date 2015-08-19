using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Event.Test.Domain;
using Domain.Event.Test.EventAdd;
using Domain.Event.Test.Events;

namespace Domain.Event.Test.DomainService
{
    public class NodeDomainService
    {
        public void CreateNode()
        {
            var node = new Node()
            {
                Email = "email@adidas.com.tr",
                IsDefaultNode = true,
                Name = "DefaultAdidasNode",
                RefCode = "RefCode"
            };
            DomainEvents.Raise(new NewNodeAdded() { Node = node });
 
        }
    }

    
}
