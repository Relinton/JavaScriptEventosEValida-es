#pragma checksum "D:\RelintonProjetos\JavaScript\JavaScript\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60487ef8b444a4cb024c5b5fe46cde3427497f27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "D:\RelintonProjetos\JavaScript\JavaScript\Views\_ViewImports.cshtml"
using JavaScript;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RelintonProjetos\JavaScript\JavaScript\Views\_ViewImports.cshtml"
using JavaScript.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60487ef8b444a4cb024c5b5fe46cde3427497f27", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b8a54e1c07ee81f0cbb2efa69aa29a5c879f8b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\RelintonProjetos\JavaScript\JavaScript\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    input, button, .resultado {
        width: 500px;
        height: 45px;
        margin: 10px;
        border-radius: 5px;
        outline: none;
        border: .5px solid #ddd;
        padding: 5px;
        box-sizing: border-box;
    }

    button {
        background-color: #00ec85;
        cursor: pointer;
    }

    .resultado {
        border: none;
    }
</style>

<input onkeyUp=""num(1)"" type=""text"" id=""v1"" />
<input onkeyup=""num(2)"" type=""text"" id=""v2"" />
<button
 onmouseover=""evMouse(1)""
 ondblclick=""evMouse(2)""
 onmouseout=""evMouse(3)""
 onblur=""evMouse(4)"">
 Calcular</button>

<div class=""resultado""></div>

<script>
    function num(a) {
        console.log(event.keyCode);

        var valor = document.getElementById(""v""+a).value;

        var res = document.getElementsByClassName(""resultado"")[0];
        res.innerHTML = valor;

        if(event.keyCode == 17)
        {
            res.innerHTML = ""Tecla <kbd>CTRL</kbd> pressionado.""
       ");
            WriteLiteral(@" }
    }

    function evMouse(e) {
        var v1 = parseFloat(document.getElementById('v1').value);
        var v2 = parseFloat(document.getElementById('v2').value);

        var res = document.getElementsByClassName('resultado')[0];

        switch(e) {
            case 1:
            res.innerHTML = v1 + v2;
            break;
            case 2:
            res.innerHTML = v1 - v2;
            break;
            case 3:
            res.innerHTML = v1/v2;
            break;
            case 4:
            res.innerHTML = v1 * v2;
            break;
            default:
            res.innerHTML = ""Operador não encontrado."";
        }
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
