using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IBooksBusiness
    {
        BooksVO Create(BooksVO book);

        BooksVO FindById(long id);

        List<BooksVO> FindAll();

        BooksVO Update(BooksVO book);

        void Delete(long id);
    }
}
