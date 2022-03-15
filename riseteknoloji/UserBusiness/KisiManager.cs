using CoreLayer.Utilits.Result;
using UserDataAccess;
using UserEntity;
using UserEntity.DTO;

namespace UserBusiness
{
    public class KisiManager:IKisiManager
    {
        private IKisiDal kisiDal;
        private IIletisimManeger iletisimManeger;
        public KisiManager(IKisiDal kisiDal, IIletisimManeger iletisimManeger)
        {
            this .kisiDal = kisiDal;    
            this.iletisimManeger = iletisimManeger;
        }

        public IResult add(KisiDTO kisi)
        {
            IDataResult<Iletisim> resultilt = iletisimManeger.add(kisi.Iletisim);
            if (!resultilt.success)
                return new ErrorResult("İletişim Bilgileri Hatalı");
            kisi.kisi.ILetisimRefId = resultilt.data.Id;
            kisi.kisi.Guid =Guid.NewGuid().ToString();
            Kisi kisires = kisiDal.Add(kisi.kisi);
            return kisires == null ?
                new ErrorResult("Kişi Eklenirken Hata OLuştu") :
                new SuccessResult("Kişi Eklendi");           
        }

        public IResult delete(int id)
        {
            Kisi kisi = kisiDal.Get(x => x.Id == id);
            if (kisi == null)
                return new ErrorResult("Kişi Bulunamadı");
            kisi = kisiDal.Delete(kisi);
            if(kisi == null)
                return new ErrorResult("Kişi Silinirken Hata Oluştu");
            IDataResult<Iletisim> iletisim = iletisimManeger.getByid(kisi.ILetisimRefId);
            if (!iletisim.success)
                return new SuccessResult("Silme İşlemi Başarılı");
            IResult iltres = iletisimManeger.delete(iletisim.data);
            return !iltres.success  ?
                new ErrorResult("Kişinin İletişim Bilgisi Silinemedi") :
                new SuccessResult("Silme İşlemi Başarılı");

        }

        public IDataResult<List<KisiDTO>> getAll()
        {
            List<KisiDTO> KisiList = kisiDal.getAll();
            return new SuccessDataResult<List<KisiDTO>>(KisiList, "Başarılı");
        }

        public IDataResult<KisiDTO> getById(int id)
        {
            KisiDTO kisi = kisiDal.getByid(id);

            return kisi ==null ? new ErrorDataResult<KisiDTO>("Kullanıci Bulunamadı") : 
                new SuccessDataResult<KisiDTO>(kisi, "Başarılı");
        }

       

        public IResult update(KisiDTO kisi)
        {
            Kisi orjkisi = kisiDal.Get(x => x.Id == kisi.kisi.Id);
            if (orjkisi == null)
                return new ErrorResult("Kişi Bulunamadı");
            orjkisi.Soyad = kisi.kisi.Soyad;
            orjkisi.Ad=kisi.kisi.Ad;
            orjkisi.Firma =kisi.kisi.Firma;
            kisi.Iletisim.Id = orjkisi.ILetisimRefId;
            orjkisi = kisiDal.Update(orjkisi);
            if (orjkisi == null)
                return new ErrorResult("Kişi Guncellenemedi");
            IResult iltres = iletisimManeger.update(kisi.Iletisim);
            return iltres == null ?
                new ErrorResult("Kişinin İletişim Bilgileri Güncellenemedi") :
                new SuccessResult("Guncelleme İşlemi Başarılı");

            
        }
    }
}
