#pragma checksum "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e1542bba1107110276273d55abac9f3184396f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(client.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\_ViewImports.cshtml"
using client;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1542bba1107110276273d55abac9f3184396f4", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5051b91471b1d705bd2e544651cc91b7183e98c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1542bba1107110276273d55abac9f3184396f43406", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Lets take a look at the weather!</p>
    <h1 class=""display-4"">Today's weather</h1>
    <canvas id=""myChart"" width=""400"" height=""400""></canvas>
</div>

<table class=""table table-sm"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 21 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WeatherforecastList[0].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WeatherforecastList[0].TemperatureC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WeatherforecastList[0].Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml"
         foreach (var item in Model.WeatherforecastList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TemperatureC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "D:\Repos Visual Studio\ChartJSDemo\ChartsDemo\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""container"">
    <canvas id=""weatherChart"" width=""500"" height=""300""></canvas>
</div>

<script>

    /////////
    var myAmounts = [];
    var myCategories = [];
    var myWeather;

    function showChart() {
        myAmounts = myWeather.amountList;
        myCategories = myWeather.categoryList;
        console.log(myWeather);
        console.log(myAmounts);
        console.log(myCategories);
        let popCanvasName = document.getElementById(""weatherChart"");
        let weatherChart = new Chart(popCanvasName, {
            type: 'bar',
            data: {
                labels: myCategories,
                datasets: [{
                    label: 'Weather data',
                    data: myAmounts,
                    backgroundColor: getRandomColorEachData(myCategories.length),
                }]
            },
            options: {
                responsive: false,
                scales: {
                    yAxes: [{
              ");
            WriteLiteral(@"          ticks: {
                            beginAtZero: true
                        }
                    }]
                }
            }
        });
    }
    function getChartData() {
        return fetch('./Index?handler=WeatherforecastChartData',
            {
                method: 'get',
                headers: {
                    'Content-Type': 'application/json;charset=UTF-8'
                }
            })
            .then(function (response) {
                if (response.ok) {
                    return response.text();
                } else {
                    throw Error('Response Not OK');
                }
            })
            .then(function (text) {
                try {
                    return JSON.parse(text);
                } catch (err) {
                    throw Error('Method Not Found');
                }
            })
            .then(function (responseJSON) {
                myWeather = responseJSON;
                showCha");
            WriteLiteral(@"rt();
            })
    }

    var getRandomColor = function() {
    var r = Math.floor(Math.random() * 255);
    var g = Math.floor(Math.random() * 255);
    var b = Math.floor(Math.random() * 255);
    return ""rgb("" + r + "","" + g + "","" + b + "")"";
    }

    function getRandomColorEachData(count) {
    var data =[];
    for (var i = 0; i < count; i++) {
        data.push(getRandomColor());
    }
    return data;
}
    getChartData();
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChartsDemo.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChartsDemo.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChartsDemo.Pages.IndexModel>)PageContext?.ViewData;
        public ChartsDemo.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
