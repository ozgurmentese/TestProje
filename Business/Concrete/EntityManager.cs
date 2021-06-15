using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class EntityManager : IEntityService
    {
        readonly IEntityDal _entityDal;

        public EntityManager(IEntityDal entityDal)
        {
            _entityDal = entityDal;
        }

        public IResult Add(Entity entity)
        {
            _entityDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Entity entity)
        {
            _entityDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Entity>> GetAll()
        {
            return new SuccessDataResult<List<Entity>>(_entityDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Entity> GetById(int entityId)
        {
            return new SuccessDataResult<Entity>(_entityDal.Get(e => e.Id == entityId));
        }

        public IResult Update(Entity entity)
        {
            _entityDal.Update(entity);
            return new SuccessResult(Messages.Updated);
        }
    }
}
