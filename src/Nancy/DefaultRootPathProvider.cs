﻿namespace Nancy
{
    using System;

    /// <summary>
    /// Default implementation of <see cref="IRootPathProvider"/>.
    /// </summary>
    public class DefaultRootPathProvider : IRootPathProvider
    {
        /// <summary>
        /// Returns the root folder path of the current Nancy application.
        /// </summary>
        /// <returns>A <see cref="string"/> containing the path of the root folder.</returns>
        public string GetRootPath()
        {
#if CORE
            return Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.ApplicationBasePath;
#else
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
#endif
        }

        public string[] GetExcludePaths()
        {
            return new string[] { System.IO.Path.Combine(GetRootPath(), "data") };
        }
    }
}

