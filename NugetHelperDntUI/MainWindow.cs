using NugetHelperDntUI.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NugetHelperDntUI.Helper;
using System.Security.Cryptography.X509Certificates;

namespace NugetHelperDntUI
{
    public partial class MainWindow : Form
    {
        private const string DntGithubLink = "https://github.com/RicoSuter/DNT/";
        private ProjectParser projectParser;
        private DntRunner dntRunner;
        private SwitcherFileCreator switcherFileCreator;

        private IEnumerable<TargetProject> TargetProjects = new List<TargetProject>();

        public MainWindow()
        {
            InitializeComponent();

            projectParser = new ProjectParser();
            dntRunner = new DntRunner();
            switcherFileCreator = new SwitcherFileCreator();
        }

        private void btnDntLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", $"/C start {DntGithubLink}");
        }

        private void btnOpenTargetFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txTargetSolution.Text = openFileDialog.FileName;
                PopulateTargetProjectList(txTargetSolution.Text);
                RegenerateContent();
            }
        }

        private void PopulateTargetProjectList(string solutionPath)
        {
            TargetProjects = projectParser.GetTargetProjectsFromSolution(solutionPath);
            
            notFoundSourceDependencies.Nodes.Clear();
            foundSourceDependencies.Nodes.Clear();
            selectedSourceDependencies.Nodes.Clear();

            foreach(var project in TargetProjects)
            {
                notFoundSourceDependencies.AddProjectNodes(project.ProjectName, project.Dependencies);
            }
        }

        private void btnLoadSourceProject_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PopulateSourceProjectList(openFileDialog.FileName);
                RegenerateContent();
            }
        }

        private void PopulateSourceProjectList(string solutionPath)
        {
            var projects = projectParser.GetProjectsFromSolution(solutionPath);

            sourceProjects.AddProjectNodes(Path.GetFileName(solutionPath), projects);
        }

        private void btnGenerateContent_Click(object sender, EventArgs e)
        {
            RegenerateContent();
        }

        private void RegenerateContent()
        {
            var contents = switcherFileCreator.GenerateContent(txTargetSolution.Text, sourceProjects.GetSelectedProjects());
            txtContent.Text = switcherFileCreator.GetSwitcherFileContent(contents);
        }

        private void sourceProjects_AfterCheck(object sender, TreeViewEventArgs e)
        {

            if (e.Action != TreeViewAction.Unknown)
            {
                sourceProjects.Enabled = false;
                sourceProjects.BeginUpdate();
                try
                {
                    if (e.Node.Nodes.Count > 0)
                    {
                        e.Node.CheckAllChildNodes(e.Node.Checked);
                    }

                    if (e.Node.Parent != null && e.Node.Parent.Nodes.Count > 0)
                    {
                        e.Node.Parent.Checked = e.Node.Parent.Nodes.Cast<TreeNode>().Any(x => x.Checked);
                    }
                }
                finally
                {
                    sourceProjects.EndUpdate();
                    sourceProjects.Enabled = true;
                }

                SetFoundAndSelectedProjects();
                RegenerateContent();
            }
        }

        private void SetFoundAndSelectedProjects()
        {
            var allProjects = sourceProjects.Nodes.Descendants().Where(x => x.Tag is SourceProject);
            var foundProjects = new Dictionary<string, List<TargetDependency>>();
            var selectProjects = new Dictionary<string, List<TargetDependency>>();

            foreach (var targetProject in TargetProjects) {
                var foundDependencies = new List<TargetDependency>();
                var selectedDependencies = new List<TargetDependency>();
                foundDependencies.AddRange(targetProject.Dependencies.Where(x => allProjects.Any(y => (y.Tag as SourceProject).ProjectName == x.ProjectName)).ToList());
                selectedDependencies.AddRange(targetProject.Dependencies.Where(x => allProjects.Any(y => y.Checked && (y.Tag as SourceProject).ProjectName == x.ProjectName)).ToList());
                foundProjects.Add(targetProject.ProjectName, foundDependencies);
                selectProjects.Add(targetProject.ProjectName, selectedDependencies);
            }
            //var foundProjects = TargetProjects.Where(x => allProjects.Any(y => (y.Tag as SourceProject).ProjectName == x.ProjectName)).ToList();
            //var selectProjects = TargetProjects.Where(x => allProjects.Any(y => y.Checked && (y.Tag as SourceProject).ProjectName == x.ProjectName)).ToList();

            foundSourceDependencies.Nodes.Clear();
            foreach (var project in foundProjects)
            {
                var projectNode = new TreeNode();
                projectNode.Text = project.Key;
                foreach (var dependency in project.Value)
                {
                    var dependencyNode = new TreeNode();
                    dependencyNode.Text = dependency.ProjectName;
                    dependencyNode.Tag = dependency;
                    projectNode.Nodes.Add(dependencyNode);
                }

                if (projectNode.Nodes.Count > 0)
                {
                    foundSourceDependencies.Nodes.Add(projectNode);
                }                
            }

            selectedSourceDependencies.Nodes.Clear();
            foreach (var project in selectProjects)
            {
                var projectNode = new TreeNode();
                projectNode.Text = project.Key;
                foreach (var dependency in project.Value)
                {
                    var dependencyNode = new TreeNode();
                    dependencyNode.Text = dependency.ProjectName;
                    dependencyNode.Tag = dependency;
                    dependencyNode.Checked = true;
                    projectNode.Nodes.Add(dependencyNode);
                }

                if (projectNode.Nodes.Count > 0)
                {
                    selectedSourceDependencies.Nodes.Add(projectNode);
                }                
            }
        }

        private void btnRunDnt_Click(object sender, EventArgs e)
        {
            // creating switcher file
            var filePath = switcherFileCreator.CreateSwitcherFile(txTargetSolution.Text, sourceProjects.GetSelectedProjects());
            //running command
            dntRunner.RunSwitchToProjects(filePath);
        }
    }
}
