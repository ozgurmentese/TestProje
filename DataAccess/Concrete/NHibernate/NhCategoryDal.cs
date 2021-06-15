﻿using Core.DataAccess.NHibernate;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.NHibernate
{
    public class NhEntityDal : NhEntityRepositoryBase<Entity>,IEntityDal
    {
        public NhEntityDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
