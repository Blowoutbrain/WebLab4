using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApplication1.DAL.Entities
{
    public class DishGroup
    {
        public int DishGroupId { get; set; }
        public string GroupName { get; set; }

        /// Навигационное свойство 1-ко-многим
        public List<Dish> Dishes { get; set; }
    }

}
