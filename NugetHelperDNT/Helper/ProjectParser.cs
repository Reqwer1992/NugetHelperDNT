using System.Collections.Generic;
using Microsoft.Build.Construction;

namespace NugetHelperDNT.Helper
{
    public class ProjectParser
    {
        public IReadOnlyList<ProjectInSolution> GetProjectsFromSolution(string slnPath)
        {
            var solutionFile = SolutionFile.Parse(slnPath);
            var projectNames = solutionFile.ProjectsInOrder;
            return projectNames;
        }
    }
}