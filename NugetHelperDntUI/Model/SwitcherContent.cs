// ReSharper disable InconsistentNaming

using System.Collections.Generic;

namespace NugetHelperDntUI.Model
{
    public class SwitcherContent
    {
        public string solution { get; set; }
        public Dictionary<string, string> mappings { get; set; } = new Dictionary<string, string>();
    }
}