using BenchmarkDotNet.Attributes;
using Jester.OldSchool.Validators;
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
    public class ValidatorBenchmarks
    {
        private static readonly UrlValidator _urlValidator = new UrlValidator();
        private static readonly UrlValidatorNew _urlValidatorNew = new UrlValidatorNew();

        [Params("https://www.google.com", "google")]
        public string url = string.Empty;

        [Benchmark]
        public bool IsMatchOldSchool() => _urlValidator.IsMatch(url);

        [Benchmark]
        public bool IsMatchNewSchool() => _urlValidatorNew.IsMatch(url);
    }
}
