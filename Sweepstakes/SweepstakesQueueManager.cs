using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager :ISweepstakesManager
    {
        //Member Variable
        private Queue<Sweepstakes> queue;
        //Constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }
        //Member Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);

        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
