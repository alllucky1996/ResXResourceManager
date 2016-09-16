namespace ResXManager.Scripting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;

    using tomenglertde.ResXManager.Model;

    [Export]
    [Export(typeof(ISourceFilesProvider))]
    internal class SourceFilesProvider : ISourceFilesProvider, ISourceFileFilter
    {
        public string Folder { get; set; }

        public IList<ProjectFile> SourceFiles
        {
            get
            {
                var folder = Folder;
                if (String.IsNullOrEmpty(folder))
                    return new ProjectFile[0];

                return new DirectoryInfo(folder).GetAllSourceFiles(this);
            }
        }

        public bool IsSourceFile(ProjectFile file)
        {
            return false;
        }
    }
}