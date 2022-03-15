using CoreLayer.Utilits.Result;
using UserEntity.DTO;

namespace UserBusiness
{
    public interface IKisiManager
    {
        IResult add(KisiDTO kisi);
        IResult update(KisiDTO kisi);
        IResult delete(int id);
        IDataResult<List<KisiDTO>> getAll();
        IDataResult<KisiDTO> getById( int id);
    }
}
