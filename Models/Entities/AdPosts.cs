using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DP_60321_TROSHKO.Models.Entities
{
    public  class AdPosts
    {
        [DataType(DataType.MultilineText)]
        [Display(Name = "Текст объявления")]
        public string Text { get; set; }
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int AdPostId { get; set; }
        [HiddenInput(DisplayValue = false)]
        public DateTime  Date { get; set; }
        [Display(Name = "Местоположение")]
        public string Town { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string Img { get; set; }
        [HiddenInput(DisplayValue = false)]
        public bool? Confirm { get; set; }
        [Display(Name = "Срок выполнения работ")]
        public DateTime? TimeOver { get; set; }
        [HiddenInput(DisplayValue = false)]
        public bool? IsActual { get; set; }
        [Display(Name = "Цена(руб.)")]
        public decimal Price { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string  ImgS { get; set; }
        [Required]
        [Display(Name = "Заголовок объявления")]
        public string Title { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string NameOfUser { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string RoleOfUser { get; set; }

        // Navigation properties
        [HiddenInput(DisplayValue = false)]
        public int AdRazdId { get; set; }
        public virtual AdRazds AdRazds { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int AdCategoryId { get; set; }
        public virtual AdCategories AdCategories { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required]
        public string UserId { get; set; }
        
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }


        public virtual List<Comments> Comments { get; set; }
        public virtual List<Offers> Offers { get; set; }
    }
}
