#pragma checksum "C:\Users\home lap\Documents\GitHub\SMS\Electro\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc18332694336655d443345b023b75774533e139"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc18332694336655d443345b023b75774533e139", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b727882c773470333541ca32d7aea2699c4a0e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\home lap\Documents\GitHub\SMS\Electro\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = null;

#line default
#line hidden
            BeginContext(63, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(100, 1451, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14bcef3291754e29a4b7a6bc9f06d94f", async() => {
                BeginContext(106, 1438, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <title>Electro - HTML Ecommerce Template</title>

    <!-- Google font -->
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,500,700"" rel=""stylesheet"">

    <!-- Bootstrap -->
    <link type=""text/css"" rel=""stylesheet"" href=""../css/bootstrap.min.css"" />

    <!-- Slick -->
    <link type=""text/css"" rel=""stylesheet"" href=""../css/slick.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""../css/slick-theme.css"" />

    <!-- nouislider -->
    <link type=""text/css"" rel=""stylesheet"" href=""../css/nouislider.min.css"" />

    <!-- Font Awesome Icon -->
    <link rel=""stylesheet"" href=""../css/font-awesome.min.css"">

    <!-- Custom stlylesheet -->
    <link type=""text/css"" rel=""stylesheet"" h");
                WriteLiteral(@"ref=""../css/style.css"" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
      <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1551, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1553, 14823, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3245aad3c9f45508995c026ddc4da29", async() => {
                BeginContext(1559, 1543, true);
                WriteLiteral(@"
    <!-- HEADER -->
    <header>
        <!-- TOP HEADER -->
        <div id=""top-header"">
            <div class=""container"">
                <ul class=""header-links pull-left"">
                    <li><a href=""#""><i class=""fa fa-phone""></i> +021-95-51-84</a></li>
                    <li><a href=""#""><i class=""fa fa-envelope-o""></i> email@email.com</a></li>
                    <li><a href=""#""><i class=""fa fa-map-marker""></i> 1734 Stonecoal Road</a></li>
                </ul>
                <ul class=""header-links pull-right"">
                    <li><a href=""#""><i class=""fa fa-dollar""></i> USD</a></li>
                    <li><a href=""#""><i class=""fa fa-user-o""></i> My Account</a></li>
                </ul>
            </div>
        </div>
        <!-- /TOP HEADER -->
        <!-- MAIN HEADER -->
        <div id=""header"">
            <!-- container -->
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <!-- LOGO -->");
                WriteLiteral(@"
                    <div class=""col-md-3"">
                        <div class=""header-logo"">
                            <a href=""#"" class=""logo"">
                                <img src=""../images/logo.png"" alt="""">
                            </a>
                        </div>
                    </div>
                    <!-- /LOGO -->
                    <!-- SEARCH BAR -->
                    <div class=""col-md-6"">
                        <div class=""header-search"">
                            ");
                EndContext();
                BeginContext(3102, 537, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0882f0261fa2416a93ae0e201d5d0c50", async() => {
                    BeginContext(3108, 101, true);
                    WriteLiteral("\r\n                                <select class=\"input-select\">\r\n                                    ");
                    EndContext();
                    BeginContext(3209, 41, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21497912955241529086e52c3efb199c", async() => {
                        BeginContext(3227, 14, true);
                        WriteLiteral("All Categories");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3250, 38, true);
                    WriteLiteral("\r\n                                    ");
                    EndContext();
                    BeginContext(3288, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b258166950524a7f8e78f93ea2aa2757", async() => {
                        BeginContext(3306, 11, true);
                        WriteLiteral("Category 01");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3326, 38, true);
                    WriteLiteral("\r\n                                    ");
                    EndContext();
                    BeginContext(3364, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3129b8c14c410085af37aab1993845", async() => {
                        BeginContext(3382, 11, true);
                        WriteLiteral("Category 02");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3402, 230, true);
                    WriteLiteral("\r\n                                </select>\r\n                                <input class=\"input\" placeholder=\"Search here\">\r\n                                <button class=\"search-btn\">Search</button>\r\n                            ");
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
                BeginContext(3639, 6390, true);
                WriteLiteral(@"
                        </div>
                    </div>
                    <!-- /SEARCH BAR -->
                    <!-- ACCOUNT -->
                    <div class=""col-md-3 clearfix"">
                        <div class=""header-ctn"">
                            <!-- Wishlist -->
                            <div>
                                <a href=""#"">
                                    <i class=""fa fa-heart-o""></i>
                                    <span>Your Wishlist</span>
                                    <div class=""qty"">2</div>
                                </a>
                            </div>
                            <!-- /Wishlist -->
                            <!-- Cart -->
                            <div class=""dropdown"">
                                <a class=""dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""true"">
                                    <i class=""fa fa-shopping-cart""></i>
                                    <span>Your Cart</span>
   ");
                WriteLiteral(@"                                 <div class=""qty"">3</div>
                                </a>
                                <div class=""cart-dropdown"">
                                    <div class=""cart-list"">
                                        <div class=""product-widget"">
                                            <div class=""product-img"">
                                                <img src=""../images/product01.png"" alt="""">
                                            </div>
                                            <div class=""product-body"">
                                                <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                                                <h4 class=""product-price""><span class=""qty"">1x</span>$980.00</h4>
                                            </div>
                                            <button class=""delete""><i class=""fa fa-close""></i></button>
                                        </div>

        ");
                WriteLiteral(@"                                <div class=""product-widget"">
                                            <div class=""product-img"">
                                                <img src=""../images/product02.png"" alt="""">
                                            </div>
                                            <div class=""product-body"">
                                                <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                                                <h4 class=""product-price""><span class=""qty"">3x</span>$980.00</h4>
                                            </div>
                                            <button class=""delete""><i class=""fa fa-close""></i></button>
                                        </div>
                                    </div>
                                    <div class=""cart-summary"">
                                        <small>3 Item(s) selected</small>
                                        <h5>SUBTOTAL: ");
                WriteLiteral(@"$2940.00</h5>
                                    </div>
                                    <div class=""cart-btns"">
                                        <a href=""#"">View Cart</a>
                                        <a href=""#"">Checkout  <i class=""fa fa-arrow-circle-right""></i></a>
                                    </div>
                                </div>
                            </div>
                            <!-- /Cart -->
                            <!-- Menu Toogle -->
                            <div class=""menu-toggle"">
                                <a href=""#"">
                                    <i class=""fa fa-bars""></i>
                                    <span>Menu</span>
                                </a>
                            </div>
                            <!-- /Menu Toogle -->
                        </div>
                    </div>
                    <!-- /ACCOUNT -->
                </div>
                <!-- row -->
            </div");
                WriteLiteral(@">
            <!-- container -->
        </div>
        <!-- /MAIN HEADER -->
    </header>
    <!-- /HEADER -->
    <!-- NAVIGATION -->
    <nav id=""navigation"">
        <!-- container -->
        <div class=""container"">
            <!-- responsive-nav -->
            <div id=""responsive-nav"">
                <!-- NAV -->
                <ul class=""main-nav nav navbar-nav"">
                    <li class=""active""><a href=""#"">Home</a></li>
                    <li><a href=""#"">Hot Deals</a></li>
                    <li><a href=""#"">Categories</a></li>
                    <li><a href=""#"">Laptops</a></li>
                    <li><a href=""#"">Smartphones</a></li>
                    <li><a href=""#"">Cameras</a></li>
                    <li><a href=""#"">Accessories</a></li>
                </ul>
                <!-- /NAV -->
            </div>
            <!-- /responsive-nav -->
        </div>
        <!-- /container -->
    </nav>
    <!-- /NAVIGATION -->
    <!-- BREADCRUMB -->
    <div ");
                WriteLiteral(@"id=""breadcrumb"" class=""section"">
        <!-- container -->
        <div class=""container"">
            <!-- row -->
            <div class=""row"">
                <div class=""col-md-12"">
                    <h3 class=""breadcrumb-header"">Regular Page</h3>
                    <ul class=""breadcrumb-tree"">
                        <li><a href=""#"">Home</a></li>
                        <li class=""active"">Blank</li>
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
            </div>
            <!-- /row -->
        </div>
        <!-- /container -->
    </div>
    <!-- /SECTION -->
    <!-- NEWSLETTER -->
    <div id=""newsletter"" class=""section"">
        <!-- container -->
        <div class=""container"">");
                WriteLiteral("\r\n            <!-- row -->\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"newsletter\">\r\n                        <p>Sign Up for the <strong>NEWSLETTER</strong></p>\r\n                        ");
                EndContext();
                BeginContext(10029, 235, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaa60d4379c24932893a92896eec30f9", async() => {
                    BeginContext(10035, 222, true);
                    WriteLiteral("\r\n                            <input class=\"input\" type=\"email\" placeholder=\"Enter Your Email\">\r\n                            <input class=\"input\" type=\"password\" placeholder=\"Enter Your Password\">\r\n                        ");
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
                BeginContext(10264, 6105, true);
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
    <!-- FOOTER -->
    <footer id=""footer"">
        <!-- top footer -->
        <div class=""section"">
            <!-- container -->
            <div ");
                WriteLiteral(@"class=""container"">
                <!-- row -->
                <div class=""row"">
                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">About Us</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut.</p>
                            <ul class=""footer-links"">
                                <li><a href=""#""><i class=""fa fa-map-marker""></i>1734 Stonecoal Road</a></li>
                                <li><a href=""#""><i class=""fa fa-phone""></i>+021-95-51-84</a></li>
                                <li><a href=""#""><i class=""fa fa-envelope-o""></i>email@email.com</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Categories</h3>
     ");
                WriteLiteral(@"                       <ul class=""footer-links"">
                                <li><a href=""#"">Hot deals</a></li>
                                <li><a href=""#"">Laptops</a></li>
                                <li><a href=""#"">Smartphones</a></li>
                                <li><a href=""#"">Cameras</a></li>
                                <li><a href=""#"">Accessories</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class=""clearfix visible-xs""></div>

                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Information</h3>
                            <ul class=""footer-links"">
                                <li><a href=""#"">About Us</a></li>
                                <li><a href=""#"">Contact Us</a></li>
                                <li><a href=""#"">Privacy Policy</a></li>
                                <li><a h");
                WriteLiteral(@"ref=""#"">Orders and Returns</a></li>
                                <li><a href=""#"">Terms & Conditions</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Service</h3>
                            <ul class=""footer-links"">
                                <li><a href=""#"">My Account</a></li>
                                <li><a href=""#"">View Cart</a></li>
                                <li><a href=""#"">Wishlist</a></li>
                                <li><a href=""#"">Track My Order</a></li>
                                <li><a href=""#"">Help</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- /row -->
            </div>
            <!-- /container -->
        </div>
        <!-- /top footer -->
   ");
                WriteLiteral(@"     <!-- bottom footer -->
        <div id=""bottom-footer"" class=""section"">
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <div class=""col-md-12 text-center"">
                        <ul class=""footer-payments"">
                            <li><a href=""#""><i class=""fa fa-cc-visa""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-credit-card""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-paypal""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-mastercard""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-discover""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-amex""></i></a></li>
                        </ul>
                        <span class=""copyright"">
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
               ");
                WriteLiteral(@"             Copyright &copy;
                            <script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class=""fa fa-heart-o"" aria-hidden=""true""></i> by <a href=""https://colorlib.com"" target=""_blank"">Colorlib</a>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        </span>


                    </div>
                </div>
                <!-- /row -->
            </div>
            <!-- /container -->
        </div>
        <!-- /bottom footer -->
    </footer>
    <!-- /FOOTER -->
    <!-- jQuery Plugins -->
    <script src=""../js/jquery.min.js""></script>
    <script src=""../js/bootstrap.min.js""></script>
    <script src=""../js/slick.min.js""></script>
    <script src=""../js/nouislider.min.js""></script>
    <script src=""../js/jquery.zoom.min.js""></script>
    <script src=""../js/main.js""></script>

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
            BeginContext(16376, 13, true);
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
