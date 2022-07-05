using HotelJuanApp.Domain.Entity;
using System.Collections.Generic;

namespace HotelJuanApp.Domain.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : EntityDom
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        List<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);
    }
}
