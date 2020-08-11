#pragma checksum "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb3625feb434d0c5d8dbab2316b9b05f4d40121b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BangKiem_NhapBangKiem), @"mvc.1.0.view", @"/Views/BangKiem/NhapBangKiem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3625feb434d0c5d8dbab2316b9b05f4d40121b", @"/Views/BangKiem/NhapBangKiem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0721b74a5c60126a5e250f00270ad36bc769c7", @"/Views/_ViewImports.cshtml")]
    public class Views_BangKiem_NhapBangKiem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BangKiemWebApp.ViewModels.NoiDungViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
  
    ViewData["Title"] = "NhapBangKiem";
    var stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bảng kiểm ");
#nullable restore
#line 7 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
         Write(Model.Select(m => m.TenBangKiem).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<div class=""card"">
    <div class=""bg-primary text-white"">
        <div class=""card-body"">
            Thông tin bệnh nhân
        </div>
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6"">
                <div class=""input-group mb-3"">
                    <input type=""text"" class=""form-control"" id=""txtMaBn"" placeholder=""Nhập mã bn..."">
                    <div class=""input-group-append"">
                        <button class=""btn btn-success"" id=""btnGetInfoBn"" type=""submit"">Lấy thông tin</button>
                    </div>
                </div>
            </div>
        </div>
        <div id=""divInfoBn"" class=""row"">
            <div></div>
        </div>
    </div>
</div>

<div id=""divNhapNoiDungBk"" class=""card"">
    <div class=""bg-primary text-white"">
        <div class=""card-body"">
            Nhập nội dung bảng kiểm ");
#nullable restore
#line 34 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                               Write(Model.Select(m => m.TenBangKiem).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""table-responsive"">
                <table class=""table table-striped table-bordered table-hover"" id=""tblNoiDungBangKiem"" width=""100%"">
                    <thead class=""thead-light"">
                        <tr role=""row"">
                            <th style=""width:2%"" aria-controls=""example"">STT</th>
                            <th style=""width: 94%"" aria-controls=""example"">Nội dung</th>
                            <th style=""width: 4%"" aria-controls=""example"">Điểm</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 49 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 52 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                                Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                                 if (item.Style == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color:red\">");
#nullable restore
#line 55 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                                                     Write(item.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 56 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color:blue\">");
#nullable restore
#line 59 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                                                      Write(item.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 60 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <div id=\"chkboxScore\">\r\n                                        <input id=\"ckbDiem\" type=\"checkbox\" class=\"form-control\" name=\"Diem\" />\r\n                                    </div>\r\n");
            WriteLiteral("                                    <p");
            BeginWriteAttribute("hidden", " hidden=\"", 2833, "\"", 2842, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"pStyle\">");
#nullable restore
#line 66 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                                                        Write(item.Style);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p");
            BeginWriteAttribute("hidden", " hidden=\"", 2911, "\"", 2920, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"pIdNoiDung\">");
#nullable restore
#line 67 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 70 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\BangKiem\NhapBangKiem.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        
                    </tbody>
                </table>

                <table class=""table table-striped table-bordered table-hover"" width=""100%"">
                    <tbody>
                    <tr>
                        <td colspan=""3"">
                            <h4 class=""float-right"">
                                <span id=""span2"" class=""badge badge-primary ml-2""></span>
                            </h4>
                        </td>
                    </tr>
                    <tr>
                        <td colspan=""3"">
                            <input type=""button"" id=""btnLuuNoiDung"" value=""Lưu thông tin"" class=""btn btn-primary float-right"" />

                        </td>

                    </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function GetInfoBn(parameters) {
            $(""#btnGetInfoBn"").click(function() {
                var maBn = $(""#txtMaBn"").val();
                $.ajax({
                    type: ""GET"",
                    url: ""/BangKiem/GetInfoBn"",
                    data: { 'maBn': maBn },
                    //contentType: ""application/x-www-form-urlencoded; charset=utf-8"",
                    dataType: ""html"",
                    success: function(response) {
                        //alert(response);
                        if (response === 0 || response === ""0"") {
                            swal.fire(""Bệnh nhân không có hiện diện tại khoa."");
                        } else {
                            $(""#divInfoBn"").html(response);
                            $(""#divNhapNoiDungBk"").show();
                        }
                    },
                    failure: function(response) {
                        alert(""Lấy thông tin BN thất bại: "" + response.responseText)");
                WriteLiteral(@";
                    },
                    error: function(response) {
                        alert(""Lấy thông tin BN lỗi: "" + response.responseText);
                    }
                });
            });
        };

        function Luu(parameters) {
            //var maBn = $(""#txtMaBn"").val();
            //var hotenBn = $(""#txtHoTenBn"").text();
            //var namSinh = $(""#txtNamSinh"").text();
            //var phai = $(""#txtPhai"").text();
            //var maicd = $(""#txtMaIcd"").text();
            //var benhChinh = $(""#txtChanDoan"").text();
            //var khoa = $(""#txtKhoa"").text();
            $(""#btnLuuNoiDung"").click(function() {
                var objNoiDungs = new Array();
                var obj = {};
                var status;
                $(""#tblNoiDungBangKiem TBODY TR"").each(function() {
                    var row = $(this);
                    var noidungs = {};
                    var idNoiDung = row.find(""#pIdNoiDung"").text();
                   ");
                WriteLiteral(@" var style = row.find(""#pStyle"").text();
                    noidungs.IdNoiDung = idNoiDung;
                    //obj1.diem = row.find(""td:eq(3) input[type='checkbox']"").val();
                    //obj1.diem1 = row.find(""td:eq(3) input[name='Diem']:checked"").val();
                    if (row.find(""#ckbDiem"").prop(""checked"") === true) {
                        noidungs.diem = 1;
                        //console.log(""Có"");
                    } else {
                        noidungs.diem = 0;
                        //console.log(""Không Có"");
                    }

                    if (style === ""1"" && noidungs.diem === 0) {
                        status = 2; //không đạt
                    }

                    objNoiDungs.push(noidungs);
                });
                console.log(objNoiDungs);
                obj.maBn = $(""#txtMaBn"").val();
                obj.hotenBn = $(""#txtHoTenBn"").text();
                obj.namSinh = $(""#txtNamSinh"").text();
                obj.phai");
                WriteLiteral(@" = $(""#txtPhai"").text();
                obj.maicd = $(""#txtMaIcd"").text();
                obj.benhChinh = $(""#txtChanDoan"").text();
                obj.tenkhoaphong = $(""#txtKhoa"").text();
                obj.mavaovien = $(""#pMaVaoVien"").text();
                obj.maql = $(""#pMaQl"").text();
                obj.status = status;
                console.log(obj);
                $.ajax({
                    type: ""POST"",
                    url: ""/BangKiem/Insert"",
                    //data: JSON.stringify(objArr),
                    data: { 'obj': obj, 'objNoiDungs' : objNoiDungs },
                    //contentType: ""application/json; charset=utf-8"",
                    dataType: ""text"",
                    success: function(responses) {
                        if (responses === 0 || responses === ""0"") {
                            swal.fire(""Lỗi khi lưu dữ liệu"", """", ""success"");
                        } else {
                            swal.fire(""Thêm thành công"", """", ""success"").the");
                WriteLiteral(@"n(function() {
                                var url = ""/BangKiem/Index"";
                                window.location.href = url;
                            });
                        }
                    },
                    failure: function(response) {
                        alert(""failure: Insert chi tiết bảng kiểm"" + response.responseText);
                    },
                    error: function(response) {
                        alert(""error: Insert chi tiết bảng kiểm"" + response.responseText);
                    }
                });

            });
        };

        $(document).ready(function() {
            $(""#divNhapNoiDungBk"").hide();
            $(""#txtMaBn"").focus();
            GetInfoBn();

            $(""#chkboxScore"").click(function() {
                var countChecked = function() {
                    var n = $(""#chkboxScore input:checked"").length;
                    $(""#span2"").text(n + ("" "") + "" điểm"");
                };
                co");
                WriteLiteral("untChecked();\r\n                $(\"#chkboxScore input[type=checkbox]\").on(\"click\", countChecked);\r\n            });\r\n            Luu();\r\n        });\r\n    </script>\r\n");
            }
            );
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