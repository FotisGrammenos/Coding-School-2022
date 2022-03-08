using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var actionResolver = new ActionResolverConsole();
            var request = new ActionRequest();
            var actionResponse = new ActionResponse();

            request.Input = "10.8";
            request.Action = ActionEnum.Convert;
            actionResponse = actionResolver.Execute(request);

            request = new ActionRequest();
            request.Input = "Hello world";
            request.Action = ActionEnum.UpperCase;
            actionResponse = actionResolver.Execute(request);

            request = new ActionRequest();
            request.Input = "Fotis Grammenos";
            request.Action = ActionEnum.Reverse;
            actionResponse = actionResolver.Execute(request);



            Console.WriteLine("---------------------------------------------\n Printout MessageLogger ");
            actionResolver.Logger.ReadAll();
            Console.WriteLine("---------------------------------------------");


            Console.ReadLine();

        }
    }
}
