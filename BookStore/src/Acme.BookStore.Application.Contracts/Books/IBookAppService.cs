using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    // 框架定义应用程序服务的接口不是必需的. 但是,它被建议作为最佳实践.

    // ICrudAppService定义了常见的CRUD方法:
    // GetAsync, GetListAsync, CreateAsync, UpdateAsync 和 DeleteAsync
    // ICrudAppService<TEntityDto, in TKey, in TGetListInput, in TCreateInput>
    public interface IBookAppService : ICrudAppService<    // 定义CRUD方法
            BookDto,    // 接口实体Dto
            Guid,   // 实体主键
            PagedAndSortedResultRequestDto, // 分页排序
            CreateUpdateBookDto // 创建或更新
        >
    {
        // 接口提供了基本的CRUD方法
        // 手动定义自己的方法
    }
}
