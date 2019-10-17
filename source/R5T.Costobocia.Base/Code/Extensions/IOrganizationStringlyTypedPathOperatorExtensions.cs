using System;

using R5T.Ostrogothia;


namespace R5T.Costobocia
{
    public static class IOrganizationStringlyTypedPathOperatorExtensions
    {
        /// <summary>
        /// Default method uses <see cref="IOrganizationStringlyTypedPathOperator.GetOrganizationDirectoryPathFromBaseDirectoryPath(string, IOrganization)"/>.
        /// </summary>
        public static string GetOrganizationDirectoryPath(this IOrganizationStringlyTypedPathOperator organizationStringlyTypedPathOperator, string baseDirectoryPath, IOrganization organization)
        {
            var output = organizationStringlyTypedPathOperator.GetOrganizationDirectoryPathFromBaseDirectoryPath(baseDirectoryPath, organization);
            return output;
        }
    }
}
