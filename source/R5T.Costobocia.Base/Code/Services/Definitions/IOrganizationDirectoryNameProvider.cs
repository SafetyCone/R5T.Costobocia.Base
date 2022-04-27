using System;

using R5T.Ostrogothia;

using R5T.T0064;


namespace R5T.Costobocia
{
    [ServiceDefinitionMarker]
    public interface IOrganizationDirectoryNameProvider : IServiceDefinition
    {
        string GetOrganizationDirectoryName(IOrganization organization);
    }
}
