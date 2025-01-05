using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.Usefull
{
    static class QueryBuilderExtension
    {
        public static PaginationContext<T> GetPaginedItems<T>(
            this IQueryable<T> query, // var permetre de construire une requete personnaliser pour le Dbset<>
            int pageIndex,
            int itemPerPage = 15,
            CancellationToken cancellationToken = default 
        )
        {
            int totalItems =  query.Count();
            var items = query
                .Skip((pageIndex - 1) * itemPerPage)
                .Take(itemPerPage)
                .ToList();

            return new PaginationContext<T>(items, pageIndex, totalItems);
        }
    }
}
