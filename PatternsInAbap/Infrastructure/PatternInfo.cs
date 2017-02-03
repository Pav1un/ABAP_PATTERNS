using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatternsInAbap.Infrastructure
{
    public static class PatternInfo
    {
        static List<String> ptrnTypes = new List<String> {
            "Порождающие", "Поведенческие", "Структурные"
        };

        public static IEnumerable<String> PatternTypes {
            get {
                return ptrnTypes;
            }
            private set { }
        }

    }
}