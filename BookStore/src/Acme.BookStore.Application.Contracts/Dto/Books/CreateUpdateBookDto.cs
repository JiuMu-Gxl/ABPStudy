using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Books
{
    public class CreateUpdateBookDto
    {
        // [Required]数据注释属性
        // DTO由ABP框架自动验证 https://docs.abp.io/zh-Hans/abp/latest/Validation
        [Required]
        [StringLength(128)]
        public String Name { get; set; }
        [Required]
        public BookType Type { get; set; } = BookType.Undefined;
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;
        [Required]
        public float Price { get; set; }
    }
}
