#pragma checksum "C:\Users\home lap\Documents\GitHub\SMS\Electro\Views\Public\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6935b76ec53c0d779fc33d810a240afe1eb2e880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Public_Checkout), @"mvc.1.0.view", @"/Views/Public/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Public/Checkout.cshtml", typeof(AspNetCore.Views_Public_Checkout))]
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
#line 1 "C:\Users\home lap\Documents\GitHub\SMS\Electro\Views\_ViewImports.cshtml"
using Electro;

#line default
#line hidden
#line 2 "C:\Users\home lap\Documents\GitHub\SMS\Electro\Views\_ViewImports.cshtml"
using Electro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6935b76ec53c0d779fc33d810a240afe1eb2e880", @"/Views/Public/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b727882c773470333541ca32d7aea2699c4a0e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Public_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\home lap\Documents\GitHub\SMS\Electro\Views\Public\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    
    

#line default
#line hidden
            BeginContext(56, 41, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(97, 11639, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b089f504c340e7816ab4551df3556f", async() => {
                BeginContext(103, 10508, true);
                WriteLiteral(@"
    <!-- /NAVIGATION -->
    <!-- BREADCRUMB -->
    <div id=""breadcrumb"" class=""section"">
        <!-- container -->
        <div class=""container"">
            <!-- row -->
            <div class=""row"">
                <div class=""col-md-12"">
                    <h3 class=""breadcrumb-header"">Checkout</h3>
                    <ul class=""breadcrumb-tree"">
                        <li><a href=""#"">Home</a></li>
                        <li class=""active"">Checkout</li>
                    </ul>
                </div>
            </div>
            <!-- /row -->
        </div>
        <!-- /container -->
    </div>
    <!-- /BREADCRUMB -->
    <!-- SECTION -->
    <div class=""section"">
        <!-- container -->
        <div class=""container"">
            <!-- row -->
            <div class=""row"">

                <div class=""col-md-7"">
                    <!-- Billing Details -->
                    <div class=""billing-details"">
                        <div class=""section-title"">
 ");
                WriteLiteral(@"                           <h3 class=""title"">Billing address</h3>
                        </div>
                        <div class=""form-group"">
                            <input class=""input"" type=""text"" name=""first-name"" placeholder=""First Name"">
                        </div>
                        <div class=""form-group"">
                            <input class=""input"" type=""text"" name=""last-name"" placeholder=""Last Name"">
                        </div>
                        <div class=""form-group"">
                            <input class=""input"" type=""email"" name=""email"" placeholder=""Email"">
                        </div>
                        <div class=""form-group"">
                            <input class=""input"" type=""text"" name=""address"" placeholder=""Address"">
                        </div>
                        <div class=""form-group"">
                            <input class=""input"" type=""text"" name=""city"" placeholder=""City"">
                        </div>
              ");
                WriteLiteral(@"          <div class=""form-group"">
                            <input class=""input"" type=""text"" name=""country"" placeholder=""Country"">
                        </div>
                        <div class=""form-group"">
                            <input class=""input"" type=""text"" name=""zip-code"" placeholder=""ZIP Code"">
                        </div>
                        <div class=""form-group"">
                            <input class=""input"" type=""tel"" name=""tel"" placeholder=""Telephone"">
                        </div>
                        <div class=""form-group"">
                            <div class=""input-checkbox"">
                                <input type=""checkbox"" id=""create-account"">
                                <label for=""create-account"">
                                    <span></span>
                                    Create Account?
                                </label>
                                <div class=""caption"">
                                    <p>Lorem ");
                WriteLiteral(@"ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt.</p>
                                    <input class=""input"" type=""password"" name=""password"" placeholder=""Enter Your Password"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /Billing Details -->
                    <!-- Shiping Details -->
                    <div class=""shiping-details"">
                        <div class=""section-title"">
                            <h3 class=""title"">Shiping address</h3>
                        </div>
                        <div class=""input-checkbox"">
                            <input type=""checkbox"" id=""shiping-address"">
                            <label for=""shiping-address"">
                                <span></span>
                                Ship to a diffrent address?
                            </label>
                            <div class=""ca");
                WriteLiteral(@"ption"">
                                <div class=""form-group"">
                                    <input class=""input"" type=""text"" name=""first-name"" placeholder=""First Name"">
                                </div>
                                <div class=""form-group"">
                                    <input class=""input"" type=""text"" name=""last-name"" placeholder=""Last Name"">
                                </div>
                                <div class=""form-group"">
                                    <input class=""input"" type=""email"" name=""email"" placeholder=""Email"">
                                </div>
                                <div class=""form-group"">
                                    <input class=""input"" type=""text"" name=""address"" placeholder=""Address"">
                                </div>
                                <div class=""form-group"">
                                    <input class=""input"" type=""text"" name=""city"" placeholder=""City"">
                        ");
                WriteLiteral(@"        </div>
                                <div class=""form-group"">
                                    <input class=""input"" type=""text"" name=""country"" placeholder=""Country"">
                                </div>
                                <div class=""form-group"">
                                    <input class=""input"" type=""text"" name=""zip-code"" placeholder=""ZIP Code"">
                                </div>
                                <div class=""form-group"">
                                    <input class=""input"" type=""tel"" name=""tel"" placeholder=""Telephone"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /Shiping Details -->
                    <!-- Order notes -->
                    <div class=""order-notes"">
                        <textarea class=""input"" placeholder=""Order Notes""></textarea>
                    </div>
                    <!-- /Order notes -->
 ");
                WriteLiteral(@"               </div>

                <!-- Order Details -->
                <div class=""col-md-5 order-details"">
                    <div class=""section-title text-center"">
                        <h3 class=""title"">Your Order</h3>
                    </div>
                    <div class=""order-summary"">
                        <div class=""order-col"">
                            <div><strong>PRODUCT</strong></div>
                            <div><strong>TOTAL</strong></div>
                        </div>
                        <div class=""order-products"">
                            <div class=""order-col"">
                                <div>1x Product Name Goes Here</div>
                                <div>$980.00</div>
                            </div>
                            <div class=""order-col"">
                                <div>2x Product Name Goes Here</div>
                                <div>$980.00</div>
                            </div>
                       ");
                WriteLiteral(@" </div>
                        <div class=""order-col"">
                            <div>Shiping</div>
                            <div><strong>FREE</strong></div>
                        </div>
                        <div class=""order-col"">
                            <div><strong>TOTAL</strong></div>
                            <div><strong class=""order-total"">$2940.00</strong></div>
                        </div>
                    </div>
                    <div class=""payment-method"">
                        <div class=""input-radio"">
                            <input type=""radio"" name=""payment"" id=""payment-1"">
                            <label for=""payment-1"">
                                <span></span>
                                Direct Bank Transfer
                            </label>
                            <div class=""caption"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dol");
                WriteLiteral(@"ore magna aliqua.</p>
                            </div>
                        </div>
                        <div class=""input-radio"">
                            <input type=""radio"" name=""payment"" id=""payment-2"">
                            <label for=""payment-2"">
                                <span></span>
                                Cheque Payment
                            </label>
                            <div class=""caption"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                            </div>
                        </div>
                        <div class=""input-radio"">
                            <input type=""radio"" name=""payment"" id=""payment-3"">
                            <label for=""payment-3"">
                                <span></span>
                                Paypal System
                            </label>
                ");
                WriteLiteral(@"            <div class=""caption"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                            </div>
                        </div>
                    </div>
                    <div class=""input-checkbox"">
                        <input type=""checkbox"" id=""terms"">
                        <label for=""terms"">
                            <span></span>
                            I've read and accept the <a href=""#"">terms & conditions</a>
                        </label>
                    </div>
                    <a href=""#"" class=""primary-btn order-submit"">Place order</a>
                </div>
                <!-- /Order Details -->
            </div>
            <!-- /row -->
        </div>
        <!-- /container -->
    </div>
    <!-- /SECTION -->
    <!-- NEWSLETTER -->
    <div id=""newsletter"" class=""section"">
        <!-- container -->
        <");
                WriteLiteral(@"div class=""container"">
            <!-- row -->
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""newsletter"">
                        <p>Sign Up for the <strong>NEWSLETTER</strong></p>
                        ");
                EndContext();
                BeginContext(10611, 244, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305082e7da2a4a53a9fde4984ccea6eb", async() => {
                    BeginContext(10617, 231, true);
                    WriteLiteral("\r\n                            <input class=\"input\" type=\"email\" placeholder=\"Enter Your Email\">\r\n                            <button class=\"newsletter-btn\"><i class=\"fa fa-envelope\"></i> Subscribe</button>\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(10855, 874, true);
                WriteLiteral(@"
                        <ul class=""newsletter-follow"">
                            <li>
                                <a href=""#""><i class=""fa fa-facebook""></i></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""fa fa-twitter""></i></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""fa fa-instagram""></i></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""fa fa-pinterest""></i></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- /row -->
        </div>
        <!-- /container -->
    </div>
    <!-- /NEWSLETTER -->
    
");
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
            BeginContext(11736, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
