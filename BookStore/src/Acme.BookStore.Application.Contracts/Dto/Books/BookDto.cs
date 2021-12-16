using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    public class BookDto : FullAuditedEntityDto<Guid>
    {
        /// <summary>
        /// 书籍名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 书籍类型
        /// </summary>
        public BookType Type { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishDate { get; set; }
        /// <summary>
        /// 书籍价格
        /// </summary>
        public float Price { get; set; }
    }
}
