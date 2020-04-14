namespace NugetHelperDntUI.Model
{
    public class SourceProject : IPresentableProject
    {
        public string AbsolutePath { get; set; }
        public string ProjectName { get; set; }
        public string ProjectGuid { get; set; }

        public override string ToString()
        {
            return $"{ProjectName}";
        }

        public string ToolTipText()
        {
            return $"{ProjectName} {ProjectGuid}";
        }
    }
}
