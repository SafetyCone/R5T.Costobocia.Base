using System;

using R5T.Ostrogothia;


namespace R5T.Costobocia
{
    public interface IOrganizationStringlyTypedPathOperator
    {
        string GetOrganizationDirectoryPathFromBaseDirectoryPath(string baseDirectoryPath, IOrganization organization);
        string GetOrganizationDirectoryPathFromOrganizationsDirectoryPath(string organizationsDirectoryPath, IOrganization organization);
    }
}
