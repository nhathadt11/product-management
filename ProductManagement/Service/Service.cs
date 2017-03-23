using ProductManagement.Repository;
using ProductManagement.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Service
{
    public abstract class Service<TEntity, TViewModel> 
        : IService<TEntity,TViewModel> where TViewModel : class
                                       where TEntity : class  
    {
        protected Repository<TEntity> NorthWindRepository;
        private Converter<TViewModel, TEntity> _entityConverter;
        private Converter<TEntity, TViewModel> _viewModelConverter;

        public Service(Converter<TViewModel, TEntity> entityConverter,
                       Converter<TEntity, TViewModel> viewModelConverter)
        {
            NorthWindRepository = new Repository<TEntity>(new NorthwindEntities());
            _entityConverter = entityConverter;
            _viewModelConverter = viewModelConverter;
        }

        public TViewModel Get(int id)
        {
            return _viewModelConverter(NorthWindRepository.Get(id));
        }

        public List<TViewModel> GetAll()
        {
            return Array.ConvertAll(NorthWindRepository.GetAll().ToArray(),
                                    _viewModelConverter).ToList();
        }

        public void Add(TViewModel entity)
        {
            NorthWindRepository.Add(_entityConverter(entity));
        }

        public void Remove(TViewModel entity)
        {
            NorthWindRepository.Remove(_entityConverter(entity));
        }

        public abstract void Update(TViewModel entity);
    }
}
