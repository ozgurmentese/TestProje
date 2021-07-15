using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStkService
    {
        void Add(Stk stk);
        void Update(Stk stk);
        void Delete(Stk stk);
        List<Stk> GetAll();
        Stk GetById(int stkId);
        List<Stk> GetAllStk(string name);
    }
}
