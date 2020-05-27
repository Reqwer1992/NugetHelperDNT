using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
                if (project.ProjectType == SolutionProjectType.KnownToBeMSBuildFormat)
                {
                    var sourceProject = new SourceProject()
                    {
                        AbsolutePath = project.AbsolutePath,
                        ProjectName = project.ProjectName,
                        ProjectGuid = project.ProjectGuid
                    };
                    result.Add(sourceProject);
                }
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
                if (project.ProjectType == SolutionProjectType.KnownToBeMSBuildFormat)
                {
                    result.Add(ConvertTargetProject(project));
                }
            }

            return result;
        }

        private Assembly GetProjectAssembly(ProjectInSolution project)
        {
            var path = Path.GetDirectoryName(project.AbsolutePath);
            var fileName = project.ProjectName + ".dll";
            var projectDlls = Directory.GetFiles(path, fileName, SearchOption.AllDirectories);

            if (projectDlls.Count() == 0)
            {
                return null;
            }
//            else
//            {
//                fileName = project.ProjectName + ".exe"; // not sure how to make this work
//                projectDlls = Directory.GetFiles(path, fileName, SearchOption.AllDirectories);
//            }

            if (projectDlls.Count() == 0)
            {
                return null;
            }

            //try
            //{
            var result = Assembly.LoadFrom(projectDlls[0]);
            return result;
            //} catch(Exception e)
            //{
                // log?
                //return null;
            //}
        }

        private TargetProject ConvertTargetProject(ProjectInSolution project)
        {
            var assembly = GetProjectAssembly(project);
            var dependencies = new List<TargetDependency>();
            
            if (assembly != null)
            {
                var referencedAssemblies = assembly.GetReferencedAssemblies();

                dependencies.AddRange(referencedAssemblies.Select(x => ConvertTargetDependency(x)));
            }

            var result = new TargetProject()
            {
                AbsolutePath = project.AbsolutePath,
                ProjectName = project.ProjectName,
                Dependencies = dependencies
            };

            return result;
        }

        private TargetDependency ConvertTargetDependency(AssemblyName assembly)
        {
            var result = new TargetDependency()
            {
                ProjectName = assembly.Name,
                Version = assembly.Version
            };

            return result;
        }
    }
}