#pragma checksum "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Finalizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff3ebfece6a11a35fdcd248d1b14bc1b37b49427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consulta_Finalizar), @"mvc.1.0.view", @"/Views/Consulta/Finalizar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff3ebfece6a11a35fdcd248d1b14bc1b37b49427", @"/Views/Consulta/Finalizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d313c4711937bce2a3a1d4ae06100f96a9639af", @"/Views/_ViewImports.cshtml")]
    public class Views_Consulta_Finalizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Consulta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<table class=\"table table-hover\">\n    \n    <center>\n        <h4>\n            A consulta será criada\n        </h4>\n    </center>\n</table>\n<div>\n    \n        \n        <p> Paciente: ");
#nullable restore
#line 15 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Finalizar.cshtml"
                 Write(Model.NomePaciente);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n        <p> Médico: ");
#nullable restore
#line 16 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Consulta\Finalizar.cshtml"
               Write(Model.NomeMedico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n    \n</div>\n\n\n<div>\n\n    <a class=\"btn btn-primary btn-sm\" href=\"/medico/consulta/\">Voltar</a>\n    <a class=\"btn btn-info btn-sm\" href=\"/consulta/create/\">Criar Consulta</a>\n\n\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Consulta> Html { get; private set; }
    }
}
#pragma warning restore 1591
