#pragma checksum "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21fec6fc8892679b2a677b0096a2f33e900ced59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_AdminModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sys/AdminModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sys/AdminModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_AdminModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21fec6fc8892679b2a677b0096a2f33e900ced59", @"/Pages/FytAdmin/Sys/AdminModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sys_AdminModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/ztree/css/metroStyle/metroStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
  
    ViewData["Title"] = "编辑/添加用户";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 585, true);
            WriteLiteral(@"<style>
    .organize-tree {
        position: absolute;
        background-color: #fff;
        padding: 5px 25px;
        z-index: 1000;
        box-shadow: 0 0 24px rgba(0,0,0,.18);
        opacity: 0;
        height: 0;
        display: none;
    }

        .organize-tree.active {
            display: block;
            opacity: 1;
            height: auto;
            max-height: 500px;
            overflow: auto;
            transition: all .5s;
        }

        .organize-tree .ztree li a {
            height: 22px !important;
        }
</style>
");
            EndContext();
            BeginContext(739, 3888, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa0506b698b949498dc6319815d5b459", async() => {
                BeginContext(783, 204, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">所属部门</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" name=\"DepartmentName\" id=\"DepartmentName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 987, "\"", 1027, 1);
#line 36 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
WriteAttributeValue("", 995, Model.adminModel.DepartmentName, 995, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1028, 486, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请选择所属部门"" class=""layui-input"">
            <div class=""organize-tree"">
                <ul id=""tree"" class=""ztree layui-tree-cus""></ul>
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">登录账号</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""LoginName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1514, "\"", 1549, 1);
#line 46 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
WriteAttributeValue("", 1522, Model.adminModel.LoginName, 1522, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1550, 313, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">登录密码</label>
            <div class=""layui-input-inline"">
                <input type=""password"" name=""LoginPwd""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1863, "\"", 1897, 1);
#line 52 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
WriteAttributeValue("", 1871, Model.adminModel.LoginPwd, 1871, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1898, 354, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">姓名</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""TrueName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2252, "\"", 2286, 1);
#line 60 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
WriteAttributeValue("", 2260, Model.adminModel.TrueName, 2260, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2287, 305, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">编号</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""Number""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2592, "\"", 2624, 1);
#line 66 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
WriteAttributeValue("", 2600, Model.adminModel.Number, 2600, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2625, 371, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">性别</label>
            <div class=""layui-input-inline"">
                <input type=""radio"" name=""Sex"" value=""男"" title=""男"" ");
                EndContext();
                BeginContext(2998, 38, false);
#line 74 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
                                                               Write(Model.adminModel.Sex=="男"?"checked":"");

#line default
#line hidden
                EndContext();
                BeginContext(3037, 70, true);
                WriteLiteral(">\r\n                <input type=\"radio\" name=\"Sex\" value=\"女\" title=\"女\" ");
                EndContext();
                BeginContext(3109, 38, false);
#line 75 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
                                                               Write(Model.adminModel.Sex=="女"?"checked":"");

#line default
#line hidden
                EndContext();
                BeginContext(3148, 574, true);
                WriteLiteral(@">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">状态</label>
            <div class=""layui-input-inline"">
                <input type=""checkbox"" checked="""" name=""Status"" lay-skin=""switch"" lay-filter=""switchTest"" lay-text=""ON|OFF"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">手机号码</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""Mobile""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3722, "\"", 3754, 1);
#line 89 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
WriteAttributeValue("", 3730, Model.adminModel.Mobile, 3730, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3755, 264, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">邮箱</label>
            <div class=""layui-input-inline"">
                <input type=""email"" name=""Email""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4019, "\"", 4050, 1);
#line 95 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
WriteAttributeValue("", 4027, Model.adminModel.Email, 4027, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4051, 425, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""button"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""Guid"" id=""Guid""");
                EndContext();
                BeginWriteAttribute("value", " value=", 4476, "", 4505, 1);
#line 105 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
WriteAttributeValue("", 4483, Model.adminModel.Guid, 4483, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4505, 71, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"DepartmentGuid\" id=\"DepartmentGuid\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 4576, "", 4615, 1);
#line 106 "E:\2018Project\ERP项目\2018Soa\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminModify.cshtml"
WriteAttributeValue("", 4583, Model.adminModel.DepartmentGuid, 4583, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4615, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4627, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4629, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc108787eb5440988cb220f04549547a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4720, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4739, 1682, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'common', 'form','ztree'], function () {
            var form = layui.form, $ = layui.$, os = layui.common;
            var index = parent.layer.getFrameIndex(window.name);
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/admin/add"";
                if ($(""#Guid"").val()) {
                    urls = ""api/admin/edit"";
                }
                os.ajax(urls, data.field, function(res) {
                    parent.layer.close(index);
                });
                return false;
            });
            $("".btn-open-close"").on('click', function () {
                parent.layer.close(index);
            });

            var setting = {
                async: {
                    enable: true,
                    url: ""/api/organize/gettree""
                },
                callback: {
                ");
                WriteLiteral(@"    onClick: onClick
                }
            };
            $(""#DepartmentName"").click(function () {
                $("".organize-tree"").addClass('active');
            });
            $("".organize-tree"").mouseleave(function () {
                $("".organize-tree"").removeClass('active');
            });
            $.fn.zTree.init($(""#tree""), setting);
            function onClick(event, treeId, treeNode, clickFlag) {
                $(""#DepartmentGuid"").val(treeNode.guid);
                $(""#DepartmentName"").val(treeNode.name);
                $("".organize-tree"").removeClass('active');
            }
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(6424, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sys.AdminModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.AdminModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.AdminModifyModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sys.AdminModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591