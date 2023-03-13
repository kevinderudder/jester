using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Jester.OldSchool.Validators
{
    public static class RegexExpressions {
        public const string EMAIL = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public const string URL = @"^((http|https)://)(www.)?([a-zA-Z0-9]+).[a-zA-Z0-9]+";
    }
    
    // < C# 11
    public class UrlValidator
    {
        public static readonly Regex UrlRegex = new Regex(RegexExpressions.URL);
        public bool IsMatch(string input) => UrlRegex.IsMatch(input);
    }
    
    // C# 11
    public partial class UrlValidatorNew {
        [GeneratedRegex(RegexExpressions.URL, RegexOptions.CultureInvariant | RegexOptions.IgnoreCase)]
        public static partial Regex regex();
        public bool IsMatch(string input) => regex().IsMatch(input);
    }
}
