#pragma checksum "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0080fb04df194fd1a246e6116e5b0b2e34271a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PMK_IntCoE_Services.Pages.AEDash.Pages_AEDash_ExcepDetail), @"mvc.1.0.razor-page", @"/Pages/AEDash/ExcepDetail.cshtml")]
namespace PMK_IntCoE_Services.Pages.AEDash
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
#line 1 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\_ViewImports.cshtml"
using PMK_IntCoE_Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\_ViewImports.cshtml"
using PMK_IntCoE_Services.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0080fb04df194fd1a246e6116e5b0b2e34271a4", @"/Pages/AEDash/ExcepDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e719efe8d553bd1be62db7612a0da9e7fa5b4e21", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AEDash_ExcepDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
  
    ViewData["Title"] = "ExcepDetail";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <h4>ESB_EXCEPTION_LOGGER</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.MESSAGETYPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.MESSAGETYPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.EXCEPTION_TIMESTAMP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.EXCEPTION_TIMESTAMP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.GLOBALTRANSACTIONID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.GLOBALTRANSACTIONID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.LOCALTRANSACTIONID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.LOCALTRANSACTIONID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.PARENTTRANSACTIONID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.PARENTTRANSACTIONID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.PROJECTNAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.PROJECTNAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.INTERFACE_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.INTERFACE_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.INTERFACENAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.INTERFACENAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.SOURCEAPP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.SOURCEAPP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.DESTINATIONAPP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.DESTINATIONAPP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.AUDITTYPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.AUDITTYPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.TOOLNAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.TOOLNAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.BROKERNAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.BROKERNAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.BROKERFAMILY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.BROKERFAMILY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.EXECUTIONGROUP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.EXECUTIONGROUP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.QUEUEMANAGER));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.QUEUEMANAGER));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.INPUTQUEUE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.INPUTQUEUE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.MSGFLOW));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.MSGFLOW));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 124 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.EXCEPTIONNUMBER));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 127 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.EXCEPTIONNUMBER));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 130 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.SEVERITY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 133 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.SEVERITY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 136 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.CATEGORY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 139 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.CATEGORY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 142 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.DETAILERRORMESSAGE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 145 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.DETAILERRORMESSAGE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 148 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.ERRORSOURCE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 151 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.ERRORSOURCE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 154 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.KEYIDENTIFIER));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 157 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.KEYIDENTIFIER));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 160 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.ORIGINALMESSAGE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 163 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.ORIGINALMESSAGE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 166 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.MESSAGEDETAILS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 169 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.MESSAGEDETAILS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 172 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.MISCELLANEOUS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 175 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.MISCELLANEOUS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 178 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.MESSAGEID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 181 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.MESSAGEID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 184 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ESB_EXCEPTION_LOGGER.INSERT_TIMESTAMP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 187 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
       Write(Html.DisplayFor(model => model.ESB_EXCEPTION_LOGGER.INSERT_TIMESTAMP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0080fb04df194fd1a246e6116e5b0b2e34271a426102", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 192 "C:\Users\smohan\Documents\GitHub\ESB\ESB_SI\Source\PMK-IntCoE-Services\Pages\AEDash\ExcepDetail.cshtml"
                           WriteLiteral(Model.ESB_EXCEPTION_LOGGER.ROWID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0080fb04df194fd1a246e6116e5b0b2e34271a428291", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PMK_IntCoE_Services.Pages.AEDash.ExcepDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PMK_IntCoE_Services.Pages.AEDash.ExcepDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PMK_IntCoE_Services.Pages.AEDash.ExcepDetailModel>)PageContext?.ViewData;
        public PMK_IntCoE_Services.Pages.AEDash.ExcepDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591