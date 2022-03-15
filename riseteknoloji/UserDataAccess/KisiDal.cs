using CoreLayer;
using UserEntity;
using UserEntity.DTO;
using System.Linq.Expressions;

namespace UserDataAccess
{
    public class KisiDal : BaseRepository<Kisi, UserDBContext>, IKisiDal
    {
        private UserDBContext dBContext;
        public KisiDal(UserDBContext dBContext):base(dBContext)
        {
            this.dBContext = dBContext;
        }
        public List<KisiDTO> getAll()
        {
            var query = from k in dBContext.Set<Kisi>()
                        join i in dBContext.Set<Iletisim>()
                        on k.ILetisimRefId equals i.Id
                        select new KisiDTO
                        {
                            kisi = new Kisi
                            {
                                Id = k.Id,
                                Guid = k.Guid,
                                Firma = k.Firma,
                                Ad = k.Ad,
                                Soyad = k.Soyad,
                                ILetisimRefId = i.Id,

                            },
                            Iletisim = new Iletisim
                            {
                                Id = i.Id,
                                Email = i.Email,
                                Telefon = i.Telefon,
                                Enlem = i.Enlem,
                                Boylam = i.Boylam

                            }
                        };
            return query.ToList();
        }

        public KisiDTO getByid(int id)
        {
            var query = from k in dBContext.Set<Kisi>()
                        join i in dBContext.Set<Iletisim>()
                        on k.ILetisimRefId equals i.Id
                        where k.Id == id
                        select new KisiDTO
                        {
                            kisi = new Kisi
                            {
                                Id = k.Id,
                                Guid = k.Guid,
                                Firma = k.Firma,
                                Ad = k.Ad,
                                Soyad = k.Soyad,
                                ILetisimRefId = i.Id,

                            },
                            Iletisim = new Iletisim
                            {
                                Id = i.Id,
                                Email = i.Email,
                                Telefon = i.Telefon,
                                Enlem = i.Enlem,
                                Boylam = i.Boylam

                            }
                        };
            return query.FirstOrDefault();
        }
    }
}
