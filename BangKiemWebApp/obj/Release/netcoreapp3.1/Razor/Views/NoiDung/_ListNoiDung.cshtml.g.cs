#pragma checksum "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574228c3180b21ce1407d123da45f157de3a6e3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NoiDung__ListNoiDung), @"mvc.1.0.view", @"/Views/NoiDung/_ListNoiDung.cshtml")]
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
#line 1 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\_ViewImports.cshtml"
using BangKiemWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\_ViewImports.cshtml"
using BangKiemWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574228c3180b21ce1407d123da45f157de3a6e3e", @"/Views/NoiDung/_ListNoiDung.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0721b74a5c60126a5e250f00270ad36bc769c7", @"/Views/_ViewImports.cshtml")]
    public class Views_NoiDung__ListNoiDung : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BangKiemWebApp.ViewModels.NoiDungViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
  
    var stt = 0;
    var tenBangKiem = Model
        .GroupBy(m => new
        {
            m.TenBangKiem, m.Iddm
        })
        .Select(m => new
        {
            m.Key.Iddm, m.Key.TenBangKiem
        });

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""bg-primary text-white"">
        <div class=""card-body"">
            Danh sách nội dung bảng kiểm
        </div>
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <table class=""table table-striped table-bordered table-responsive"" id=""tblListNoiDung"" style=""width: 100%"">
                <thead>
                <tr>
                    <th style=""width: 1%; text-align: center"">STT</th>
");
            WriteLiteral(@"                    <th style=""width: 40%;"">Tên nội dung</th>
                    <th style=""width: 10%;"">STT hiển thị</th>
                    <th style=""width: 10%"">Ngày cập nhật</th>
                    <th style=""width: 20%;"">Trạng thái</th>
                    <th style=""width: 10%;"">Người nhập</th>
                    <th style=""width: 10%"">#</th>
                </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 40 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                 foreach (var item in tenBangKiem)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr style=\"background-color: lightblue; color: white\">\r\n                        <td colspan=\"7\" >");
#nullable restore
#line 43 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                    Write(item.TenBangKiem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            \r\n                    </tr>\r\n");
#nullable restore
#line 46 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                     foreach (var item1 in Model.Where(m => m.Iddm == item.Iddm).OrderBy(m=>m.Stt))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td></td>\r\n");
#nullable restore
#line 50 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                     if (item1.HideNoiDung == 0 && item1.Style == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"color: green\">\r\n                            <p id =\"pTenNoiDung\">");
#nullable restore
#line 53 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                            Write(item1.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </td>\r\n                        <td style=\"color: green\"><p id=\"pSttNoiDung\">");
#nullable restore
#line 55 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                                                Write(item1.Stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                        <td style=\"color: green\">");
#nullable restore
#line 56 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                            Write(item1.NgayUd.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"color: green\">Còn sử dụng</td>\r\n                        <td style=\"color: green\">");
#nullable restore
#line 58 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                            Write(item1.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 59 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"

                    }
                    else if (item1.HideNoiDung == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"color: blue\">\r\n                            <p id=\"pTenNoiDung\">");
