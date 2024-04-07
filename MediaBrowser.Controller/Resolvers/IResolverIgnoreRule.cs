using Jellyfin.Data.Enums;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Model.IO;

namespace MediaBrowser.Controller.Resolvers
{
    /// <summary>
    /// Provides a base "rule" that anyone can use to have paths ignored by the resolver.
    /// </summary>
    public interface IResolverIgnoreRule
    {
        /// <summary>
        /// Checks whether or not the file should be ignored.
        /// </summary>
        /// <param name="fileInfo">The file information.</param>
        /// <param name="collectionType">The collection type of the library we're filtering the file information in.</param>
        /// <param name="parent">The parent BaseItem.</param>
        /// <returns>True if the file should be ignored.</returns>
        bool ShouldIgnore(FileSystemMetadata fileInfo, CollectionType? collectionType, BaseItem parent);
    }
}
