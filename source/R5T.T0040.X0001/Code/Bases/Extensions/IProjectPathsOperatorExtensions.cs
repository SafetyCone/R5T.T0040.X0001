using System;

using R5T.T0040;

using Instances = R5T.T0040.X0001.Instances;


namespace System
{
    public static partial class IProjectPathsOperatorExtensions
    {
        public static string GetCodeDirectoryFileRelativePath(this IProjectPathsOperator _,
            string fileRelativePath)
        {
            var output = Instances.PathOperator.GetFilePath(
                _.GetCodeDirectoryRelativePath(),
                fileRelativePath);

            return output;
        }

        public static string GetCodeDirectoryPathFromProjectDirectoryPath(this IProjectPathsOperator _,
            string projectDirectoryPath)
        {
            var output = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                _.GetCodeDirectoryRelativePath());

            return output;
        }

        public static string GetCodeDirectoryPathFromProjectFilePath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var projectDirectoryPath = _.GetProjectDirectoryPath(projectFilePath);

            var codeDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                _.GetCodeDirectoryRelativePath());

            return codeDirectoryPath;
        }

        /// <summary>
        /// Chooses <see cref="GetCodeDirectoryPathFromProjectFilePath(IProjectPathsOperator, string)"/> as the default.
        /// </summary>
        public static string GetCodeDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var output = _.GetCodeDirectoryPathFromProjectFilePath(projectFilePath);
            return output;
        }

        public static string GetCodeDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.CodeDirectoryName.Code();
            return output;
        }

        public static string GetConstantsDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetCodeDirectoryRelativePath(),
                Instances.CodeDirectoryName.Constants());

            return output;
        }

        public static string GetExtensionsDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetCodeDirectoryRelativePath(),
                Instances.CodeDirectoryName.Extensions());

            return output;
        }

        public static string GetInterfacesDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetCodeDirectoryRelativePath(),
                Instances.CodeDirectoryName.Interfaces());

            return output;
        }

        public static string GetExtensionsDirectoryPath(this IProjectPathsOperator _,
            string projectDirectoryPath)
        {
            var extensionsDirectoryRelativePath = _.GetExtensionsDirectoryRelativePath();

            var output = Instances.PathOperator.Combine(
                projectDirectoryPath,
                extensionsDirectoryRelativePath);

            return output;
        }

        public static string GetBasesDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var codeDirectoryPath = _.GetCodeDirectoryPathFromProjectFilePath(projectFilePath);

            var basesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                codeDirectoryPath,
                Instances.CodeDirectoryName.Bases());

            return basesDirectoryPath;
        }

        public static string GetBasesInterfacesDirectoryPathFromProjectFilePath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var basesDirectoryPath = _.GetBasesDirectoryPath(projectFilePath);

            var basesInterfacesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                basesDirectoryPath,
                Instances.CodeDirectoryName.Interfaces());

            return basesInterfacesDirectoryPath;
        }

        public static string GetBasesInterfacesDirectoryPathFromProjectDirectoryPath(this IProjectPathsOperator _,
            string projectDirectoryPath)
        {
            var basesInterfacesDirectoryRelativePath = _.GetBasesInterfacesDirectoryRelativePath();

            var output = Instances.PathOperator.Combine(
                projectDirectoryPath,
                basesInterfacesDirectoryRelativePath);

            return output;
        }

        /// <summary>
        /// Defines <see cref="GetBasesInterfacesDirectoryPathFromProjectFilePath(IProjectPathsOperator, string)"/> as the default.
        /// </summary>
        public static string GetBasesInterfacesDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var output = _.GetBasesInterfacesDirectoryPathFromProjectFilePath(projectFilePath);
            return output;
        }

        public static string GetInterfacesDirectoryPath_FromProjectFilePath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var codeDirectoryPath = _.GetCodeDirectoryPathFromProjectFilePath(projectFilePath);

            var interfacesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                codeDirectoryPath,
                Instances.CodeDirectoryName.Interfaces());

            return interfacesDirectoryPath;
        }

        public static string GetInterfacesDirectoryPath(this IProjectPathsOperator _,
            string projectDirectoryPath)
        {
            var interfacesDirectoryRelativePath = _.GetInterfacesDirectoryRelativePath();

            var interfacesDirectoryPath = Instances.PathOperator.Combine(
                projectDirectoryPath,
                interfacesDirectoryRelativePath);

            return interfacesDirectoryPath;
        }
    }
}
