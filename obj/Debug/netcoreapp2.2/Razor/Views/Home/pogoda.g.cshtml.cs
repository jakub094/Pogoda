#pragma checksum "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e757cde448e53366e325a7401adadf0f97c722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_pogoda), @"mvc.1.0.view", @"/Views/Home/pogoda.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/pogoda.cshtml", typeof(AspNetCore.Views_Home_pogoda))]
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
#line 1 "c:\Users\Mirek\Pogoda\Views\_ViewImports.cshtml"
using Pogoda;

#line default
#line hidden
#line 2 "c:\Users\Mirek\Pogoda\Views\_ViewImports.cshtml"
using Pogoda.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51e757cde448e53366e325a7401adadf0f97c722", @"/Views/Home/pogoda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a50b5997869c81159c20d6a01017207dba93cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_pogoda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal jasne"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "pogoda", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(1, 5, false);
#line 1 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(6, 44, true);
            WriteLiteral(" IEnumerable<Pogoda.Models.PogodaData>\r\n\r\n\r\n");
            EndContext();
#line 4 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Pogoda";

#line default
#line hidden
            BeginContext(112, 25, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(137, 626, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51e757cde448e53366e325a7401adadf0f97c7224952", async() => {
                BeginContext(143, 14, true);
                WriteLiteral("\r\n    <title> ");
                EndContext();
                BeginContext(158, 16, false);
#line 11 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
       Write(ViewBag.Greeting);

#line default
#line hidden
                EndContext();
                BeginContext(174, 582, true);
                WriteLiteral(@" Pogoda </title>
    <meta charset = ""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <link rel=""stylesheet"" type=""text/css"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">
    <link rel = ""stylesheet"" type=""text/css"" href = ""/css/fap.css"" runat=""server"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(763, 5, true);
            WriteLiteral(" \r\n\r\n");
            EndContext();
            BeginContext(768, 4574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51e757cde448e53366e325a7401adadf0f97c7227077", async() => {
                BeginContext(774, 358, true);
                WriteLiteral(@"

   
<div class=""container-fluid with-padding"">

    <div class=""row tlo"">
        <h1 class=""text-center"" > AUTOR: Mirosław Kowalski</h1>
        <br>
    </div>

    <div class=""row tlo"">
        <div id=""pogoda_naa_dzis"" class=""col-xs-12 col-sm-10 col-md-10 col-lg-6 col-sm-offset-2 col-md-offset-2 col-lg-offset-3 margin_dashboard"">
        ");
                EndContext();
                BeginContext(1132, 1581, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51e757cde448e53366e325a7401adadf0f97c7227830", async() => {
                    BeginContext(1202, 1504, true);
                    WriteLiteral(@"

            <div class=""form-group specjalna_czcionka"">
                <div class=""col-xs-12 text-center"">
                    <br><span class="""" ><h3>Pogoda na Dziś</h3></span><hr class=""style1""> <br><br>
                </div>
                <div class=""form-group "">
                        <label class=""col-xs-6 col-xs-offset-3"" id=""freeLabel"" for=""place""> Miejscowość </label>
                        <div  class=""col-xs-6 col-xs-offset-3""><input class=""form-control""  placeholder=""nazwa szukanej miejscowości"" value="""" id=""place"" name=""city.place"" type=""text"" maxlength=""120"">
                    </div>
                    <div class=""col-xs-2  col-xs-offset-0""><input class=""form-control""  placeholder=""country code"" value="""" id=""countrzcode"" name""city.countryCode"" type=""text"" maxlength=""20"">
                    </div>
    <!--
                        <div class=""checkbox checkbox-info"">
                            <input id=""chkTablet"" type=""checkbox"" checked="""">
                           ");
                    WriteLiteral(@" <label id=""tabletLabel"" for=""chkTablet"">
                                Tablet
                            </label>
                        </div>
    -->
                    <div class=""col-xs-9 col-xs-offset-10 "">
                        <br>
                        <button class=""btn btn-logi"" data-loading-text=""Szuka..."" value=""Szukaj"" id=""btSearch"" type=""submit"">Szukaj</button>
                    </div>
                </div>
            </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2713, 38, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 63 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
         if(Model != null) {

#line default
#line hidden
                BeginContext(2781, 328, true);
                WriteLiteral(@"        <div class=""row tlo"">
            <div id=""current_weather"" class=""col-xs-12 col-sm-10 col-md-10 col-lg-6 col-sm-offset-2 col-md-offset-2 col-lg-offset-3 "">
                <div class=""panel panel-pogoda col-xs-6 col-xs-offset-3"" id=""pogoda_na_dzis"">
                    <div class=""panel-heading-pogoda"" id=""miasto"">");
                EndContext();
                BeginContext(3110, 12, false);
#line 67 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                             Write(ViewBag.City);

#line default
#line hidden
                EndContext();
                BeginContext(3122, 95, true);
                WriteLiteral(" </div>\r\n                    <div class=\"panel-body text-center\">\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=", 3217, "", 3235, 1);
#line 69 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
WriteAttributeValue("", 3222, Model[0].img, 3222, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3235, 56, true);
                WriteLiteral(" alt=\"ASP.NET\" class=\"tlo\">\r\n                        <p>");
                EndContext();
                BeginContext(3292, 20, false);
#line 70 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                      Write(Model[0].mainWeather);

#line default
#line hidden
                EndContext();
                BeginContext(3312, 34, true);
                WriteLiteral("</p> \r\n                        <p>");
                EndContext();
                BeginContext(3347, 17, false);
#line 71 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                      Write(Model[0].temp_max);

#line default
#line hidden
                EndContext();
                BeginContext(3364, 39, true);
                WriteLiteral(" [°C]</p> \r\n                        <p>");
                EndContext();
                BeginContext(3404, 17, false);
#line 72 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                      Write(Model[0].temp_min);

#line default
#line hidden
                EndContext();
                BeginContext(3421, 39, true);
                WriteLiteral(" [°C]</p> \r\n                        <p>");
                EndContext();
                BeginContext(3461, 17, false);
#line 73 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                      Write(Model[0].pressure);

#line default
#line hidden
                EndContext();
                BeginContext(3478, 41, true);
                WriteLiteral(" [hPa]</p>  \r\n                        <p>");
                EndContext();
                BeginContext(3520, 17, false);
#line 74 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                      Write(Model[0].humidity);

#line default
#line hidden
                EndContext();
                BeginContext(3537, 53, true);
                WriteLiteral(" [%] </p>\r\n                        <p>wschód słońca: ");
                EndContext();
                BeginContext(3591, 37, false);
#line 75 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                     Write(Model[0].sunRise.ToString("HH:mm:ss"));

#line default
#line hidden
                EndContext();
                BeginContext(3628, 48, true);
                WriteLiteral("</p> \r\n                        <p>zachód słońca ");
                EndContext();
                BeginContext(3677, 36, false);
#line 76 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                    Write(Model[0].sunSet.ToString("HH:mm:ss"));

#line default
#line hidden
                EndContext();
                BeginContext(3713, 63, true);
                WriteLiteral("</p>                    \r\n                        <p>pomiar z: ");
                EndContext();
                BeginContext(3777, 13, false);
#line 77 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                Write(Model[0].czas);

#line default
#line hidden
                EndContext();
                BeginContext(3790, 94, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
                BeginContext(3886, 497, true);
                WriteLiteral(@"        <div id=""prognoza"" class=""col-xs-12 col-sm-10 col-md-10 col-lg-6 col-sm-offset-2 col-md-offset-2 col-lg-offset-3 margin_dashboard "">
                
            <table id=""prog_tab"">
                <tr>
                    <th colspan=""6"">
                        <h3>PROGNOZA</h3>
                    </th>
                </tr>
                <tr><th>pogoda</th><th>godzina</th><th>temp. max</th><th>temp. min</th><th>ciśnienie</th><th>wilgotność</th></tr>
                
");
                EndContext();
#line 93 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                     foreach (Pogoda.Models.PogodaData pd in Model)
                    {
                        

#line default
#line hidden
#line 95 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                         if(pd != @Model[0]) {

#line default
#line hidden
                BeginContext(4523, 40, true);
                WriteLiteral("                            <tr><td><img");
                EndContext();
                BeginWriteAttribute("src", " src=", 4563, "", 4575, 1);
#line 96 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
WriteAttributeValue("", 4568, pd.img, 4568, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4575, 24, true);
                WriteLiteral(" alt=\"ASP.NET\"></td><td>");
                EndContext();
                BeginContext(4600, 25, false);
#line 96 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                       Write(pd.czas.ToString("HH:mm"));

#line default
#line hidden
                EndContext();
                BeginContext(4625, 9, true);
                WriteLiteral("</td><td>");
                EndContext();
                BeginContext(4635, 11, false);
#line 96 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                                                          Write(pd.temp_min);

#line default
#line hidden
                EndContext();
                BeginContext(4646, 9, true);
                WriteLiteral("</td><td>");
                EndContext();
                BeginContext(4656, 11, false);
#line 96 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                                                                               Write(pd.temp_max);

#line default
#line hidden
                EndContext();
                BeginContext(4667, 9, true);
                WriteLiteral("</td><td>");
                EndContext();
                BeginContext(4677, 11, false);
#line 96 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                                                                                                    Write(pd.pressure);

#line default
#line hidden
                EndContext();
                BeginContext(4688, 9, true);
                WriteLiteral("</td><td>");
                EndContext();
                BeginContext(4698, 11, false);
#line 96 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                                                                                                                         Write(pd.humidity);

#line default
#line hidden
                EndContext();
                BeginContext(4709, 12, true);
                WriteLiteral("</td></tr>\r\n");
                EndContext();
#line 97 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                          }

#line default
#line hidden
#line 97 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                           
                    }

#line default
#line hidden
                BeginContext(4773, 537, true);
                WriteLiteral(@"                }
<!--                
                <tr><td><img src=""~/img/snieg.png"" alt=""ASP.NET""></td><td>12:00</td><td>3</td><td>0</td><td>1020</td><td>80%</td></tr>
                <tr><td><img src=""~/img/deszcz.png"" alt=""ASP.NET""></td><td>15:00</td><td>1</td><td>3</td><td>1021</td><td>80%</td></tr>
                <tr><td><img src=""~/img/zachmurzenie_lekkie.png"" alt=""ASP.NET""></td><td>18:00</td><td>2</td><td>0</td><td>1020</td><td>80%</td></tr>
-->                
            
            </table>
        </div>
");
                EndContext();
#line 108 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
}

#line default
#line hidden
                BeginContext(5313, 22, true);
                WriteLiteral("        \r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5342, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
