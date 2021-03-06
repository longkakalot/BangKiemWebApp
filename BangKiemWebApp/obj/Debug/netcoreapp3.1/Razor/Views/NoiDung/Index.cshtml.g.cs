#pragma checksum "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f285a0057bd25d2a925e7b1a248c6945463f9b33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NoiDung_Index), @"mvc.1.0.view", @"/Views/NoiDung/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f285a0057bd25d2a925e7b1a248c6945463f9b33", @"/Views/NoiDung/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0721b74a5c60126a5e250f00270ad36bc769c7", @"/Views/_ViewImports.cshtml")]
    public class Views_NoiDung_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DanhMuc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.net core\BANGKIEM\BangKiemWebApp\BangKiemWebApp\Views\NoiDung\Index.cshtml"
  
    ViewData["Title"] = "Nội dung";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""bg-primary text-white"">
        <div class=""card-body"">
            Thêm mới nội dung của bảng kiểm
        </div>
    </div>
    <div class=""card-body"">
        <div class=""row"" id=""divNoidungBangKiem"">
            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-4"">
                <h5>
                    <span class=""badge badge-pill badge-primary"">Chọn bảng kiểm</span>
                </h5>
                <select id=""ddlBangKiem"" class=""ddlSelect2 form-control"" style=""width: 100%"">
                </select>
                <p class=""text-danger"" id=""msgHoatChat"" style=""height: 12px""></p>
            </div>


            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6"">
                <h5>
                    <span class=""badge badge-pill badge-primary"">Nhập nội dung bảng kiểm</span>
                </h5>
                <div class=""input-group mb-3"">
                    <input type=""text"" class=""form-control"" id=""txtNoiDung"" placeholder=""Nội dung");
            WriteLiteral("....\">\r\n");
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-xl-2 col-lg-2 col-md-2 col-sm-2"">
                <h5>
                    <span class=""badge badge-pill badge-primary"">STT</span>
                </h5>
                <div class=""input-group mb-3"">
                    <input type=""text"" class=""form-control"" id=""txtStt"">
                    <input type=""checkbox"" class=""form-control"" id=""ckbStyle"">
                    <div class=""input-group-append"">
                        <button class=""btn btn-success"" id=""btnThemNoiDung"" type=""submit"">Thêm</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div id=""divListNoiDungBangKiem"">

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function DropDownlist(url, element) {
            $.ajax({
                type: ""GET"",
                url: url, //""/Category/GetListDmLoaiMau""
                //data: JSON.stringify(benhNhanInfo),
                //contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function(response) {
                    //alert(response);
                    //$('#' + element).empty(); //loaiMauDropDownList
                    //$(""#loaiMauDropDownList"").prepend(""option value='' selected='selected'></option>"");
                    for (var i = 0; i < response.length; i++) {
                        $('#' + element)
                            .append('<option value=' + response[i].id.toString() + '>' + response[i].ten + '</option > ');
                    };
                },
                failure: function(response) {
                    alert(""Lấy Dropdownlist bảng kiểm thất bại: "" + response.responseText);
              ");
                WriteLiteral(@"  },
                error: function(response) {
                    alert(""Lấy Dropdownlist bảng kiểm error: "" + response.responseText);
                }
            });
        };

        function ThemNoiDung(parameters) {
            $(""#btnThemNoiDung"").click(function() {
                var ddlBangKiem = $(""[id*=ddlBangKiem]"");
                var idBangKiem = (ddlBangKiem.val()).toString();
                //alert(idBangKiem);
                var tenBangKiem = ddlBangKiem.find(""option:selected"").text();
                var tenNoiDung = $(""#txtNoiDung"").val();
                var stt = $(""#txtStt"").val();
                if (tenNoiDung === """") {
                    $(""#txtNoiDung"").focus();
                    swal.fire(""Không được để trống"");
                    return false;
                }
                if (stt === """") {
                    $(""#txtStt"").focus();
                    swal.fire(""Không được để trống"");
                    return false;
                }
    ");
                WriteLiteral(@"            var objNoiDung = {};
                objNoiDung.iddm = idBangKiem;
                objNoiDung.ten = tenNoiDung;
                objNoiDung.stt = stt;

                $.ajax({
                    type: ""POST"",
                    url: ""/NoiDung/Insert"",
                    data: { 'objNoiDung': objNoiDung },
                    //contentType: ""application/x-www-form-urlencoded; charset=utf-8"",
                    dataType: ""text"",
                    success: function (response) {
                        //alert(response);
                        if (response === 1 || response === ""1"") {
                            $(""#txtNoiDung"").focus();
                            $(""#txtNoiDung"").val('');
                            var sttHientai = parseInt($(""#txtStt"").val());
                            var sttMoi = sttHientai + 1;
                            $(""#txtStt"").val(sttMoi);
                            swal.fire(""Thêm mới thành công."");
                            GetAllNoiDun");
                WriteLiteral(@"gBangKiem();
                        } else {
                            swal.fire(""Lỗi khi lưu dữ liệu nội dung bảng kiểm."");
                        }
                    },
                    failure: function (response) {
                        alert(""Thêm nội dung bảng kiểm thất bại: "" + response.responseText);
                    },
                    error: function (response) {
                        alert(""Thêm nội dung bảng kiểm lỗi: "" + response.responseText);
                    }
                });
            });
        };

        function GetAllNoiDungBangKiem(parameters) {
            $.ajax({
                type: ""GET"",
                url: ""/NoiDung/GetAll"",
                //data: { 'objDanhMuc': objDanhMuc },
                //contentType: ""application/x-www-form-urlencoded; charset=utf-8"",
                dataType: ""html"",
                success: function (response) {
                    //alert(response);
                    if (response === 0 || respons");
                WriteLiteral(@"e === ""0"") {
                        swal.fire(""Lấy danh sách nội dung bảng kiểm không thành công."");
                    } else {
                        $(""#divListNoiDungBangKiem"").html(response);
                    }
                },
                failure: function (response) {
                    alert(""Lấy danh sách nội dung bảng kiểm thất bại: "" + response.responseText);
                },
                error: function (response) {
                    alert(""Lấy danh sách nội dung bảng kiểm lỗi: "" + response.responseText);
                }
            });
        };

        $(document).ready(function() {
            GetAllNoiDungBangKiem();
            DropDownlist(""NoiDung/GetListBangKiem"", ""ddlBangKiem"");
            //$('.ddlSelect2').select2();
            ThemNoiDung();
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DanhMuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
