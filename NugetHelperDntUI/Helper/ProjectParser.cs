using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Construction;
using NugetHelperDntUI.Model;

namespace NugetHelperDntUI.Helper
{
    public class ProjectParser
    {
        public IEnumerable<SourceProject> GetProjectsFromSolution(string slnPath)
        {
            var solutionFile = SolutionFile.Parse(slnPath);
            var projectNames = solutionFile.ProjectsInOrder;
            var result = ConvertProject(projectNames);
            return result;
        }

        private IEnumerable<SourceProject> ConvertProject(IEnumerable<ProjectInSolution> projects)
        {
            var result = new List<SourceProject>();

            foreach(var project in projects)
            {
                var sourceProject = new SourceProject()
                {
                    AbsolutePath = project.AbsolutePath,
                    ProjectName = project.ProjectName,
                    ProjectGuid = project.ProjectGuid
                };
                result.Add(sourceProject);
            }

            return result;
        }

        public IEnumerable<TargetProject> GetTargetProjectsFromSolution(string slnPath)
        {
            var solutionFile = SolutionFile.Parse(slnPath);
            var projectNames = solutionFile.ProjectsInOrder;
            var result = ConvertTargetProject(projectNames);
            return result;
        }

        private IEnumerable<TargetProject> ConvertTargetProject(IEnumerable<ProjectInSolution> projects)
        {
            var result = new List<TargetProject>();

            foreach (var project in projects)
            {
                var sourceProject = new TargetProject()
                {
                    AbsolutePath = project.AbsolutePath,
                    ProjectName = project.ProjectName,
                    Dependencies = project.Dependencies.Select(x => new TargetDependency(x))
                };

                result.Add(sourceProject);
            }

            return result;
        }
    }
}