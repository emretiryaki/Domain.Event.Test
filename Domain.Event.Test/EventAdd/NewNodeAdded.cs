using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Event.Test.Domain;
using Domain.Event.Test.Events;

namespace Domain.Event.Test.EventAdd
{
    public class NewNodeAdded : IDomainEvent
    {
        public Node Node { get; set; }
    }
}
