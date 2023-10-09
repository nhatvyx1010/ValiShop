using MyShop.Models;

namespace MyShop.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaisp);
        TLoaiSp Update(TLoaiSp loaisp);
        TLoaiSp Delete(String maloaisp);
        TLoaiSp GetLoaiSp(String maloaisp);
        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
