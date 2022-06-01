using RestApiModeloDDD.Domain.Core.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Infra.Data.Repositories
{
    internal class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}