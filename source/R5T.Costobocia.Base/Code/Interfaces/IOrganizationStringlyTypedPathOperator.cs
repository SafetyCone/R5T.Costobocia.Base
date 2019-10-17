using System;

using R5T.Ostrogothia;


namespace R5T.Costobocia
{
    public interface IOrganizationStringlyTypedPathOperator
    {
        string GetOrganizationDirectoryPath(string organizationsDirectoryPath, IOrganization organization);
    }
}
