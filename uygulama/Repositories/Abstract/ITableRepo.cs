using System.Linq.Expressions;
using uygulama.Entities;

namespace uygulama.Repositories.Abstract
{
    public interface ITableRepo
    {
        Table GetTableByID(int id);
        List<Table> GetTumTableler();
        List<Table> GetDefaultTumTableler(Expression<Func<Table, bool>> exp); 
        bool AddTable(Table table);
        bool UpdateTable(Table table);
        bool DeleteTable(int id);
        int SaveTable();
    }
}
