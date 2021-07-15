using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Dtos;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IStiDal : IEntityRepository<Sti>
    {
        List<StiJoinStk> GetStiJoinStks(Expression<Func<StiJoinStk, bool>> filter = null);
    } 
}
