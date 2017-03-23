using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Service
{
    interface IService<TEntity, TViewModel> where TEntity : class
                                            where TViewModel : class
    {
        void Add(TViewModel viewModel);
        void Update(TViewModel viewModel);
        void Remove(TViewModel viewModel);
        TViewModel Get(int id);
        List<TViewModel> GetAll();
    }
}
