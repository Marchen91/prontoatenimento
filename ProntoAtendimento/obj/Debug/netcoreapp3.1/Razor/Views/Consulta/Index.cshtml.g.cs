#pragma checksum "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccb3bbd334894d6e36fd9a301e445d4a750b48b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consulta_Index), @"mvc.1.0.view", @"/Views/Consulta/Index.cshtml")]
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
#line 1 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\_ViewImports.cshtml"
using ProntoAtendimento;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\_ViewImports.cshtml"
using ProntoAtendimento.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb3bbd334894d6e36fd9a301e445d4a750b48b7", @"/Views/Consulta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d313c4711937bce2a3a1d4ae06100f96a9639af", @"/Views/_ViewImports.cshtml")]
    public class Views_Consulta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Consulta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid mt-100 "">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <h5>Consultas</h5>
                </div>
                <div class=""card-body cart"">
                    <div class=""col-sm-12 empty-cart-cls text-center"">
                        <h3><strong>Nenhuma Consulta aberta.</strong></h3>
                        
                        <a href=""/home/editar"" class=""btn btn-danger m-3"" data-abc=""true"">Voltar</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div> ");
#nullable restore
#line 22 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
       }
            else
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 29 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
                 if (@Model == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 31 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> ");
#nullable restore
#line 31 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
                           }
                else
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <h5>Lista de Consultas</h5>
<table class=""table table-hover rounded-top rounded-bottom shadow"" style=""background-color:transparent"">
    <tr>
        <th>Nr</th>
        <th>Paciente</th>
        <th>M??dico(a)</th>
        <th>Data</th>
        <th>Situa????o</th>
    </tr>

");
#nullable restore
#line 45 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
     foreach (var consulta in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 48 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
   Write(consulta.Nr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 49 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
   Write(consulta.Paciente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 50 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
   Write(consulta.Medico.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 51 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
   Write(consulta.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 52 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
   Write(consulta.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    \n</tr>");
#nullable restore
#line 55 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
#nullable restore
#line 56 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"/home/inicial\" class=\"btn btn-primary\" data-abc=\"true\">Voltar</a> ");
#nullable restore
#line 57 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Index.cshtml"
                                                                                                           }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Consulta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
