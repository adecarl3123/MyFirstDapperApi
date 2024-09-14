using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//":" = implements
//Actions = Repository
//Connection is in the repository
//Model contains objects
//Services - to deliver request of user -> req of user to repo
// "=>" (Lambda expressions) read as "value of"

namespace MyFirstDapper.Repository
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class 
    {
        IDbConnection connection;
        readonly string connectionString = "Server=DESKTOP-R8ODHID; Database=MyFirstDapper; Trusted_Connection=True; MultipleActiveResultSets=true ";
        public GenericRepository() 
        {
            connection = new SqlConnection(connectionString);
        }

        public T GetbyId(int id)
        {
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Add(T Entity)
        {
            string tableName = GetTableName();
            string columns = GetColumnNames();
            string values = GetColumnValues();
            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";
            
            int affectedRow = 0 ;
            affectedRow = connection.Execute(query, Entity);
            return affectedRow == 1;
        }


        public bool Update(T Entity /*int id*/)
        {
            string tableName = GetTableName();
            string setClause = GetSetClause(Entity);  // Generate SET clause for update
            string query = $"UPDATE {tableName} SET {setClause} WHERE Id = @Id";

            int affectedRow = 0;
            affectedRow = connection.Execute(query, Entity);
            return affectedRow == 1;
        }

        // This method generates the SET clause for the UPDATE query
        private string GetSetClause(T entity)
        {
            var properties = typeof(T).GetProperties()
                .Where(p => p.Name != "Id"); // Exclude the 'Id' property from being updated

            var setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));
            return setClause;
        }

       
        public bool Delete(int id)
        {
            string tableName = GetTableName();
            string query = $"DELETE FROM {tableName} WHERE Id = @Id";

            int affectedRow = 0;
            affectedRow = connection.Execute(query, new { Id = id });
            return affectedRow == 1;
        }


        //public bool Delete(T Entity)
        //{
        //    throw new NotImplementedException();
        //}


        ////// getting the table, column, 
        public string GetTableName()
        {
            string tableName = "";
            var type= typeof(T);
            var tableAttr = type.GetCustomAttribute<TableAttribute>(); //dapat walang s
            if (tableAttr != null)
            {
                tableName = $"[{tableAttr.Name}]";
            }
            return tableName;
        }

        public string GetColumnNames(bool excludeKey = true)
        {
            //string columnNames = "";
            var type= typeof(T);
            var columns = string.Join(",", type.GetProperties()
                .Where(p => !excludeKey || !p.IsDefined(typeof(KeyAttribute)))
                .Select(p =>
                {
                    var columnAttr = p.GetCustomAttribute<ColumnAttribute>();
                    return columnAttr != null ? columnAttr.Name : p.Name;
                }));
            //return columnNames;
            return columns;
        }

       public string GetColumnValues(bool excludeKey = true)
        {

            var columnValues = typeof(T).GetProperties()
                .Where(p => !excludeKey || p.GetCustomAttribute<KeyAttribute>() == null);
            var values = string.Join(",", columnValues.Select(p =>
            {
                return $"@{p.Name}";
            }));
                   
            return values;
        }

        //public bool Update(T Entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
