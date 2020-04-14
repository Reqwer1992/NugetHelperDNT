using NugetHelperDntUI.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NugetHelperDntUI.Helper
{
    public static class ControlsHelper
    {
        public static void CheckAllChildNodes(this TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        public static IEnumerable<TreeNode> Descendants(this TreeNodeCollection c)
        {
            foreach (var node in c.OfType<TreeNode>())
            {
                yield return node;

                foreach (var child in node.Nodes.Descendants())
                {
                    yield return child;
                }
            }
        }

        public static IEnumerable<SourceProject> GetSelectedProjects(this TreeView treeView)
        {
            var result = treeView.Nodes.Descendants()
                    .Where(x => x.Checked && x.Tag is SourceProject)
                    .Select(x => (SourceProject)x.Tag);

            return result;
        }

        public static void AddProjectNodes(this TreeView treeView, string nodeName, IEnumerable<IPresentableProject> projects)
        {
            treeView.BeginUpdate();
            try
            {
                var node = treeView.Nodes.Add(nodeName);
                foreach (var project in projects)
                {
                    var newNode = node.Nodes.Add(project.ToString());
                    newNode.Tag = project;
                    newNode.ToolTipText = project.ToolTipText();
                }
            }
            finally
            {
                treeView.EndUpdate();
            }
        }
    }
}
