using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{

    public class MarketingFirm
    {
        //Member Variables
        private ISweepstakesManager manager;
        public ISweepstakesManager Manager
        {
            get
            {
                return manager;
            }
            set
            {
                manager = value;
            }
        }


        //Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {

            this.Manager = manager;

        }
        //Member Method
        public void CreateSweepstake(string ssName)
        {
            Sweepstakes ss = new Sweepstakes(ssName);
            manager.InsertSweepstakes(ss);
        }

    }
}
