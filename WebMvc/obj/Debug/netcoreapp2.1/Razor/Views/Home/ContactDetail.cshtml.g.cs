#pragma checksum "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c50781f8db30044dd4b2fafe2618ab0533728f9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactDetail), @"mvc.1.0.view", @"/Views/Home/ContactDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactDetail.cshtml", typeof(AspNetCore.Views_Home_ContactDetail))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\_ViewImports.cshtml"
using WebMvc;

#line default
#line hidden
#line 2 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\_ViewImports.cshtml"
using WebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c50781f8db30044dd4b2fafe2618ab0533728f9e", @"/Views/Home/ContactDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82dfb9e8d9c1e15d2e9f7b4d3cf193b2b540299a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMvc.Models.ContactDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml"
  
        ViewData["Title"] = "Данные контакта " + Model.Item.Id;

#line default
#line hidden
            BeginContext(120, 20, true);
            WriteLiteral("<h2>Данные контакта ");
            EndContext();
            BeginContext(141, 13, false);
#line 6 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml"
               Write(Model.Item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(154, 137, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"EvenString\" border=\"1\" cellspacing=\"0\" cellpadding=\"5\" width=\"30%\">\r\n\r\n    <tr>\r\n        <th>ID</th>\r\n        <td>");
            EndContext();
            BeginContext(292, 13, false);
#line 12 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml"
       Write(Model.Item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(305, 66, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Фамилия</th>\r\n        <td>");
            EndContext();
            BeginContext(372, 21, false);
#line 16 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml"
       Write(Model.Item.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(393, 62, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Имя</th>\r\n        <td>");
            EndContext();
            BeginContext(456, 15, false);
#line 20 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml"
       Write(Model.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(471, 67, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Отчество</th>\r\n        <td>");
            EndContext();
            BeginContext(539, 18, false);
#line 24 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml"
       Write(Model.Item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(557, 66, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Телефон</th>\r\n        <td>");
            EndContext();
            BeginContext(624, 22, false);
#line 28 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml"
       Write(Model.Item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(646, 64, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Адрес</th>\r\n        <td>");
            EndContext();
            BeginContext(711, 18, false);
#line 32 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml"
       Write(Model.Item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(729, 67, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Описание</th>\r\n        <td>");
            EndContext();
            BeginContext(797, 22, false);
#line 36 "D:\Библиотека\skillbox\Обучение\1. C#\20. ASP.NET Core. Часть 1\homework-theme-20\WebMvc\Views\Home\ContactDetail.cshtml"
       Write(Model.Item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(819, 28, true);
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMvc.Models.ContactDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591