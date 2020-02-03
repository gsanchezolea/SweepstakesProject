using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Simulation
    {


        public Simulation()
        {

        }

        public ISweepstakesManager SelectASweepstakeManager(string input)
        {
            ISweepstakesManager manager;     
            switch (input)
            {
                case "stack":
                    return manager = new SweepstakesStackManager();      
                case "queue":
                    return manager = new SweepstakesQueueManager();
                default:
                    Console.WriteLine("Invalid Entry");
                    return null;             
            }
        }
       
        public void CreateMarketingFirmWithManager(ISweepstakesManager manager)
        {
            MarketingFirm marketingFirm = new MarketingFirm(manager);

        }
    }
}
