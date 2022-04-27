using System;
using System.Threading.Tasks;

using R5T.T0040;

using Instances = R5T.T0040.X0001.Instances;


namespace System
{
    public static partial class IProjectPathsOperatorExtensions
    {
        public static Task<string[]> GetExtensionsDirectoryFilePaths(this IProjectPathsOperator projectPathsOperator,
            string projectFilePath)
        {
            var projectDirectoryPath = projectPathsOperator.GetProjectDirectoryPath(
                        projectFilePath);

            var projectExtensionsDirectoryPath = projectPathsOperator.GetExtensionsDirectoryPath(
                projectDirectoryPath);

            var extensionsDirectoryDescendantFilePaths = Instances.FileSystemOperator.GetAllDescendentFilePathsOrEmptyIfNotExists(projectExtensionsDirectoryPath);

            return Task.FromResult(extensionsDirectoryDescendantFilePaths);
        }

        public static Task<string[]> GetServicesDefinitionsDirectoryFilePaths(this IProjectPathsOperator projectPathsOperator,
            string projectFilePath)
        {
            var projectDirectoryPath = projectPathsOperator.GetProjectDirectoryPath(
                projectFilePath);

            var projectServiceDefinitionsDirectoryPath = projectPathsOperator.GetServicesDefinitionsDirectoryPath(
                projectDirectoryPath);

            var serviceDefinitionDirectoryDescendentFilePaths = Instances.FileSystemOperator.GetAllDescendentFilePathsOrEmptyIfNotExists(projectServiceDefinitionsDirectoryPath);

            return Task.FromResult(serviceDefinitionDirectoryDescendentFilePaths);
        }
    }
}
