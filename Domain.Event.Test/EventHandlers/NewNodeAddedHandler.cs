using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Event.Test.Domain;
using Domain.Event.Test.EventAdd;

namespace Domain.Event.Test.EventHandlers
{
    public class NewNodeAddedHandler : IDomainHandler<NewNodeAdded>
    {
        public void Handle(NewNodeAdded args)
        {
          Console.WriteLine(string.Format("Application Name {0} , Added Default Node : {1}",Application.Name,args.Node.Name));
          Application.Nodes.Add(args.Node);
        }
    }
}
