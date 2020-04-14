using System.Collections.Generic;

namespace NugetHelperDntUI.Model
{
    public class TargetProject
    {
        public string ProjectName { get; set; }
        public string AbsolutePath { get; set; }

        public IEnumerable<TargetDependency> Dependencies { get; set; }
    }
}
