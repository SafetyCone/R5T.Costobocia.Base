using System;

using R5T.Ostrogothia;

using R5T.T0064;


namespace R5T.Costobocia
{
    [ServiceDefinitionMarker]
    public interface IOrganizationStringlyTypedPathOperator : IServiceDefinition
    {
        string GetOrganizationDirectoryPathFromBaseDirectoryPath(string baseDirectoryPath, IOrganization organization);
        string GetOrganizationDirectoryPathFromOrganizationsDirectoryPath(string organizationsDirectoryPath, IOrganization organization);
    }
}
