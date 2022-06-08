namespace ZipCode.Core.Interfaces.IRepositories
{
    public interface IUnitOfWorkRepository
    {
        public IZipCodeRepository ZipCode { get; }
    }
}