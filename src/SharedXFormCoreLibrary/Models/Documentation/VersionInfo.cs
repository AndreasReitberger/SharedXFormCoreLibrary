using System.Collections.Generic;

namespace AndreasReitberger.Shared.XForm.Core.Documentation
{
    public class VersionInfo
    {
        #region Properties
        public string Version { get; set; } = string.Empty;
        public List<ChangeInfo> Changes { get; set; } = new();
        #endregion

        #region Constructor
        public VersionInfo() { }
        public VersionInfo(string version, List<ChangeInfo> changes)
        {
            Version = version;
            Changes = changes;
        }
        #endregion
    }
}
