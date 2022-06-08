namespace ZipCode.Core.Interfaces.IBusinessLayer
{
    public interface IUnitOfWorkBl
    {
        IZipCodeBl ZipCode { get; }
    }
}