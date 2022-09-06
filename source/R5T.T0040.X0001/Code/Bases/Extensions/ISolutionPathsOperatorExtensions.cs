using System;

using R5T.T0040;

using Instances = R5T.T0040.X0001.Instances;


namespace System
{
    public static class ISolutionPathsOperatorExtensions
    {
        public static string GetSolutionDirectoryName(this ISolutionPathsOperator _,
            string solutionName)
        {
            Instances.PathOperator.Verify_NoInvalidPathCharacters(solutionName);

            // After checking, just use the project name as the project directory name.
            var output = solutionName;
            return output;
        }

        public static string GetSolutionDirectoryPathFromSolutionName(this ISolutionPathsOperator _,
            string parentDirectoryPath,
            string solutionName)
        {
            var solutionDirectoryName = _.GetSolutionDirectoryName(solutionName);

            var output = Instances.PathOperator.AppendDirectoryRelativePathToDirectoryPath(parentDirectoryPath, solutionDirectoryName);
            return output;
        }

        /// <summary>
        /// Gets the path to the source subdirectory of parent directory path.
        /// </summary>
        public static string GetSourceSolutionDirectoryPath(this ISolutionPathsOperator _,
            string parentDirectoryPath)
        {
            var output = Instances.PathOperator.AppendDirectoryRelativePathToDirectoryPath(
                parentDirectoryPath,
                Instances.CodeDirectoryName.Source());

            return output;
        }

        public static string GetSourceSolutionFilePath(this ISolutionPathsOperator _,
            string parentDirectoryPath,
            string solutionName)
        {
            var sourceSolutionDirectoryPath = _.GetSourceSolutionDirectoryPath(parentDirectoryPath);

            var solutionFileName = Instances.SolutionFileNameOperator.GetSolutionFileName(solutionName);

            var solutionFilePath = Instances.PathOperator.GetFilePath(sourceSolutionDirectoryPath, solutionFileName);
            return solutionFilePath;
        }

        public static string GetSolutionDirectoryPath(this ISolutionPathsOperator _,
            string solutionFilePath)
        {
            var output = Instances.PathOperator.GetParentDirectoryPath_ForFile(solutionFilePath);
            return output;
        }

        public static string GetSolutionFilePath(this ISolutionPathsOperator _,
            string solutionDirectoryPath,
            string solutionName)
        {
            var solutionFileName = Instances.SolutionFileNameOperator.GetSolutionFileName(solutionName);

            var output = Instances.PathOperator.GetFilePath(solutionDirectoryPath, solutionFileName);
            return output;
        }

        public static string GetSolutionFilePathForProject(this ISolutionPathsOperator _,
            string projectFilePath)
        {
            var solutionFileExtension = Instances.FileExtension.Sln();

            var path = projectFilePath;

            while (Instances.PathOperator.HasParentDirectory(path))
            {
                path = Instances.PathOperator.GetParentDirectoryPath(path);

                var hasSolutionFile = Instances.FileSystemOperator.HasFileInDirectoryByFileExtension(path, solutionFileExtension);
                if (hasSolutionFile)
                {
                    return hasSolutionFile.Result;
                }
            }

            // Otherwise, throw.
            throw new ArgumentException($"No solution file found in parent directories for project file:\n{projectFilePath}", nameof(projectFilePath));
        }

        public static string GetSolutionName(this ISolutionPathsOperator _,
            string solutionFilePath)
        {
            var solutionFileName = Instances.PathOperator.GetFileName(solutionFilePath);

            var output = Instances.SolutionFileNameOperator.GetSolutionNameFromSolutionFileName(solutionFileName);
            return output;
        }
    }
}
