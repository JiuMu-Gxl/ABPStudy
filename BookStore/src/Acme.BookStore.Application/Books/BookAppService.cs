using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    // BookAppService继承了CrudAppService<...>，自动实现了ICrudAppService定义的CRUD方法
    public class BookAppService : CrudAppService<
        Book,   // 实体
        BookDto,    // 实体Dto
        Guid,   // 实体主键类型
        PagedAndSortedResultRequestDto, // 分类排序实体
        CreateUpdateBookDto //新增修改实体
    >, IBookAppService  // 实现IBookAppService接口
    {
        // 注入 IRepository<实体仓库, 实体主键类型>
        private readonly IRepository<Book, Guid> _book;

        // 构造函数
        public BookAppService(IRepository<Book, Guid> book) : base(book)
        {
            _book = book;
        }
    }
}
