using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conferences
{
    class Searcher
    {
        IStrategy strat;
        Events ev;
        public Searcher(IStrategy strategy, Events events)
        {
            strat = strategy;
            ev = events;
        }

        public List<Events> SearcherAlgorithm()
        {
            return strat.AnalyzeFile(ev);
        }
    }
}
