#pragma checksum "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9f6244ac4633960ac77992a618f1a7b345893c3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f6244ac4633960ac77992a618f1a7b345893c3", @"/Views/Home/pogoda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a50b5997869c81159c20d6a01017207dba93cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_pogoda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pogoda.Models.PogodaData>>
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
            BeginContext(46, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Pogoda";

#line default
#line hidden
            BeginContext(112, 25, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(137, 608, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9f6244ac4633960ac77992a618f1a7b345893c34769", async() => {
                BeginContext(143, 595, true);
                WriteLiteral(@"
    <title> Pogoda </title>
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
            BeginContext(745, 5, true);
            WriteLiteral(" \r\n\r\n");
            EndContext();
            BeginContext(750, 4965, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9f6244ac4633960ac77992a618f1a7b345893c36578", async() => {
                BeginContext(756, 293, true);
                WriteLiteral(@"

   
<div class=""container-fluid with-padding"">

    <div class=""row tlo"">
        <br>
    </div>

    <div class=""row tlo"">
        <div id=""pogoda_naa_dzis"" class=""col-xs-12 col-sm-10 col-md-10 col-lg-6 col-sm-offset-2 col-md-offset-2 col-lg-offset-3 margin_dashboard"">
        ");
                EndContext();
                BeginContext(1049, 1582, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9f6244ac4633960ac77992a618f1a7b345893c37264", async() => {
                    BeginContext(1119, 1505, true);
                    WriteLiteral(@"

            <div class=""form-group specjalna_czcionka"">
                <div class=""col-xs-12 text-center"">
                    <br><span class="""" ><h3>Pogoda na Dziś</h3></span><hr class=""style1""> <br><br>
                </div>
                <div class=""form-group "">
                        <label class=""col-xs-6 col-xs-offset-3"" id=""freeLabel"" for=""place""> Miejscowość </label>
                        <div  class=""col-xs-6 col-xs-offset-3""><input class=""form-control""  placeholder=""nazwa szukanej miejscowości"" value="""" id=""place"" name=""city.place"" type=""text"" maxlength=""120"">
                    </div>
                    <div class=""col-xs-2  col-xs-offset-0""><input class=""form-control""  placeholder=""country code"" value="""" id=""countryCode"" name=""city.countryCode"" type=""text"" maxlength=""20"">
                    </div>
    <!--
                        <div class=""checkbox checkbox-info"">
                            <input id=""chkTablet"" type=""checkbox"" checked="""">
                          ");
                    WriteLiteral(@"  <label id=""tabletLabel"" for=""chkTablet"">
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
                BeginContext(2631, 38, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 62 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
          int j = 0;

#line default
#line hidden
                BeginContext(2692, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 63 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
         if(Model != null) {

        
        

#line default
#line hidden
#line 66 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
         foreach (Pogoda.Models.PogodaData pd in Model)
        {
            

#line default
#line hidden
#line 68 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
             if(j++ == 0) 
            {

#line default
#line hidden
                BeginContext(2845, 359, true);
                WriteLiteral(@"               <div class=""row tlo"">
                    <div id=""current_weather"" class=""col-xs-12 col-sm-10 col-md-10 col-lg-6 col-sm-offset-2 col-md-offset-2 col-lg-offset-3 "">
                        <div class=""panel panel-pogoda col-xs-6 col-xs-offset-3"" id=""pogoda_na_dzis"">
                            <div class=""panel-heading-pogoda"" id=""miasto"">");
                EndContext();
                BeginContext(3205, 12, false);
#line 73 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                     Write(ViewBag.City);

#line default
#line hidden
                EndContext();
                BeginContext(3217, 111, true);
                WriteLiteral(" </div>\r\n                            <div class=\"panel-body text-center\">\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=", 3328, "", 3340, 1);
#line 75 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
WriteAttributeValue("", 3333, pd.img, 3333, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3340, 64, true);
                WriteLiteral(" alt=\"ASP.NET\" class=\"tlo\">\r\n                                <p>");
                EndContext();
                BeginContext(3405, 14, false);
#line 76 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                              Write(pd.mainWeather);

#line default
#line hidden
                EndContext();
                BeginContext(3419, 42, true);
                WriteLiteral("</p> \r\n                                <p>");
                EndContext();
                BeginContext(3462, 11, false);
#line 77 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                              Write(pd.temp_max);

#line default
#line hidden
                EndContext();
                BeginContext(3473, 47, true);
                WriteLiteral(" [°C]</p> \r\n                                <p>");
                EndContext();
                BeginContext(3521, 11, false);
#line 78 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                              Write(pd.temp_min);

#line default
#line hidden
                EndContext();
                BeginContext(3532, 47, true);
                WriteLiteral(" [°C]</p> \r\n                                <p>");
                EndContext();
                BeginContext(3580, 11, false);
#line 79 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                              Write(pd.pressure);

#line default
#line hidden
                EndContext();
                BeginContext(3591, 49, true);
                WriteLiteral(" [hPa]</p>  \r\n                                <p>");
                EndContext();
                BeginContext(3641, 11, false);
#line 80 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                              Write(pd.humidity);

#line default
#line hidden
                EndContext();
                BeginContext(3652, 61, true);
                WriteLiteral(" [%] </p>\r\n                                <p>wschód słońca: ");
                EndContext();
                BeginContext(3714, 31, false);
#line 81 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                             Write(pd.sunRise.ToString("HH:mm:ss"));

#line default
#line hidden
                EndContext();
                BeginContext(3745, 56, true);
                WriteLiteral("</p> \r\n                                <p>zachód słońca ");
                EndContext();
                BeginContext(3802, 30, false);
#line 82 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                            Write(pd.sunSet.ToString("HH:mm:ss"));

#line default
#line hidden
                EndContext();
                BeginContext(3832, 71, true);
                WriteLiteral("</p>                    \r\n                                <p>pomiar z: ");
                EndContext();
                BeginContext(3904, 7, false);
#line 83 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                        Write(pd.czas);

#line default
#line hidden
                EndContext();
                BeginContext(3911, 126, true);
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 88 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
            }

#line default
#line hidden
#line 88 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
             
        }

#line default
#line hidden
                BeginContext(4065, 507, true);
                WriteLiteral(@"        <div id=""prognoza"" class=""col-xs-12 col-sm-10 col-md-10 col-lg-6 col-sm-offset-2 col-md-offset-2 col-lg-offset-3 margin_dashboard "">
                
            <table id=""prog_tab"">
                <tr>
                    <th colspan=""6"">
                        <h3>PROGNOZA</h3>
                    </th>
                </tr>
                <tr><th>pogoda</th><th>godzina</th><th>temp. max [°C]</th><th>temp. min [°C]</th><th>ciśnienie</th><th>wilgotność</th></tr>
                
");
                EndContext();
#line 101 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                      int i = 0;

#line default
#line hidden
                BeginContext(4607, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 102 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                     foreach (Pogoda.Models.PogodaData pd in Model)
                    {
                        

#line default
#line hidden
#line 104 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                         if(i++ != 0) 
                        {

#line default
#line hidden
                BeginContext(4766, 40, true);
                WriteLiteral("                            <tr><td><img");
                EndContext();
                BeginWriteAttribute("src", " src=", 4806, "", 4818, 1);
#line 106 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
WriteAttributeValue("", 4811, pd.img, 4811, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4818, 24, true);
                WriteLiteral(" alt=\"ASP.NET\"></td><td>");
                EndContext();
                BeginContext(4843, 25, false);
#line 106 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                       Write(pd.czas.ToString("HH:mm"));

#line default
#line hidden
                EndContext();
                BeginContext(4868, 9, true);
                WriteLiteral("</td><td>");
                EndContext();
                BeginContext(4878, 11, false);
#line 106 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                                                          Write(pd.temp_max);

#line default
#line hidden
                EndContext();
                BeginContext(4889, 9, true);
                WriteLiteral("</td><td>");
                EndContext();
                BeginContext(4899, 11, false);
#line 106 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                                                                               Write(pd.temp_min);

#line default
#line hidden
                EndContext();
                BeginContext(4910, 9, true);
                WriteLiteral("</td><td>");
                EndContext();
                BeginContext(4920, 11, false);
#line 106 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                                                                                                    Write(pd.pressure);

#line default
#line hidden
                EndContext();
                BeginContext(4931, 9, true);
                WriteLiteral("</td><td>");
                EndContext();
                BeginContext(4941, 11, false);
#line 106 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                                                                                                                                                                         Write(pd.humidity);

#line default
#line hidden
                EndContext();
                BeginContext(4952, 12, true);
                WriteLiteral("</td></tr>\r\n");
                EndContext();
#line 107 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                        }

#line default
#line hidden
#line 107 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(5014, 535, true);
                WriteLiteral(@"               
<!--                
                <tr><td><img src=""~/img/snieg.png"" alt=""ASP.NET""></td><td>12:00</td><td>3</td><td>0</td><td>1020</td><td>80%</td></tr>
                <tr><td><img src=""~/img/deszcz.png"" alt=""ASP.NET""></td><td>15:00</td><td>1</td><td>3</td><td>1021</td><td>80%</td></tr>
                <tr><td><img src=""~/img/zachmurzenie_lekkie.png"" alt=""ASP.NET""></td><td>18:00</td><td>2</td><td>0</td><td>1020</td><td>80%</td></tr>
-->                
            
            </table>
        </div>
");
                EndContext();
#line 118 "c:\Users\Mirek\Pogoda\Views\Home\pogoda.cshtml"
    }

#line default
#line hidden
                BeginContext(5556, 152, true);
                WriteLiteral("    <footer class=\"footer navbar navbar-fixed-bottom text-center footer\">\r\n        <p>Autor projektu: Kuba Ogonowski.</p>\r\n    </footer>\r\n\r\n    </div>\r\n");
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
            BeginContext(5715, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pogoda.Models.PogodaData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
