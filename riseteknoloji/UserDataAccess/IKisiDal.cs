using CoreLayer;
using UserEntity;
using UserEntity.DTO;

namespace UserDataAccess
{
    public interface IKisiDal: IBaseRepository<Kisi>
    {
        List<KisiDTO> getAll();
        KisiDTO getByid(int id);
    }
}
