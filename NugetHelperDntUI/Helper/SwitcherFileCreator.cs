using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using NugetHelperDntUI.Model;

namespace NugetHelperDntUI.Helper
{
    public class SwitcherFileCreator
    {
        public string GetSwitcherFileContent(SwitcherContent content)
        {
            var json = JsonConvert.SerializeObject(content, Formatting.Indented);
            return json;
        }

        public SwitcherContent GenerateContent(string slnPath, IEnumerable<SourceProject> projects)
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

        public string CreateSwitcherFile(string slnPath, IEnumerable<SourceProject> projects, string fileName = "switcher.json")
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