using System;

using R5T.Ostrogothia;


namespace R5T.Costobocia
{
    public interface ISpecifiedOrganizationDirectoryPathProvider
    {
        string GetOrganizationDirectoryPath(IOrganization organization);
    }
}
