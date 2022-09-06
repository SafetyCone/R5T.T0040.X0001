using System;

using R5T.F0002;
using R5T.T0021;
using R5T.T0032;
using R5T.T0037;
using R5T.T0044;


namespace R5T.T0040.X0001
{
    public static class Instances
    {
        public static ICodeDirectoryName CodeDirectoryName { get; } = T0037.CodeDirectoryName.Instance;
        public static ICodeFileName CodeFileName { get; } = T0037.CodeFileName.Instance;
        public static IFileExtension FileExtension { get; } = T0032.FileExtension.Instance;
        public static IFileName FileName { get; } = T0021.FileName.Instance;
        public static IFileSystemOperator FileSystemOperator { get; } = T0044.FileSystemOperator.Instance;
        public static IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
        public static ISolutionFileNameOperator SolutionFileNameOperator { get; } = T0040.SolutionFileNameOperator.Instance;
    }
}
