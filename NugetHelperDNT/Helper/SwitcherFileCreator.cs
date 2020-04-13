using System.Collections.Generic;
using System.IO;
using Microsoft.Build.Construction;
using Newtonsoft.Json;
using NugetHelperDNT.Model;

namespace NugetHelperDNT.Helper
{
    public class SwitcherFileCreator
    {
        public string GetSwitcherFileContent(SwitcherContent content)
        {
            var json = JsonConvert.SerializeObject(content);
            return json;
        }

        public SwitcherContent GenerateContent(string slnPath, IEnumerable<ProjectInSolution> projects)
        {
            var slnName = Path.GetFileName(slnPath);

            var result = new SwitcherContent()
            {
                solution = slnName
            };

            foreach (var project in projects)
            {
                result.mappings.Add(project.ProjectName, project.AbsolutePath);
            }

            return result;
        }

        public string CreateSwitcherFile(string slnPath, IEnumerable<ProjectInSolution> projects, string fileName = "switcher.json")
        {
            var path = Path.GetDirectoryName(slnPath);
            var absoluteFilePath = Path.Combine(path, fileName);

            var content = GenerateContent(slnPath, projects);
            var stringContent = GetSwitcherFileContent(content);

            File.WriteAllText(absoluteFilePath, stringContent);

            return absoluteFilePath;
        }
    }
}