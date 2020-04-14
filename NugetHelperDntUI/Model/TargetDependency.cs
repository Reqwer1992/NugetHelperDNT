namespace NugetHelperDntUI.Model
{
    public class TargetDependency: IPresentableProject
    {
        public string ProjectName { get; set; }

        public string ProjectGuid { get; set; }

        public bool IsFound { get; set; }

        public TargetDependency(string guid)
        {
            ProjectGuid = guid;
        }

        public override string ToString()
        {
            if (IsFound)
            {
                return $"{ProjectName}";
            } 

            return $"{ProjectName} {ProjectGuid}";
        }

        public string ToolTipText()
        {
            return $"{ProjectName} {ProjectGuid}";
        }
    }
}
