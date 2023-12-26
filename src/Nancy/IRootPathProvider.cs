namespace Nancy
{
    /// <summary>
    /// Defines the functionality to retrieve the root folder path of the current Nancy application.
    /// </summary>
    public interface IRootPathProvider : IHideObjectMembers
    {
        /// <summary>
        /// Returns the root folder path of the current Nancy application.
        /// </summary>
        /// <returns>A <see cref="string"/> containing the path of the root folder.</returns>
        string GetRootPath();

        /// <summary>
        /// Returns a list of absolute paths in the root path that should not be searched through.
        /// </summary>
        /// <returns>A list of <see cref="string"/> containing paths that should be ignored.</returns>
        string[] GetExcludePaths();
    }
}
