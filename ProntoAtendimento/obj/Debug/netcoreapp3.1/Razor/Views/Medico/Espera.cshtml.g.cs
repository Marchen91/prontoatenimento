#pragma checksum "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0da65c028864c3551ec420e469e509dd0b6975d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medico_Espera), @"mvc.1.0.view", @"/Views/Medico/Espera.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0da65c028864c3551ec420e469e509dd0b6975d", @"/Views/Medico/Espera.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d313c4711937bce2a3a1d4ae06100f96a9639af", @"/Views/_ViewImports.cshtml")]
    public class Views_Medico_Espera : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Consulta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid mt-100"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h5>Procedimentos</h5>
                    </div>
                    <div class=""card-body cart"">
                        <div class=""col-sm-12 empty-cart-cls text-center"">
                            <h3><strong>Nenhuma Consulta aberta.</strong></h3>
                            <button class=""btn btn-primary"">
                                Escolher Procedimentos
                            </button>
                            <a href=""/home"" class=""btn btn-sm btn-danger m-3"" data-abc=""true"">Sair</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div> 
");
#nullable restore
#line 25 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid mt-100"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h5>Procedimentos Utilizados</h5>
                    </div>
                    <div>
                        <table class=""table table-hover"">
                            <tr>
                                <th>ID</th>
                                <th>Nome</th>
                                <th>Tipo</th>
                                <th>Valor</th>

                            </tr>
");
#nullable restore
#line 44 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 47 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
                                   Write(item.Nr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 48 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
                                   Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 49 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
                                   Write(item.Diagnostico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    \n\n                                    <td>\n                                        <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1954, "\"", 1993, 2);
            WriteAttributeValue("", 1961, "/Procedimento/Selection/", 1961, 24, true);
#nullable restore
#line 53 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
WriteAttributeValue("", 1985, item.Nr, 1985, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"removidoBox()\">\n                                            Escolher Consulta\n                                        </a>\n                                        <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2199, "\"", 2231, 2);
            WriteAttributeValue("", 2206, "/Consulta/Update/", 2206, 17, true);
#nullable restore
#line 56 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
WriteAttributeValue("", 2223, item.Nr, 2223, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"removidoBox()\">\n                                            Atualizar Consulta\n                                        </a>\n                                    </td>\n                                </tr>");
#nullable restore
#line 60 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </table>
                    </div>
                </div>
                
                <a href=""/home"" class=""btn btn-primary cart-btn-transform mt-2 float-right""
                   data-abc=""true"">Sair </a>
            </div>
        </div>
    </div>
");
            WriteLiteral("                <script>function removidoBox() {\n            alert(\"Item Removido Com Sucesso!\");\n        }</script>");
#nullable restore
#line 73 "C:\Users\Henri\Desktop\pronto atend\pronto_atendimento-master (3)\pronto_atendimento-master\ProntoAtendimento\Views\Medico\Espera.cshtml"
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
