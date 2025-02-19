﻿
using Core.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
   public interface IEntityRepository<TEntity> where TEntity : class ,IEntity , new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter=null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        
        


    }
}