#nullable restore
#line 64 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                           Write(item1.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </td>\r\n                        <td style=\"color: blue\"><p id=\"pSttNoiDung\">");
#nullable restore
#line 66 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                                               Write(item1.Stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                        <td style=\"color: blue\">");
#nullable restore
#line 67 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                           Write(item1.NgayUd.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"color: blue\">Còn sử dụng</td>\r\n                        <td style=\"color: blue\">");
#nullable restore
#line 69 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                           Write(item1.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 70 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"color: red\"><p id=\"pTenNoiDung\">");
#nullable restore
#line 73 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                                              Write(item1.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                        <td style=\"color: red\"><p id=\"pSttNoiDung\">");
#nullable restore
#line 74 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                                              Write(item1.Stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                        <td style=\"color: red\">");
#nullable restore
#line 75 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                          Write(item1.NgayUd.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"color: red\">Đã khóa</td>\r\n                        <td style=\"color: red\">");
#nullable restore
#line 77 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                          Write(item1.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 78 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>\r\n                    <p id=\"pId\"");
            BeginWriteAttribute("hidden", " hidden=\"", 3499, "\"", 3508, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                     Write(item1.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p id=\"pHideNoiDung\"");
            BeginWriteAttribute("hidden", " hidden=\"", 3565, "\"", 3574, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                              Write(item1.HideNoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p id=\"pStyle\"");
            BeginWriteAttribute("hidden", " hidden=\"", 3634, "\"", 3643, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                                        Write(item1.Style);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <i class=\"fas fa-edit iEditNoidung\" style=\"color: blue; font-weight: bold; font-size: 24px\" aria-hidden=\"true\" title=\"Sửa\"></i>\r\n");
#nullable restore
#line 85 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                     if (item1.HideNoiDung == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fa fa-lock btnLockNoidung\" style=\"color: red; font-weight: bold; font-size: 24px\" aria-hidden=\"true\" title=\"Khóa\"></i>\r\n");
#nullable restore
#line 88 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                         if (item1.Style == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-palette btnStyleBlue\" style=\"color: blue; font-weight: bold; font-size: 24px\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 91 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-palette btnStyleGreen\" style=\"color: green; font-weight: bold; font-size: 24px\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 95 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fa fa-unlock btnUnLockNoidung\" style=\"color: red; font-weight: bold; font-size: 24px\" aria-hidden=\"true\" title=\"Mở Khóa\"></i>\r\n");
#nullable restore
#line 101 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </td>\r\n                </tr>\r\n");
#nullable restore
#line 106 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\_ListNoiDung.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n\r\n");
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n    \r\n");
            WriteLiteral(@"    <script>
        function UpdateTrangThaiNoiDungBK(button) {
            $(""#tblListNoiDung"").on('click', '.' + button, function() {
                var currentRow = $(this).closest(""tr"");
                var objNoiDung = {};
                //alert(button);
                var id = (currentRow.find('#pId').text());
                var hide = (currentRow.find('#pHideNoiDung').text());
                var style = (currentRow.find('#pStyle').text());
                var tenNoiDung = (currentRow.find('#pTenNoiDung').text());
                var stt = (currentRow.find('#pSttNoiDung').text());

                if (button === ""btnStyleBlue"" || button === ""btnStyleGreen"") {
                    objNoiDung.id = id;
                    objNoiDung.style = style;
                    objNoiDung.hide = 3;
                } else if (button === ""btnLockNoidung"" || button === ""btnUnLockNoidung"") {
                    objNoiDung.id = id;
                    objNoiDung.hide = hide;
                    obj");
            WriteLiteral(@"NoiDung.style = 3;
                } else {
                    objNoiDung.id = id;
                    objNoiDung.ten = tenNoiDung;
                    objNoiDung.stt = stt;
                }

                //objNoiDung.id = id;
                //objNoiDung.hide = hide;
                //objNoiDung.style = style;
                $.ajax({
                    type: ""POST"",
                    url: ""/NoiDung/Update"",
                    data: { 'objNoiDung': objNoiDung },
                    //contentType: ""application/x-www-form-urlencoded; charset=utf-8"",
                    dataType: ""text"",
                    success: function(response) {
                        //alert(response);
                        if (response === 1 || response === ""1"") {
                            //$(""#txtTenBangKiem"").focus();
                            //$(""#txtTenBangKiem"").val('');
                            //swal.fire(""Thêm mới thành công."");
                            GetAllNoiDungBangKiem();
  ");
            WriteLiteral(@"                      } else {
                            swal.fire(""Lỗi khi đổi trạng thái nội dung BK."");
                        }
                    },
                    failure: function(response) {
                        alert(""Cập nhật trạng thái nội dung BK thất bại: "" + response.responseText);
                    },
                    error: function(response) {
                        alert(""Cập nhật trạng thái nội dung BK lỗi: "" + response.responseText);
                    }
                });
                //alert(id + ""_"" + hide);
            });
        };

        function EditNoiDungBk(button) {
            $(""#tblListNoiDung"").on('click',
                '.' + button,
                function() {
                    var currentRow = $(this).closest(""tr"");
                    var objNoiDung = {};
                    
                    var id = (currentRow.find('#pId').text());
                    var tenNoiDung = (currentRow.find('#pTenNoiDung').text());
   ");
            WriteLiteral(@"                 var stt = (currentRow.find('#pSttNoiDung').text());

                    swal.fire({
                        title: 'Nhập tên và STT nội dung cần sửa',
                        //input: 'html',
                        //inputValue: ten,
                        showCancelButton: true,
                            html:
                                '<input id=""swal-input1"" class=""swal2-input""' +
                                    ' value=' +
                                    '""' +
                                    tenNoiDung +
                                    '""' +
                                    '/>' +
                                    '<input id=""swal-input2"" class=""swal2-input""' +
                                    ' value=' +
                                    '""' +
                                    stt +
                                    '""' +
                                    '/>',
                        inputValidator: (value) => {
           ");
            WriteLiteral(@"                 if (!value) {
                                return 'Không được để trống!.';
                            }
                        }
                    }).then((result) => {
                        if (result.value) {
                            //alert($(""#swal-input1"").val());
                            objNoiDung.ten = $(""#swal-input1"").val();
                            objNoiDung.stt = $(""#swal-input2"").val();
                            objNoiDung.id = id;
                            objNoiDung.style = 3;
                            objNoiDung.hide = 3;
                            $.ajax({
                                type: ""POST"",
                                url: ""/NoiDung/Update"",
                                data: { 'objNoiDung': objNoiDung },
                                //contentType: ""application/x-www-form-urlencoded; charset=utf-8"",
                                dataType: ""text"",
                                success: function (response) {
");
            WriteLiteral(@"                                    //alert(response);
                                    if (response === 1 || response === ""1"") {
                                        GetAllNoiDungBangKiem();
                                    } else {
                                        swal.fire(""Lỗi khi cập nhật nội dung bảng kiếm."");
                                    }
                                },
                                failure: function (response) {
                                    alert(""Cập nhật nội dung bảng kiểm thất bại: "" + response.responseText);
                                },
                                error: function (response) {
                                    alert(""Cập nhật nội dung bảng kiểm lỗi: "" + response.responseText);
                                }
                            });
                        }
                    });

                });
        };

        $(document).ready(function() {
            UpdateTrangThaiNoiDungBK");
            WriteLiteral(@"(""btnLockNoidung"");
            UpdateTrangThaiNoiDungBK(""btnUnLockNoidung"");
            UpdateTrangThaiNoiDungBK(""btnStyleBlue"");
            UpdateTrangThaiNoiDungBK(""btnStyleGreen"");
            EditNoiDungBk(""iEditNoidung"");
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BangKiemWebApp.ViewModels.NoiDungViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
