using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Entity:IEntity
    {
        public virtual int Id { get; set; }
    }
}
