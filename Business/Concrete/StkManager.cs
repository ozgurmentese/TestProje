using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class StkManager : IStkService
    {
        readonly IStkDal _stkDal;

        public StkManager(IStkDal stkDal)
        {
            _stkDal = stkDal;
        }

        public void Add(Stk stk)
        {
            _stkDal.Add(stk);
        }

        public void Delete(Stk stk)
        {
            _stkDal.Delete(stk);
        }

        public List<Stk> GetAll()
        {
            return _stkDal.GetAll();
        }

        public List<Stk> GetAllStk(string name)
        {
            return _stkDal.GetAll(s => s.MalAdi.ToLower().Contains(name.ToLower()));
        }

        public Stk GetById(int entityId)
        {
            return _stkDal.Get(e => e.Id == entityId);
        }

        public void Update(Stk stk)
        {
            _stkDal.Update(stk);
        }
    }
}
