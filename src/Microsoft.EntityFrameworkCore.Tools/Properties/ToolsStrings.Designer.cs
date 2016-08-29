// <auto-generated />
namespace Microsoft.EntityFrameworkCore.Internal
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
    using JetBrains.Annotations;

    /// <summary>
    ///		This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public static partial class ToolsStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Tools.Properties.ToolsStrings", typeof(ToolsStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// Build failed on '{projectName}'.
        /// </summary>
        public static string BuildFailed([CanBeNull] object projectName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("BuildFailed", "projectName"), projectName);
        }

        /// <summary>
        /// Could not invoke this command on the startup project '{projectName}'. This preview of Entity Framework tools does not support commands on class library projects in ASP.NET Core and .NET Core applications. See {fwlink} for details and workarounds.
        /// </summary>
        public static string ClassLibrariesNotSupportedInCli([CanBeNull] object projectName, [CanBeNull] object fwlink)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ClassLibrariesNotSupportedInCli", "projectName", "fwlink"), projectName, fwlink);
        }

        /// <summary>
        /// Could not invoke this command on this project. Commands for framework '{framework}' are only supported on Windows.
        /// </summary>
        public static string DesktopCommandsRequiresWindows([CanBeNull] object framework)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DesktopCommandsRequiresWindows", "framework"), framework);
        }

        /// <summary>
        /// Invoking dependency command '{projectCommand}' in project '{projectName}'
        /// </summary>
        public static string LogBeginDispatch([CanBeNull] object projectCommand, [CanBeNull] object projectName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogBeginDispatch", "projectCommand", "projectName"), projectCommand, projectName);
        }

        /// <summary>
        /// Using configuration '{configName}'.
        /// </summary>
        public static string LogUsingConfiguration([CanBeNull] object configName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogUsingConfiguration", "configName"), configName);
        }

        /// <summary>
        /// Using framework '{frameworkName}'.
        /// </summary>
        public static string LogUsingFramework([CanBeNull] object frameworkName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogUsingFramework", "frameworkName"), frameworkName);
        }

        /// <summary>
        /// Using target project '{project}'.
        /// </summary>
        public static string LogUsingTargetProject([CanBeNull] object project)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogUsingTargetProject", "project"), project);
        }

        /// <summary>
        /// Could not invoke this command with the startup project '{projectName}'. Check that '{dependencyCommand}' has been added to "dependencies" in the startup project and that the version of '{toolCommand}' in "tools" and '{dependencyCommand}' are the same. See {fwlink} for more details.
        /// </summary>
        public static string ProjectDependencyCommandNotFound([CanBeNull] object projectName, [CanBeNull] object dependencyCommand, [CanBeNull] object toolCommand, [CanBeNull] object fwlink)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ProjectDependencyCommandNotFound", "projectName", "dependencyCommand", "toolCommand", "fwlink"), projectName, dependencyCommand, toolCommand, fwlink);
        }

        /// <summary>
        /// Setting the data directory to '{path}'.
        /// </summary>
        public static string LogDataDirectory([CanBeNull] object path)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogDataDirectory", "path"), path);
        }

        /// <summary>
        /// Using startup project '{project}'.
        /// </summary>
        public static string LogUsingStartupProject([CanBeNull] object project)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogUsingStartupProject", "project"), project);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
