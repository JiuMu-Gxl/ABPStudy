using Acme.BookStore.Books;
using AutoMapper;

namespace Acme.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            /* 你可以在这里配置你的 AutoMapper 映射配置。
             * 另外，你可以把你的映射配置分成多个配置文件类，以便更好地组织。 */
            // 配置映射 CreateMap<源, 映射类型>();
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
