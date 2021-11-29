/*****************************************************************************
*项目名称:Acme.BookStore.Books
*项目描述:
*类 名 称:Book
*类 描 述:
*创 建 人:Chuanmingxie
*创建时间:2021/11/29 13:38:39
*修 改 人:
*修改时间:
*作用描述:<FUNCTION>
*Copyright @ Administrator 2021. All rights reserved
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    public class Book : AuditedEntity<Guid>
    {
        /// <summary>
        /// 书籍名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 书籍类型
        /// </summary>
        public String Type { get; set; }
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
