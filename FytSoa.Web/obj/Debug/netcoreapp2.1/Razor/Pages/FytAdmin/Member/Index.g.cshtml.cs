#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717c183d050997175ef996b33efd7ad2f2938908"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Member.Pages_FytAdmin_Member_Index), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Member/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Member/Index.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Member.Pages_FytAdmin_Member_Index), null)]
namespace FytSoa.Web.Pages.FytAdmin.Member
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717c183d050997175ef996b33efd7ad2f2938908", @"/Pages/FytAdmin/Member/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Member_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Member\Index.cshtml"
  
    ViewData["Title"] = "会员列表";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(144, 365, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <div class=""layui-inline"">
                <select id=""branks"" lay-search="""">
                    ");
            EndContext();
            BeginContext(509, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb1ca55f50124ff9982fe7a12d518f1a", async() => {
                BeginContext(526, 11, true);
                WriteLiteral("--可根据品牌搜索--");
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
            BeginContext(546, 5046, true);
            WriteLiteral(@"
                </select>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <div class=""layui-form list-search"" style=""margin-top:10px;"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolAdd""><i class=""layui-icon""></i> 新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolDel""><i class=""layui-icon""></i> 删除</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common','form'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    form = layui.form;
               ");
            WriteLiteral(@" form.render('select');
                table.render({
                    elem: '#tablist',
                    url: '/api/shops/userlist?guid=all',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'userName', title: '姓名', sort: true, fixed: 'left' },
                            { field: 'mobile', title: '手机号码' },
                            { field: 'points', title: '积分数' },
                            { field: 'sex', title: '性别', sort: true },
                            { field: 'regDate', title: '注册时间' },
                            { title: '操作', templet: '#usertool' },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: true,
                    id: 'tables'
                });

                var guid = '', active = {
                    reload: function () {
                   ");
            WriteLiteral(@"     table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#key"").val(),
                                    guid: $(""#branks"").val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    },
                    toolAdd: function () {
                        os.Open('添加会员', '/fytadmin/goods/barcodemodify', '750px', '400px', function () {
                            active.reload();
                        });
                    },
                    toolDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
    ");
            WriteLiteral(@"                        os.error(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/goods/delbarcode/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }");
            WriteLiteral(@"
                            });
                        });

                    }
                };
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑条形码', '/fytadmin/goods/barcodemodify/?guid=' + data.guid, '750px', '400px', function () {
                            active.reload();
                        })
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
    </script>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Member.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Member.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Member.IndexModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Member.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
