using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Repository
{
    public interface IGenericRepository<T> where T : class 
    {
        T GetbyId (int id);
        IEnumerable<T> GetAll();
        bool Add (T Entity);
        bool Update( T Entity);
        //bool Delete (T Entity);
        bool Delete(int id);
    }


}
