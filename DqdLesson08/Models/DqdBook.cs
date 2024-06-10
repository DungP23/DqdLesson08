using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DqdLesson8.Models
{
    /// <summary>
    /// Tao ra cau truc bang Book
    /// </summary>
    public class DqdBook
    {
        [Key]
        public int DqdBookId { get; set; }
        public string DqdTitle { get; set; }
        public string DqdAuthor { get; set; }
        public int DqdYear { get; set; }
        public string DqdPublisher { get; set; }
        public string DqdPicture { get; set; }
        public int DqdCategoryId { get; set; }

        // Thuoc tinh quan he
        public virtual DqdCategory DqdCategory { get; set; }
    }
}