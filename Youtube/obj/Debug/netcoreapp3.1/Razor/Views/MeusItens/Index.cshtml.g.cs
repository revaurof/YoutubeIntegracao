#pragma checksum "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f92179b82662b08ecfe3edeafe395176d2d9f33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MeusItens_Index), @"mvc.1.0.view", @"/Views/MeusItens/Index.cshtml")]
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
#line 1 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\_ViewImports.cshtml"
using Youtube;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\_ViewImports.cshtml"
using Youtube.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f92179b82662b08ecfe3edeafe395176d2d9f33", @"/Views/MeusItens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340e001e5d569f7e7581106f15aa0889296c14b9", @"/Views/_ViewImports.cshtml")]
    public class Views_MeusItens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Youtube.Models.YoutubeResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Meus vídeos</h1>

<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/vue""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/axios/0.19.2/axios.min.js"" integrity=""sha256-T/f7Sju1ZfNNfBh7skWn0idlCBcI3RwdLSS4/I7NQKQ="" crossorigin=""anonymous""></script>


<div id=""app"">
    <div v-if=""loading"" style=""width: 100%; height: 100%; top: 0;left: 0; position:fixed; display:block; opacity:0.7; background-color:#fff; z-index:99; text-align:center;"">
        <div class=""spinner-border"" role=""status"" style=""position:absolute; top:50%; left:50%; z-index:100;"">
            <span class=""sr-only"">Loading...</span>
        </div>
    </div>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Imagem
                </th>
                <th>
                    Tipo
                </th>
                <th>
                    Titulo
                </th>
                <th");
            WriteLiteral(@">
                    Publicado em
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr v-for=""(item, key) in videos"">
                <td>
                    <a v-if=""item.type == 1"" :href=""'https://www.youtube.com/watch?v='+item.youtubeId"" target=""_blank""><img width=""80"" :src=""item.thumbnails"" /></a>
                    <img width=""80"" v-else :src=""item.thumbnails"" />
                </td>
                <td>
                    <span v-if=""item.type == 0"">Canal</span>
                    <span v-if=""item.type == 1"">Video</span>
                    <span v-if=""item.type == 2"">Playlist</span>
                </td>
                <td>
                    {{ item.title }}
                </td>
                <td>
                    {{ item.publishedAt }}
                </td>
                <td>
                    <a :href=""'/MeusItens/detalhes/'+item.id"" class=""btn btn-info"">Detalhes</a>
                    <button ");
            WriteLiteral(@"@click=""Excluir(key,item.id)"" class=""btn btn-danger"">Excluir</button>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<script>
    var app = new Vue({
        el: '#app',
        data() {
            return { videos: null, loading: false }
        },
        mounted() {
            this.loading = true;
            axios
                .get('/MeusItens/GetVideos')
                .then(response => (this.videos = response.data));
            this.loading = false;
        },
        methods: {
            Excluir(key, id) {
                this.loading = true;
                $.ajax({
                    type: ""GET"",
                    url: '/MeusItens/DeleteFromVue/' + id,
                    dataType: ""json"",
                    contentType: ""application/json; charset=utf-8"",
                    success: function (retorno) {
                    },
                    error: function (ex) {
                    }
                });
                s");
            WriteLiteral(@"wal({
                    icon: 'success',
                    title: 'Excluido com sucesso',
                    buttons: false,
                    timer: 1500
                });
                this.videos.splice(key, 1);
                this.loading = false;
            }
        }
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Youtube.Models.YoutubeResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591