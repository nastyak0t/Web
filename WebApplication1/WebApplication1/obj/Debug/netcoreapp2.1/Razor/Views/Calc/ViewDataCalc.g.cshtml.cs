#pragma checksum "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60fedec147db401fa92fc1c0b4ae3526644bdd7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_ViewDataCalc), @"mvc.1.0.view", @"/Views/Calc/ViewDataCalc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calc/ViewDataCalc.cshtml", typeof(AspNetCore.Views_Calc_ViewDataCalc))]
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
#line 1 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fedec147db401fa92fc1c0b4ae3526644bdd7b", @"/Views/Calc/ViewDataCalc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_ViewDataCalc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
  
    ViewData["Title"] = "ViewDataCalc";
    var data = ViewData["data"] as WebApplication1.Models.MyModel;


#line default
#line hidden
            BeginContext(120, 44, true);
            WriteLiteral("\r\n<h2>ViewDataCalc</h2>\r\n<div>First number: ");
            EndContext();
            BeginContext(165, 10, false);
#line 9 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
              Write(data.first);

#line default
#line hidden
            EndContext();
            BeginContext(175, 28, true);
            WriteLiteral("</div>\r\n<div>Second number: ");
            EndContext();
            BeginContext(204, 11, false);
#line 10 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
               Write(data.second);

#line default
#line hidden
            EndContext();
            BeginContext(215, 19, true);
            WriteLiteral("</div>\r\n<div>Plus: ");
            EndContext();
            BeginContext(235, 10, false);
#line 11 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
      Write(data.first);

#line default
#line hidden
            EndContext();
            BeginContext(245, 3, true);
            WriteLiteral(" + ");
            EndContext();
            BeginContext(249, 11, false);
#line 11 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
                    Write(data.second);

#line default
#line hidden
            EndContext();
            BeginContext(260, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(264, 12, false);
#line 11 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
                                   Write(data.resPlus);

#line default
#line hidden
            EndContext();
            BeginContext(276, 20, true);
            WriteLiteral("</div>\r\n<div>Minus: ");
            EndContext();
            BeginContext(297, 10, false);
#line 12 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
       Write(data.first);

#line default
#line hidden
            EndContext();
            BeginContext(307, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(311, 11, false);
#line 12 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
                     Write(data.second);

#line default
#line hidden
            EndContext();
            BeginContext(322, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(326, 11, false);
#line 12 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
                                    Write(data.resMin);

#line default
#line hidden
            EndContext();
            BeginContext(337, 23, true);
            WriteLiteral("</div>\r\n<div>Multiply: ");
            EndContext();
            BeginContext(361, 10, false);
#line 13 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
          Write(data.first);

#line default
#line hidden
            EndContext();
            BeginContext(371, 3, true);
            WriteLiteral(" * ");
            EndContext();
            BeginContext(375, 11, false);
#line 13 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
                        Write(data.second);

#line default
#line hidden
            EndContext();
            BeginContext(386, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(390, 13, false);
#line 13 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
                                       Write(data.resMulti);

#line default
#line hidden
            EndContext();
            BeginContext(403, 29, true);
            WriteLiteral("</div>\r\n<div>\r\n    Division: ");
            EndContext();
            BeginContext(433, 10, false);
#line 15 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
         Write(data.first);

#line default
#line hidden
            EndContext();
            BeginContext(443, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(447, 11, false);
#line 15 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
                       Write(data.second);

#line default
#line hidden
            EndContext();
            BeginContext(458, 3, true);
            WriteLiteral(" = ");
            EndContext();
#line 15 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
                                            if (data.resDiv == -1)
    {

#line default
#line hidden
            BeginContext(493, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(503, 8, true);
            WriteLiteral(" error\r\n");
            EndContext();
#line 18 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
    }
    else
    {
        

#line default
#line hidden
            BeginContext(544, 11, false);
#line 21 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
   Write(data.resDiv);

#line default
#line hidden
            EndContext();
#line 21 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ViewDataCalc.cshtml"
                    
    }

#line default
#line hidden
            BeginContext(564, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
