using RestApiModeloDDD.Domain.Core.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Infra.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}