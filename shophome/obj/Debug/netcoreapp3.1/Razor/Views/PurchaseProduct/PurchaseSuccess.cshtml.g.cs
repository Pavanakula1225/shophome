#pragma checksum "C:\Users\pavan\Downloads\V11600338321534\V1\shophome\shophome\ShopHome\Views\PurchaseProduct\PurchaseSuccess.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61a1d1589a8a26ac1020f03fa4124e64a3bed15fba9f6de26b1719db9ec750ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseProduct_PurchaseSuccess), @"mvc.1.0.view", @"/Views/PurchaseProduct/PurchaseSuccess.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pavan\Downloads\V11600338321534\V1\shophome\shophome\ShopHome\Views\_ViewImports.cshtml"
using ShopHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pavan\Downloads\V11600338321534\V1\shophome\shophome\ShopHome\Views\_ViewImports.cshtml"
using ShopHome.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"61a1d1589a8a26ac1020f03fa4124e64a3bed15fba9f6de26b1719db9ec750ca", @"/Views/PurchaseProduct/PurchaseSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f6ad0096b186a32ae30084aeab26edd399a1b075a7405ef7cde1721ef1f31dee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PurchaseProduct_PurchaseSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pavan\Downloads\V11600338321534\V1\shophome\shophome\ShopHome\Views\PurchaseProduct\PurchaseSuccess.cshtml"
  
    ViewData["Title"] = "PurchaseSuccess";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Purchase is Successful</h2>\r\n<h3>Purchased ID : ");
#nullable restore
#line 6 "C:\Users\pavan\Downloads\V11600338321534\V1\shophome\shophome\ShopHome\Views\PurchaseProduct\PurchaseSuccess.cshtml"
              Write(ViewData["PurchaseID"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Purchased Product : ");
#nullable restore
#line 7 "C:\Users\pavan\Downloads\V11600338321534\V1\shophome\shophome\ShopHome\Views\PurchaseProduct\PurchaseSuccess.cshtml"
                   Write(ViewData["ProductName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Quantity Purchased: ");
#nullable restore
#line 8 "C:\Users\pavan\Downloads\V11600338321534\V1\shophome\shophome\ShopHome\Views\PurchaseProduct\PurchaseSuccess.cshtml"
                   Write(ViewData["Quantity"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
