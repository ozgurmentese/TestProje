
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStiService
    {
        void Add(Sti sti);
        void Update(Sti sti);
        void Delete(Sti sti);
        List<Sti> GetAll();
        List<Sti> GetAll(int min, int max);
        Sti GetById(int stiId);
        List<StiJoinStk> StiJoinStks();
        List<StiJoinStk> StiJoinStks(string name);
        List<StiJoinStk> GetTarih(int min, int max);
    }
}
