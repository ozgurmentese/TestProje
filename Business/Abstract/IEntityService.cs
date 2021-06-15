using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityService
    {
        IResult Add(Entity entity);
        IResult Update(Entity entity);
        IResult Delete(Entity entity);
        IDataResult<List<Entity>> GetAll();
        IDataResult<Entity> GetById(int entityId);
    }
}
