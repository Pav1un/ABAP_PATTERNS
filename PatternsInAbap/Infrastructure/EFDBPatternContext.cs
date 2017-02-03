using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PatternsInAbap.Models;

namespace PatternsInAbap.Infrastructure
{
    public class EFDBPatternContext: DbContext
    {
        public EFDBPatternContext() : base("AbapPatterns") { }

        public DbSet<Pattern> Paterns { get; set; }
        public DbSet<Link> Links { get; set; }

    }
}