using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.Usefull
{
    static class QueryBuilderExtension
    {
        public static async Task<PaginationContext<object>> PaginedData(
            this IQueryable<object> query, // var permetre de construire une requete personnaliser pour le Dbset<>
            int pageIndex,
            int itemPerPage = 15,
            CancellationToken cancellationToken = default 
        )
        {
            int totalItems = await query.CountAsync(cancellationToken);

            var items = query
                .Skip((pageIndex - 1) * itemPerPage)
                .Take(itemPerPage)
                .ToListAsync()
                .Result;

            return new PaginationContext<object>(items, pageIndex, totalItems);
        }
    }
}
