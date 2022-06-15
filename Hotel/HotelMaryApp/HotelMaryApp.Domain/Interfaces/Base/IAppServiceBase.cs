using HotelMaryApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMaryApp.Domain.Interfaces.Base
{
    public interface IAppServiceBase<TEntity> where TEntity : Entity
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        List<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

    }
}
