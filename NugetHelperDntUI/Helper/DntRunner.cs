namespace NugetHelperDntUI.Helper
{
    public class DntRunner
    {
        private const string CmdSwitchToProjects = "/K dnt switch-to-projects \"{0}\"";

        public void RunSwitchToProjects(string pathToSwitcherFile)
        {
            var command = string.Format(CmdSwitchToProjects, pathToSwitcherFile);
            System.Diagnostics.Process.Start("CMD.exe",command);
        }
    }
}