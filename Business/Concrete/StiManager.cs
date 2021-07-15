using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class StiManager : IStiService
    {
        readonly IStiDal _stiDal;

        public StiManager(IStiDal stiDal)
        {
            _stiDal = stiDal;
        }

        public void Add(Sti sti)
        {
            _stiDal.Add(sti);
        }

        public void Delete(Sti sti)
        {
            _stiDal.Delete(sti);
        }

        public List<Sti> GetAll()
        {
            return _stiDal.GetAll();
        }

        public List<Sti> GetAll(int min, int max)
        {
            return _stiDal.GetAll(s => s.Tarih > min && s.Tarih < max);
        }

        public Sti GetById(int stiId)
        {
            return _stiDal.Get(e => e.Id == stiId);
        }

        public List<StiJoinStk> GetTarih(int min, int max)
        {
            return _stiDal.GetStiJoinStks(s => s.Tarih > min && s.Tarih < max);
        }

        public List<StiJoinStk> StiJoinStks()
        {
            var result = _stiDal.GetStiJoinStks();
            return result;
        }

        public List<StiJoinStk> StiJoinStks(string name)
        {
            var result = _stiDal.GetStiJoinStks(s => s.EvrakNo.ToLower().Contains(name.ToLower()));
            return result;
        }

        public void Update(Sti sti)
        {
            _stiDal.Update(sti);
        }
    }
}
