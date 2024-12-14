using PROJET_C__GESTIONRESTO.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.Usefull
{
    class PaginationContext<T>
    {
        public List<T> items = new List<T>();
        public int currentPage { get; set; } = 1;
        public int itemPerPage { get; set; } = 15;

        public int totalItems {  get; set; }
        public int TotalPages => (int) Math.Ceiling((double) (totalItems / itemPerPage));
        
        public PaginationContext(List<T> items, int currentPage, int totalItems, int itemPerPage = 15)
        {
            this.items = items;
            this.currentPage = currentPage;
            this.totalItems = totalItems;
            this.itemPerPage = itemPerPage;
        }
    }
}
