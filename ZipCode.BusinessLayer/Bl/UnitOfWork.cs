using ZipCode.Core.Interfaces.IBusinessLayer;

namespace ZipCode.BusinessLayer.Bl
{
    public class UnitOfWork : IUnitOfWorkBl
    {

        public UnitOfWork(IZipCodeBl zipCodeBl)
        {
            ZipCode = zipCodeBl;
        }

        public IZipCodeBl ZipCode { get; }        
    }
}