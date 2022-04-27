using System;

using R5T.T0064;


namespace R5T.Costobocia
{
    [ServiceDefinitionMarker]
    public interface IOrganizationsDirectoryPathProvider : IServiceDefinition
    {
        string GetOrganizationsDirectoryPath();
    }
}
