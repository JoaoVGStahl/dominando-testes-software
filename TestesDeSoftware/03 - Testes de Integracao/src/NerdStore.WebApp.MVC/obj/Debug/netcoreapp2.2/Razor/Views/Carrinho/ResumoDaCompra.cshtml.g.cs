#pragma checksum "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f965d23f41f7222a9954ffc60c88268056e4b7a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_ResumoDaCompra), @"mvc.1.0.view", @"/Views/Carrinho/ResumoDaCompra.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carrinho/ResumoDaCompra.cshtml", typeof(AspNetCore.Views_Carrinho_ResumoDaCompra))]
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
#line 1 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC;

#line default
#line hidden
#line 2 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f965d23f41f7222a9954ffc60c88268056e4b7a8", @"/Views/Carrinho/ResumoDaCompra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246ad970dd91c7456f8d33f4d8e9926f7afca0fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_ResumoDaCompra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdStore.Vendas.Application.Queries.ViewModels.CarrinhoViewModel>
    {
        private global::AspNetCore.Views_Carrinho_ResumoDaCompra.__Generated__SummaryViewComponentTagHelper __SummaryViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("required", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IniciarPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(115, 33, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    ");
            EndContext();
            BeginContext(148, 14, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:summary", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f965d23f41f7222a9954ffc60c88268056e4b7a86476", async() => {
            }
            );
            __SummaryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Carrinho_ResumoDaCompra.__Generated__SummaryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__SummaryViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 29, true);
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n\r\n");
            EndContext();
#line 12 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
          
            if (Model.Items.Any())
            {

#line default
#line hidden
            BeginContext(254, 290, true);
            WriteLiteral(@"                <div class=""col-md-4 order-md-2 mb-4"">
                    <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                        <span class=""text-muted"">Resumo da Compra</span>
                        <span class=""badge badge-secondary badge-pill"">");
            EndContext();
            BeginContext(545, 17, false);
#line 18 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                                  Write(Model.Items.Count);

#line default
#line hidden
            EndContext();
            BeginContext(562, 88, true);
            WriteLiteral("</span>\r\n                    </h4>\r\n                    <ul class=\"list-group mb-3\">\r\n\r\n");
            EndContext();
#line 22 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                          
                            foreach (var item in Model.Items)
                            {

#line default
#line hidden
            BeginContext(772, 206, true);
            WriteLiteral("                                <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n                                    <div>\r\n                                        <h6 class=\"my-0\">");
            EndContext();
            BeginContext(979, 16, false);
#line 27 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                    Write(item.ProdutoNome);

#line default
#line hidden
            EndContext();
            BeginContext(995, 73, true);
            WriteLiteral("</h6>\r\n                                        <small class=\"text-muted\">");
            EndContext();
            BeginContext(1069, 15, false);
#line 28 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                             Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 124, true);
            WriteLiteral(" Unidades</small>\r\n                                    </div>\r\n                                    <span class=\"text-muted\">");
            EndContext();
            BeginContext(1209, 29, false);
#line 30 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                        Write(item.ValorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 48, true);
            WriteLiteral("</span>\r\n                                </li>\r\n");
            EndContext();
#line 32 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                            }

                            if (!string.IsNullOrEmpty(Model.VoucherCodigo))
                            {

#line default
#line hidden
            BeginContext(1427, 294, true);
            WriteLiteral(@"                                <li class=""list-group-item d-flex justify-content-between bg-light"">
                                    <div class=""text-success"">
                                        <h6 class=""my-0"">Voucher Utilizado</h6>
                                        <small>");
            EndContext();
            BeginContext(1722, 19, false);
#line 39 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                          Write(Model.VoucherCodigo);

#line default
#line hidden
            EndContext();
            BeginContext(1741, 118, true);
            WriteLiteral("</small>\r\n                                    </div>\r\n                                    <span class=\"text-success\">-");
            EndContext();
            BeginContext(1860, 33, false);
#line 41 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                                           Write(Model.ValorDesconto.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 48, true);
            WriteLiteral("</span>\r\n                                </li>\r\n");
            EndContext();
#line 43 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                            }


#line default
#line hidden
            BeginContext(1974, 181, true);
            WriteLiteral("                            <li class=\"list-group-item d-flex justify-content-between\">\r\n                                <span>Total</span>\r\n                                <strong>");
            EndContext();
            BeginContext(2156, 30, false);
#line 47 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
                                   Write(Model.ValorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 46, true);
            WriteLiteral("</strong>\r\n                            </li>\r\n");
            EndContext();
            BeginContext(2259, 124, true);
            WriteLiteral("                    </ul>\r\n\r\n                </div>\r\n                <div class=\"col-md-8 order-md-1\">\r\n                    ");
            EndContext();
            BeginContext(2383, 1954, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f965d23f41f7222a9954ffc60c88268056e4b7a813934", async() => {
                BeginContext(2456, 490, true);
                WriteLiteral(@"

                        <h4 class=""mb-3"">Pagamento</h4>
                        <hr class=""mb-4"">
                        <div class=""row"">
                            <img class=""img-fluid"" src=""Images/cards.png"">

                        </div>
                        <br /><br />
                        <div class=""row"">
                            <div class=""col-md-6 mb-3"">
                                <label>Nome no Cartão</label>
                                ");
                EndContext();
                BeginContext(2946, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f965d23f41f7222a9954ffc60c88268056e4b7a814821", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 66 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pagamento.NomeCartao);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3044, 295, true);
                WriteLiteral(@"
                                <small class=""text-muted"">Nome completo como consta no cartão</small>
                            </div>
                            <div class=""col-md-6 mb-3"">
                                <label>Número do Cartão</label>
                                ");
                EndContext();
                BeginContext(3339, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f965d23f41f7222a9954ffc60c88268056e4b7a817274", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 71 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pagamento.NumeroCartao);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3439, 265, true);
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-3 mb-3"">
                                <label>Data Expiração</label>
                                ");
                EndContext();
                BeginContext(3704, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f965d23f41f7222a9954ffc60c88268056e4b7a819699", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 77 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pagamento.ExpiracaoCartao);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3807, 179, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-3 mb-3\">\r\n                                <label>CVV</label>\r\n                                ");
                EndContext();
                BeginContext(3986, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f965d23f41f7222a9954ffc60c88268056e4b7a822045", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 81 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pagamento.CvvCartao);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4083, 247, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <hr class=\"mb-4\">\r\n                        <button class=\"btn btn-primary btn-lg btn-block\" type=\"submit\">Finalizar Compra</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4337, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 88 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(4411, 50, true);
            WriteLiteral("                <div><p>Carrinho Vazio</p></div>\r\n");
            EndContext();
#line 92 "C:\dev\dominando-testes-software\TestesDeSoftware\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\ResumoDaCompra.cshtml"
            }
        

#line default
#line hidden
            BeginContext(4487, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdStore.Vendas.Application.Queries.ViewModels.CarrinhoViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:summary")]
        public class __Generated__SummaryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__SummaryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Summary", new {  });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
