using System;

using R5T.T0064;


namespace R5T.Costobocia
{
    [ServiceDefinitionMarker]
    public interface IOrganizationDirectoryPathProvider : IServiceDefinition
    {
        string GetOrganizationDirectoryPath();
    }
}
