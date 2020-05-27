using System;

namespace NugetHelperDntUI.Model
{
    public class TargetDependency: IPresentableProject
    {
        public string ProjectName { get; set; }

        public Version? Version { get; set; }

        public override string ToString()
        {
            return ProjectName;
        }

        public string ToolTipText()
        {
            return $"{ProjectName} {Version?.ToString()}";
        }
    }
}
