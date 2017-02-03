using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsInAbap.Models;

namespace PatternsInAbap.Infrastructure
{
    public interface IPatternsRepository
    {
        IEnumerable<Pattern> GetPatterns();
    }
}
