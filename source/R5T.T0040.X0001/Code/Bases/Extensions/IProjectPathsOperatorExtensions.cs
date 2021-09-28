using System;

using R5T.T0040;

using Instances = R5T.T0040.X0001.Instances;


namespace System
{
    public static class IProjectPathsOperatorExtensions
    {
        public static string GetCodeDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.CodeDirectoryName.Code();
            return output;
        }

        public static string GetCodeDirectoryPath(this IProjectPathsOperator _,
            string projectDirectoryPath)
        {
            var output = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                _.GetCodeDirectoryRelativePath());

            return output;
        }

        public static string GetConstantsDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetCodeDirectoryRelativePath(),
                Instances.CodeDirectoryName.Constants());

            return output;
        }

        public static string GetStandardProjectPlanFileRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.FileName.ProjectPlan();
            return output;
        }

        public static string GetStandardDocumentationFileRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetCodeDirectoryRelativePath(),
                Instances.CodeFileName.Documentation());

            return output;
        }

        public static string GetStandardDocumentationFilePath(this IProjectPathsOperator _,
            string projectDirectoryPath)
        {
            var output = Instances.PathOperator.GetFilePath(
                projectDirectoryPath,
                _.GetStandardDocumentationFileRelativePath());

            return output;
        }

        public static string GetStandardProgramFileRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetCodeDirectoryRelativePath(),
                Instances.CodeFileName.Program());

            return output;
        }

        public static string GetStandardProgramFilePath(this IProjectPathsOperator _,
            string projectDirectoryPath)
        {
            var output = Instances.PathOperator.GetFilePath(
                projectDirectoryPath,
                _.GetStandardProgramFileRelativePath());

            return output;
        }

        public static string GetServicesDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetCodeDirectoryRelativePath(),
                Instances.CodeDirectoryName.Services());

            return output;
        }

        public static string GetServiceClassesDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetServicesDirectoryRelativePath(),
                Instances.CodeDirectoryName.Classes());

            return output;
        }

        public static string GetServiceClassesDirectoryPath(this IProjectPathsOperator _,
            string projectDirectoryPath)
        {
            var serviceClassesDirectoryRelativePath = _.GetServiceClassesDirectoryRelativePath();

            var output = Instances.PathOperator.Combine(
                projectDirectoryPath,
                serviceClassesDirectoryRelativePath);

            return output;
        }

        public static string GetServiceDefinitionsDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetServicesDirectoryRelativePath(),
                Instances.CodeDirectoryName.Definitions());

            return output;
        }

        public static string GetServiceDefinitionsDirectoryPath(this IProjectPathsOperator _,
            string projectDirectoyPath)
        {
            var serviceDefinitionsDirectoryRelativePath = _.GetServiceDefinitionsDirectoryRelativePath();

            var output = Instances.PathOperator.Combine(
                projectDirectoyPath,
                serviceDefinitionsDirectoryRelativePath);

            return output;
        }

        public static string GetServiceExtensionsDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetServicesDirectoryRelativePath(),
                Instances.CodeDirectoryName.Extensions());

            return output;
        }

        public static string GetServiceImplementationsDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetServicesDirectoryRelativePath(),
                Instances.CodeDirectoryName.Implementations());

            return output;
        }

        public static string GetServiceImplementationsDirectoryPath(this IProjectPathsOperator _,
            string projectDirectoryPath)
        {
            var output = Instances.PathOperator.Combine(
                projectDirectoryPath,
                _.GetServiceImplementationsDirectoryRelativePath());

            return output;
        }

        public static string GetExtensionsDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetCodeDirectoryRelativePath(),
                Instances.CodeDirectoryName.Extensions());

            return output;
        }

        public static string GetBasesDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetCodeDirectoryRelativePath(),
                Instances.CodeDirectoryName.Bases());

            return output;
        }

        public static string GetBaseExtensionsDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetBasesDirectoryRelativePath(),
                Instances.CodeDirectoryName.Extensions());

            return output;
        }

        public static string GetBaseInterfacesDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetBasesDirectoryRelativePath(),
                Instances.CodeDirectoryName.Interfaces());

            return output;
        }

        public static string GetBaseClassesDirectoryRelativePath(this IProjectPathsOperator _)
        {
            var output = Instances.PathOperator.Combine(
                _.GetBasesDirectoryRelativePath(),
                Instances.CodeDirectoryName.Classes());

            return output;
        }
    }
}
