#pragma checksum "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33327f779f0c37766fb5b5aaa2a2b5b61ee62f9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_ServiceInjectionCalc), @"mvc.1.0.view", @"/Views/Calc/ServiceInjectionCalc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calc/ServiceInjectionCalc.cshtml", typeof(AspNetCore.Views_Calc_ServiceInjectionCalc))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33327f779f0c37766fb5b5aaa2a2b5b61ee62f9f", @"/Views/Calc/ServiceInjectionCalc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_ServiceInjectionCalc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
  
    ViewData["Title"] = "ServiceInjectionCalc";

#line default
#line hidden
            BeginContext(106, 52, true);
            WriteLiteral("\r\n<h2>ServiceInjectionCalc</h2>\r\n<div>First number: ");
            EndContext();
            BeginContext(159, 15, false);
#line 7 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
              Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(174, 28, true);
            WriteLiteral("</div>\r\n<div>Second number: ");
            EndContext();
            BeginContext(203, 16, false);
#line 8 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
               Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(219, 19, true);
            WriteLiteral("</div>\r\n<div>Plus: ");
            EndContext();
            BeginContext(239, 15, false);
#line 9 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
      Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(254, 3, true);
            WriteLiteral(" + ");
            EndContext();
            BeginContext(258, 16, false);
#line 9 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                         Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(274, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(278, 16, false);
#line 9 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                                             Write(Calculate.Plus());

#line default
#line hidden
            EndContext();
            BeginContext(294, 20, true);
            WriteLiteral("</div>\r\n<div>Minus: ");
            EndContext();
            BeginContext(315, 15, false);
#line 10 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
       Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(330, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(334, 16, false);
#line 10 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                          Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(350, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(354, 15, false);
#line 10 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                                              Write(Calculate.Min());

#line default
#line hidden
            EndContext();
            BeginContext(369, 23, true);
            WriteLiteral("</div>\r\n<div>Multiply: ");
            EndContext();
            BeginContext(393, 15, false);
#line 11 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
          Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(408, 3, true);
            WriteLiteral(" * ");
            EndContext();
            BeginContext(412, 16, false);
#line 11 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                             Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(428, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(432, 17, false);
#line 11 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                                                 Write(Calculate.Multi());

#line default
#line hidden
            EndContext();
            BeginContext(449, 29, true);
            WriteLiteral("</div>\r\n<div>\r\n    Division: ");
            EndContext();
            BeginContext(479, 15, false);
#line 13 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
         Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(494, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(498, 16, false);
#line 13 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                            Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(514, 3, true);
            WriteLiteral(" = ");
            EndContext();
#line 13 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                                                      if (Calculate.Div() == -1)
    {

#line default
#line hidden
            BeginContext(553, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(563, 8, true);
            WriteLiteral(" error\r\n");
            EndContext();
#line 16 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
    }
    else
    {
        

#line default
#line hidden
            BeginContext(604, 15, false);
#line 19 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
   Write(Calculate.Div());

#line default
#line hidden
            EndContext();
#line 19 "C:\Users\Настя\Documents\GitHub\Web\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                        
    }

#line default
#line hidden
            BeginContext(628, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public WebApplication1.Services.ICalc Calculate { get; private set; }
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
