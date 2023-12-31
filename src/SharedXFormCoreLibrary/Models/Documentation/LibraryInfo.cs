﻿namespace AndreasReitberger.Shared.XForm.Core.Documentation
{
    public class LibraryInfo
    {
        #region Properties
        public string Library { get; set; }
        public string LibraryUrl { get; set; }
        public string Description { get; set; }
        public bool StateChanged { get; set; }
        public string License { get; set; }
        public string LicenseUrl { get; set; }
        #endregion

        #region Constructor
        public LibraryInfo(string library, string libraryUrl, string description, string license, string licenseUrl, bool stateChanged = false)
        {
            Library = library;
            LibraryUrl = libraryUrl;
            Description = description;
            License = license;
            LicenseUrl = licenseUrl;
            StateChanged = stateChanged;
        }
        #endregion
    }
}
