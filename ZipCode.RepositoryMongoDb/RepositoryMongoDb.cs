using ZipCode.Core.Interfaces.IRepositories;

namespace ZipCode.RepositoryMongoDb
{
    public class RepositoryMongoDb : IUnitOfWorkRepository
    {
        public RepositoryMongoDb(IZipCodeRepository zipCode)
        {
            ZipCode = zipCode;
        }
        public IZipCodeRepository ZipCode { get; }
    }
}
