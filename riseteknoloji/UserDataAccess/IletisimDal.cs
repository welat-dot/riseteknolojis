using CoreLayer;
using UserEntity;

namespace UserDataAccess
{
    public class IletisimDal :BaseRepository<Iletisim, UserDBContext>,IIletisimDal
    {
        private UserDBContext dBContext;
        public IletisimDal(UserDBContext dBContext) : base(dBContext)
        {
            this.dBContext = dBContext;
        }
    }
}
