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

        private IEnumerable<TargetProject> TargetProject = new List<TargetProject>();

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
            var TargetProject = projectParser.GetTargetProjectsFromSolution(solutionPath);
            
            notFoundSourceDependencies.Nodes.Clear();
            foundSourceDependencies.Nodes.Clear();
            selectedSourceDependencies.Nodes.Clear();

            foreach(var project in TargetProject)
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
            /*sourceProjects.BeginUpdate();
            try
            {                
                var node = sourceProjects.Nodes.Add(Path.GetFileName(solutionPath));
                foreach(var project in projects)
                {
                    var newNode = node.Nodes.Add(project.ToString());
                    newNode.Tag = project;
                }
            }
            finally
            {
                sourceProjects.EndUpdate();
            }*/
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

                RegenerateContent();
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
