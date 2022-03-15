using CoreLayer.Utilits.Result;
using UserDataAccess;
using UserEntity;

namespace UserBusiness
{
    public class IletisimManeger: IIletisimManeger
    {
        private IIletisimDal iletisimDal;
        public IletisimManeger(IIletisimDal iletisimDal)
        {
            this.iletisimDal = iletisimDal;
        }

        public IDataResult<Iletisim> add(Iletisim iletisim)
        {
           Iletisim iletisimres  = iletisimDal.Add(iletisim);
            return iletisimres == null ?
                new ErrorDataResult<Iletisim>(iletisimres, "entity eklenirken hata oluştu") :
                new SuccessDataResult<Iletisim>(iletisimres, "entity ekleme Başarılı");
        }

        public IResult delete(Iletisim iletisim)
        {
            Iletisim iletisimres = iletisimDal.Delete(iletisim);
            return iletisimres == null ?
                new ErrorResult("entity silinirken hata olustu") :
                new SuccessResult("silme işlemi başarılı");
        }

        public IDataResult<Iletisim> getByid(int id)
        {
            Iletisim iletisim = iletisimDal.Get(x=>x.Id == id);
            return iletisim == null ?
                new ErrorDataResult<Iletisim>(iletisim, "İletişim Bilgisi Bulunamdı") :
                new SuccessDataResult<Iletisim>(iletisim, "");
        }

        public IResult update(Iletisim iletisim)
        {
            Iletisim iletisimres = iletisimDal.Update(iletisim);
            return iletisimres == null ?
                new ErrorResult("update yapılırken hata olustu") :
                new SuccessResult("update işlemi başarılı");

        }
    }
}
