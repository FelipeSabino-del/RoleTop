#pragma checksum "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1047450dd9ba5643e28df4e031750c8c7f7c7e92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1047450dd9ba5643e28df4e031750c8c7f7c7e92", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/usuario.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px; height: 200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 72, true);
            WriteLiteral("<main>\r\n<br>\r\n        <div id=\"user\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(114, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1047450dd9ba5643e28df4e031750c8c7f7c7e924456", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(186, 732, true);
            WriteLiteral(@"
            </p>
            <p id=""p2"">
                ADM
            </p>
        </div>
<br>
<br>
<br>
        <div class=""tab"">
            <button class=""tablinks"" onclick=""openCity(event, 'London')"" id=""defaultOpen"">Eventos de usuários</button>
            <button class=""tablinks"" onclick=""openCity(event, 'Tokyo')"">Informações pessoais</button>
        </div>
        
        <div id=""London"" class=""tabcontent"">
            <h2>Dashboard</h2>

            <section id=""status-pedidos"">
                <h3>Status dos pedidos</h3>
                <div id=""painel"">
                    <div class=""box-status-pedidos aprovados"">
                        <h4>Aprovados</h4>
                        <p>");
            EndContext();
            BeginContext(919, 22, false);
#line 28 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                      Write(Model.EventosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(941, 169, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"box-status-pedidos pendentes\">\r\n                        <h4>Pendentes</h4>\r\n                        <p>");
            EndContext();
            BeginContext(1111, 22, false);
#line 32 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                      Write(Model.EventosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 171, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"box-status-pedidos reprovados\">\r\n                        <h4>Reprovados</h4>\r\n                        <p>");
            EndContext();
            BeginContext(1305, 23, false);
#line 36 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                      Write(Model.EventosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 871, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
            </section>
    
            <section id=""lista-pedidos"">
                <h3>Lista de eventos</h3>
                <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome do evento</th>
                        <th rowspan=""2"">Data</th>
                        <th rowspan=""2"">Número de pessoas</th>
                        <th rowspan=""2"">Adicionais</th>
                        <th colspan=""2"" rowspan=""2"">Aprovar</th>
                    </tr>
                    <tr>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""6"">
                            <p>Eventos atualizados em ");
            EndContext();
            BeginContext(2200, 12, false);
#line 60 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(2212, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 65 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                     foreach(var eventos in Model.Eventos )
                    {

#line default
#line hidden
            BeginContext(2411, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2474, 19, false);
#line 68 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                           Write(eventos.Espaço.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2493, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2533, 40, false);
#line 69 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                           Write(eventos.DataDoEvento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2573, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2613, 22, false);
#line 70 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                           Write(eventos.NumPessoa.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2635, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2675, 22, false);
#line 71 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                           Write(eventos.Adicional.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2697, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2738, "\'", 2799, 1);
#line 72 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2745, Url.Action("Aprovar", "User", new {id = @eventos.Id}), 2745, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2800, 74, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2874, "\'", 2936, 1);
#line 73 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2881, Url.Action("Reprovar", "User", new {id = @eventos.Id}), 2881, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2937, 71, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 75 "C:\Users\felip\Desktop\Programas\Trabalhos\Senai\RoleTop\MVC\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(3031, 314, true);
            WriteLiteral(@"                </tbody>
            </table>
            </section>
        </div>
        
        
        
        <div id=""Tokyo"" class=""tabcontent"">
        <h3>Informações pessoais</h3>
        <br>
        <br>
        <p>DADOS DO USUÁRIO</p>
        </div>
<br>
<br>
<br>
<hr>
</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
