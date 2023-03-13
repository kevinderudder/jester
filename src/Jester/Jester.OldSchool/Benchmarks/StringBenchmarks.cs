using BenchmarkDotNet.Attributes;
using Jester.OldSchool.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jester.OldSchool.Benchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class StringBenchmarks
    {
        private const string FULLNAME = "kevin derudder";

        [Benchmark]
        public void GetLastname() {
            var lastname = FULLNAME.GetLastWordFromString();
        }

        [Benchmark]
        public void GetLastnameBySpan()
        {
            var lastname = FULLNAME.GetLastWordFromStringBySpan();
        }
    }
}
