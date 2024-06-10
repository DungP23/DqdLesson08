using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DqdLesson8.Models
{
    /// <summary>
    /// Tao cau truc bang du lieu
    /// </summary>
    public class DqdCategory
    {
        [Key]
        public int DqdCategorId { get; set; }
        public string DqdCategoryName { get; set; }


        //Thuoc tinh quan he
        public virtual ICollection<DqdBook> DqdBooks { get; set; }
    }
}