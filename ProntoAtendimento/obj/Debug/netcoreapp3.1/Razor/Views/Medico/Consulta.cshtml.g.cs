#pragma checksum "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78c232f62235224f0034110658f69d2dcc0112f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medico_Consulta), @"mvc.1.0.view", @"/Views/Medico/Consulta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78c232f62235224f0034110658f69d2dcc0112f2", @"/Views/Medico/Consulta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d313c4711937bce2a3a1d4ae06100f96a9639af", @"/Views/_ViewImports.cshtml")]
    public class Views_Medico_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Medico>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<br />\n\n");
#nullable restore
#line 5 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
 if (@Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 7 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
#nullable restore
#line 8 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>Selecione o Médico: </h5>\n");
#nullable restore
#line 13 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
    // <h3>@ViewBag.Mensagem @Model.Nome</h3>

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-hover rounded-top rounded-bottom shadow\">\n        <tr>\n            <th>ID</th>\n            <th>Nome</th>\n            <th>Endereço</th>\n            <th>Telefone</th>\n            <th>Status</th>\n\n        </tr>\n\n");
#nullable restore
#line 24 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
         foreach (var medic in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 27 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
               Write(medic.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
               Write(medic.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
               Write(medic.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 30 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
               Write(medic.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 31 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
               Write(medic.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                <td>\n\n                    <a class=\"btn btn-sm btn-info\"");
            BeginWriteAttribute("href", " href=\"", 743, "\"", 779, 2);
            WriteAttributeValue("", 750, "/consulta/finalizar/", 750, 20, true);
#nullable restore
#line 35 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
WriteAttributeValue("", 770, medic.Id, 770, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Selecionar</a>\n\n                </td>\n            </tr>\n");
#nullable restore
#line 39 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n");
#nullable restore
#line 41 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Consulta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-primary\" href=\"/paciente/consulta\">Voltar</a>");
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
