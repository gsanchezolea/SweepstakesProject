using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Simulation        
    {
        MarketingFirm marketingFirm;

        public Simulation()
        {
            
        }

        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager newManager;
            int input = 0;
            
            switch (input)
            {
                case 1: newManager = new SweepstakesStackManager();
                    marketingFirm = new MarketingFirm(newManager);

                    break;

                case 2: newManager = new SweepstakesQueueManager();
                        marketingFirm = new MarketingFirm(newManager);
                    break;
            }
       
        }
    }
}
