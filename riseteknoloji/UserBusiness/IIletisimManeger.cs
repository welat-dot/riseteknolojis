using CoreLayer.Utilits.Result;
using UserDataAccess;
using UserEntity;

namespace UserBusiness
{
   
    public interface IIletisimManeger
    {
        IDataResult<Iletisim> add(Iletisim iletisim);
        IResult update(Iletisim iletisim);
        IResult delete(Iletisim iletisim);
        IDataResult<Iletisim> getByid(int id);
    }
}
