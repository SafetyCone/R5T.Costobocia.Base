using System;

using R5T.Ostrogothia;


namespace R5T.Costobocia
{
    public interface IOrganizationDirectoryNameProvider
    {
        string GetOrganizationDirectoryName(IOrganization organization);
    }
}
