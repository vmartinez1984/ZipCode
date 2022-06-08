using ZipCode.Core.Interfaces.IRepositories;
using ZipCode.Core.Entities;
using ZipCode.RepositoryEfMySql.Contexts;

namespace ZipCode.RepositoryEfMySql
{
    public class Repository : IUnitOfWorkRepository
    {

        public Repository(IZipCodeRepository zipCode)
        {
            ZipCode = zipCode;
        }
        public IZipCodeRepository ZipCode { get; }

    }
}