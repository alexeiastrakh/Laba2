using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conferences
{
     interface IStrategy
    {
        List<Events> AnalyzeFile(Events events);
    }
}
