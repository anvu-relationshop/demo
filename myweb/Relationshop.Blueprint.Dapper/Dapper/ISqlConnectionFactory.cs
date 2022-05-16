using System.Data;

namespace Relationshop.Blueprint.Dapper.Dapper
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();

        IDbConnection GetNewConnection();
    }
}
