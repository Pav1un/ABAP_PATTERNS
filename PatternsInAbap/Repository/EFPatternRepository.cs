using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PatternsInAbap.Infrastructure;
using PatternsInAbap.Models;

namespace PatternsInAbap.Repository
{
    public class EFPatternRepository: IPatternsRepository
    {
        EFDBPatternContext ptrnCntxt = new EFDBPatternContext();

        public IEnumerable<Pattern> GetPatterns() {
            return ptrnCntxt.Paterns;
        }

    }
}