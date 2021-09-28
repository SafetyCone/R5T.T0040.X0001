using System;

using R5T.T0021;
using R5T.T0037;
using R5T.T0041;


namespace R5T.T0040.X0001
{
    public static class Instances
    {
        public static ICodeDirectoryName CodeDirectoryName { get; } = T0037.CodeDirectoryName.Instance;
        public static ICodeFileName CodeFileName { get; } = T0037.CodeFileName.Instance;
        public static IFileName FileName { get; } = T0021.FileName.Instance;
        public static IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
    }
}
