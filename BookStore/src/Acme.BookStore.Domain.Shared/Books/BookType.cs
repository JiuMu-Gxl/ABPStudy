/*****************************************************************************
*项目名称:Acme.BookStore.Books
*项目描述:
*类 名 称:BookType
*类 描 述:
*创 建 人:Chuanmingxie
*创建时间:2021/11/29 13:43:28
*修 改 人:
*修改时间:
*作用描述:<FUNCTION>
*Copyright @ Administrator 2021. All rights reserved
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Books
{
    public enum BookType
    {
        Undefined,  // 未定义
        Adventure,  // 冒险
        Biography,  // 传记
        Dystopia,   // 反乌托邦
        Fantastic,  // 奇幻
        Horror,     // 恐怖
        Science,    // 科学
        ScienceFiction, // 科幻
        Poetry      // 诗歌

    }
}
