#pragma checksum "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d89c37f8c0a5c5e5a9a963dcfb26e13f2405da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consulta_RelatorioMedico), @"mvc.1.0.view", @"/Views/Consulta/RelatorioMedico.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d89c37f8c0a5c5e5a9a963dcfb26e13f2405da", @"/Views/Consulta/RelatorioMedico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d313c4711937bce2a3a1d4ae06100f96a9639af", @"/Views/_ViewImports.cshtml")]
    public class Views_Consulta_RelatorioMedico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Medico>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<br />\n\n");
#nullable restore
#line 5 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
 if (@Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 7 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> ");
#nullable restore
#line 7 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
                           }
            else
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>Selecione o M??dico: </h5>\n");
#nullable restore
#line 12 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
                // <h3>@ViewBag.Mensagem @Model.Nome</h3>

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-hover rounded-top rounded-bottom shadow\">\n    <tr>\n        <th>ID</th>\n        <th>Nome</th>\n        <th>Endere??o</th>\n        <th>Telefone</th>\n        <th>Status</th>\n\n    </tr>\n\n");
#nullable restore
#line 23 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
     foreach (var medic in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 26 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
   Write(medic.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 27 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
   Write(medic.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 28 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
   Write(medic.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 29 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
   Write(medic.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 30 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
   Write(medic.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    <td>\n\n        <a class=\"btn btn-sm btn-info\"");
            BeginWriteAttribute("href", " href=\"", 639, "\"", 675, 2);
            WriteAttributeValue("", 646, "/consulta/relatorio/", 646, 20, true);
#nullable restore
#line 34 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
WriteAttributeValue("", 666, medic.Id, 666, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Selecionar</a>\n\n    </td>\n</tr>");
#nullable restore
#line 37 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
#nullable restore
#line 38 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\RelatorioMedico.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-primary\" href=\"/consulta/relatoriopaciente\">Voltar</a>\n<a class=\"btn btn-danger\" href=\"/home\">Sair</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Medico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
