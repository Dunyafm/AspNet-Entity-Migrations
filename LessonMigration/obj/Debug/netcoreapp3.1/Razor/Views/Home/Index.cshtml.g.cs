#pragma checksum "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e6a8eac57db9a57d9f4979065991f5e8ffcb909"
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
#line 1 "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\_ViewImports.cshtml"
using LessonMigration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\_ViewImports.cshtml"
using LessonMigration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\_ViewImports.cshtml"
using LessonMigration.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6a8eac57db9a57d9f4979065991f5e8ffcb909", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15bb8ae992336ed7ecf780060bded98401cd356d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- MAIN START -->\r\n<main>\r\n\r\n    <!-- SLIDER START -->\r\n\r\n    <section id=\"slider\">\r\n        <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\Home\Index.cshtml"
             foreach (var item in Model.Sliders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div> <img");
            BeginWriteAttribute("src", " src=\"", 238, "\"", 259, 2);
            WriteAttributeValue("", 244, "img/", 244, 4, true);
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 248, item.Image, 248, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 260, "\"", 266, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"container context pl-lg-5 ml-lg-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Detail.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"text-black-50 d-none d-sm-block\">\r\n                            ");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\Home\Index.cshtml"
                       Write(Model.Detail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 785, "\"", 814, 2);
            WriteAttributeValue("", 791, "img/", 791, 4, true);
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\AspNet-Entity-Migrations\LessonMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 795, Model.Detail.Image, 795, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 815, "\"", 821, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SLIDER END -->
    <!-- PRODUCTS START -->

    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1288, "\"", 1295, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1526, "\"", 1533, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1601, "\"", 1608, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1684, "\"", 1691, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1765, "\"", 1772, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1848, "\"", 1855, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1929, "\"", 1936, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2009, "\"", 2016, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2252, "\"", 2259, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2319, "\"", 2326, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2394, "\"", 2401, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2467, "\"", 2474, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2542, "\"", 2549, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2615, "\"", 2622, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2687, "\"", 2694, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2868, "\"", 2875, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr-2"">Filter</a>
                            <i class=""fas fa-caret-down""></i>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""popular"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 3312, "\"", 3319, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-14-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 3403, "\"", 3409, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""popular"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 4100, "\"", 4107, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-13-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 4191, "\"", 4197, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""winter"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 4887, "\"", 4894, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-12-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 4978, "\"", 4984, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""winter"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 5674, "\"", 5681, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-11-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 5765, "\"", 5771, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""various"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 6462, "\"", 6469, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-10-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 6553, "\"", 6559, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""various"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 7250, "\"", 7257, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-9-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 7340, "\"", 7346, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""exotic"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 8036, "\"", 8043, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-8-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 8126, "\"", 8132, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""exotic"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 8822, "\"", 8829, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-7-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 8912, "\"", 8918, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- PRODUCTS END -->
    <!-- ABOUT START -->

    <section id=""about"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-lg-6"">
                    <div class=""img"">
                        <img src=""img/h3-video-img.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 9756, "\"", 9762, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                            <i class=""fas fa-play fa-lg""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                        <h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>
                        <p class=""py-3"">
                            Where flowers are our inspiration to create lasting memories. Whatever the
                            occasion...
                        </p>
                        <ul class=""list-unstyled"">
                            <li class=""mt-3"">
                                <img src=""img/h1-custom-icon.png"" class=""mr-2""");
            BeginWriteAttribute("alt", " alt=\"", 10637, "\"", 10643, 0);
            EndWriteAttribute();
            WriteLiteral("> Hand picked just\r\n                                for you.\r\n                            </li>\r\n                            <li class=\"mt-3\">\r\n                                <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 10866, "\"", 10872, 0);
            EndWriteAttribute();
            WriteLiteral("> Unique flower\r\n                                arrangements\r\n                            </li>\r\n                            <li class=\"mt-3\">\r\n                                <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 11096, "\"", 11102, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Best way to say
                                you care.
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ABOUT END -->
    <!-- EXPERTS START -->

    <section id=""experts"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>Flower Experts</h1>
                        <p class=""text-black-50"">
                            A perfect blend of creativity, energy, communication, happiness and
                            love. Let us arrange
                            a smile for you.
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row pb-5"">
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item text-center"">
      ");
            WriteLiteral("                  <div class=\"img\">\r\n                            <img src=\"img/h3-team-img-1.png\" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 12257, "\"", 12263, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""text mt-3"">
                            <h6>CRYSTAL BROOKS</h6>
                            <p class=""text-black-50"">Florist</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item text-center"">
                        <div class=""img"">
                            <img src=""img/h3-team-img-2.png"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 12788, "\"", 12794, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""text mt-3"">
                            <h6>SHIRLEY HARRIS</h6>
                            <p class=""text-black-50"">Manager</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item text-center"">
                        <div class=""img"">
                            <img src=""img/h3-team-img-3.png"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 13319, "\"", 13325, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""text mt-3"">
                            <h6>BEVERLY CLARK</h6>
                            <p class=""text-black-50"">Florist</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item text-center"">
                        <div class=""img"">
                            <img src=""img/h3-team-img-4.png"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 13849, "\"", 13855, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""text mt-3"">
                            <h6>AMANDA WATKINS</h6>
                            <p class=""text-black-50"">Florist</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
            </div>
        </div>
    </section>

    <!-- EXPERTS END -->
    <!-- SUBSCRIBE START -->

    <section id=""subscribe"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <div class=""content text-center py-5"">
                        <h3>Join The Colorful Bunch!</h3>
                        <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                            <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                   ");
            WriteLiteral(@"         <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SUBSCRIBE END -->
    <!-- BLOG START -->

    <section id=""blog"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>From our Blog</h1>
                        <p class=""text-black-50"">
                            A perfect blend of creativity, energy, communication, happiness and
                            love. Let us arrange
                            a smile for you.
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row pb-5"">
                <div class=""col-md-6 col-lg-4"">
                    <div class=""item"">
                      ");
            WriteLiteral("  <div class=\"img position-relative\">\r\n                            <img src=\"img/blog-feature-img-1.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16026, "\"", 16032, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>Flower Power</h5>
                            <p class=""text-black-50"">
                                Class aptent taciti sociosqu ad litora torquent per conubia
                                nostra, per
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-4"">
                    <div class=""item"">
                        <div class=""img position-relative"">
                            <img src=""img/blog-feature-img-3.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 16915, "\"", 16921, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>Local Florists</h5>
                            <p class=""text-black-50"">
                                Class aptent taciti sociosqu ad litora torquent per conubia
                                nostra, per
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-4"">
                    <div class=""item"">
                        <div class=""img position-relative"">
                            <img src=""img/blog-feature-img-4.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 17806, "\"", 17812, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>Flower Beauty</h5>
                            <p class=""text-black-50"">
                                Class aptent taciti sociosqu ad litora torquent per conubia
                                nostra, per
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- BLOG END -->
    <!-- SAY START -->

    <section id=""say"">
        <div class=""container"">
            <div class=""row py-5 justify-content-center"">
                <div class=""col-md-8 col-xl-6"">
                    <div class=""owl-carousel say"">
                        <div>
                       ");
            WriteLiteral("     <div class=\"item text-center\">\r\n                                <div class=\"img d-flex justify-content-center\">\r\n                                    <img src=\"img/testimonial-img-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 19027, "\"", 19033, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""text text-muted pt-3 pb-5"">
                                    <i>
                                        Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus
                                        lingua.
                                    </i>
                                </div>
                                <div class=""author"">
                                    <h6>Anna Barnes</h6>
                                    <p class=""text-black-50"">Florist</p>
                                </div>
                            </div>
                        </div>
                        <div>
                            <div class=""item text-center"">
                                <div class=""img d-flex justify-content-center"">
                                    <img src=""img/testimonial-img-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 19977, "\"", 19983, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""text text-muted pt-3 pb-5"">
                                    <i>
                                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo
                                        ligula eget.
                                    </i>
                                </div>
                                <div class=""author"">
                                    <h6>Jasmine White</h6>
                                    <p class=""text-black-50"">Florist</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SAY END -->
    <!-- INSTAGRAM START -->

    <section id=""instagram"">
        <div class=""owl-carousel instagram"">
            <div><img src=""img/instagram1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 20987, "\"", 20993, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram2.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 21067, "\"", 21073, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram3.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 21147, "\"", 21153, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram4.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 21227, "\"", 21233, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram5.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 21307, "\"", 21313, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram6.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 21387, "\"", 21393, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram7.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 21467, "\"", 21473, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram8.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 21547, "\"", 21553, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        </div>\r\n        <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n            #FIORELLO\r\n        </div>\r\n    </section>\r\n\r\n    <!-- INSTAGRAM END -->\r\n\r\n</main>\r\n\r\n<!-- MAIN END -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
