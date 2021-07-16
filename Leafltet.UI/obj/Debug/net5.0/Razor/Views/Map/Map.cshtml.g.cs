#pragma checksum "C:\Users\Olcay\source\repos\Leaflet\WebApplication3\Views\Map\Map.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe8814bf50c3a9e5b6a6a3ca9252dd4c6b9cdf66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Map_Map), @"mvc.1.0.view", @"/Views/Map/Map.cshtml")]
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
#line 1 "C:\Users\Olcay\source\repos\Leaflet\WebApplication3\Views\_ViewImports.cshtml"
using Leaflet.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Olcay\source\repos\Leaflet\WebApplication3\Views\_ViewImports.cshtml"
using Leaflet.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8814bf50c3a9e5b6a6a3ca9252dd4c6b9cdf66", @"/Views/Map/Map.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9676f38081f02d250e7250a1583a663489ecd595", @"/Views/_ViewImports.cshtml")]
    public class Views_Map_Map : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/leaflet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Olcay\source\repos\Leaflet\WebApplication3\Views\Map\Map.cshtml"
  
    ViewData["Title"] = "Map";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fe8814bf50c3a9e5b6a6a3ca9252dd4c6b9cdf663924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div id=""mySidenav"" class=""sidenav"">
    <a href=""javascript:void(0)"" class=""closebtn"" onclick=""closeNav()"">&times;</a>

    <ul id=""myUL"">
        <li>
            <span class=""caret"" id=""bolgelerBtn"" onclick=""getBolgeler()"">Bölgeler</span>
            <ul class=""nested"" id=""bolgelerUL"">
                <li>
                    <span class=""caret"">Akdeniz</span>
                    <ul class=""nested"">
                        <li>Getir</li>
                        <li>Banabi</li>
                    </ul>
                </li>

            </ul>
        </li>
    </ul>

</div>
<span class=""navbarBtn"" onclick=""openNav()"">&#9776;</span>

<script>
    var bolgeler = [];
    var subeler = [];
    var toggler = document.getElementsByClassName(""caret"");
    var i;


    for (i = 0; i < toggler.length; i++) {
        toggler[i].addEventListener(""click"", function (event) {
            this.parentElement.querySelector("".nested"").classList.toggle(""active"");
            this.classLi");
            WriteLiteral(@"st.toggle(""caret-down"");
        });
    }


    var bolgeLayer = new L.featureGroup();
    function getBolgeler() {
        if (bolgeler.length > 0) {
            return true;
        }

        $.get(""/Map/GetBolgeler"", function (data, status) {
            var jsonData = JSON.parse(data);
            bolgeler = jsonData;
            jsonData.forEach((bolge) => {
                var bolgeLi = document.createElement('li');
                bolgeLi.setAttribute('id', (""li"" + bolge.bolgeAdi));
                var bolgeSpan = document.createElement('span');
                bolgeSpan.setAttribute('class', 'caret');
                bolgeSpan.setAttribute('id', bolge._id);
                bolgeSpan.setAttribute('bolge', bolge.bolgeAdi);
                bolgeSpan.innerHTML = bolge.bolgeAdi;
                bolgeSpan.setAttribute('isDrawed', 'false');

                //bolgeSpan.addEventListener('click', bolgeClick);
                bolgeSpan.addEventListener(""click"", function (event) {

 ");
            WriteLiteral(@"                   console.log(bolgeSpan.getAttribute('class'));
                    var htmlelem = document.getElementById('subeler' + bolge.bolgeAdi);

                    if (htmlelem == null) {

                        bolgeSpan.setAttribute('isDrawed', 'true');
                        drawBolge(bolgeSpan.getAttribute('id'));
                        getSubeler(event.target.id, bolgeSpan.getAttribute('bolge'));
                    }
                    else {

                        if (bolgeSpan.getAttribute('isDrawed') == 'true') {
                            console.log('ciziliydi');
                            bolgeLayer.clearLayers();
                            subelerLayers.clearLayers();
                            bolgeSpan.setAttribute('isDrawed', 'false');

                        }
                        else {
                            console.log('cizili degildi');
                            drawBolge(bolgeSpan.getAttribute('id'));
                            bolgeSp");
            WriteLiteral(@"an.setAttribute('isDrawed', 'true');
                        }

                        this.parentElement.getElementsByClassName('nested')[0].classList.toggle('active');

                    }

                    this.classList.toggle(""caret-down"");

                });

                bolgeLi.appendChild(bolgeSpan);
                var bolgelerUl = document.getElementById('bolgelerUL');
                bolgelerUl.appendChild(bolgeLi);
            })
        });
    }

    function drawBolge(bolgeId) {
        bolgeler.forEach((bolge) => {
            if (bolge._id == bolgeId) {
                bolgeLayer.clearLayers();

                var geojsonFeature = {
                    ""type"": ""Feature"",
                    ""properties"": {
                        ""name"": ""Coors Field"",
                        ""amenity"": ""Baseball Stadium"",
                        ""popupContent"": ""This is where the Rockies play!"",
                    },
                    ""geometry"": {
             ");
            WriteLiteral(@"           ""type"": bolge.geo.type,
                        ""coordinates"": bolge.geo.coordinates
                    }
                };

                L.geoJSON(geojsonFeature, {
                    style: {
                        color: ""#ff0000"",
                        opacity: 0.2,
                        fillColor: '#ff0000',
                        fillOpacity: 0.2
                    }
                }).addTo(bolgeLayer);

                bolgeLayer.bindPopup().addTo(mymap);
            }
        })
    }


    function getSubeler(bolgeId, bolgeAdi) {

        $.get(""/Map/GetSubeler"", { '_id': bolgeId }, function (data, status) {
            console.log('get subeler function');
            var jsonData = JSON.parse(data);
            subeler = jsonData;
            var subelerUl = document.createElement('ul');
            subelerUl.setAttribute('class', 'nested active');
            subelerUl.setAttribute('id', ('subeler' + bolgeAdi));
            jsonData.forEach((sub");
            WriteLiteral(@"e) => {
                var subeli = document.createElement('li');
                subeli.setAttribute('id', sube._id);
                subeli.setAttribute('subeAdi', sube.subeAdi);
                subeli.innerHTML = sube.subeAdi;
                subeli.setAttribute('isDrawed', 'false');
                subeli.addEventListener('click', function (e) {
                    if (subeli.getAttribute('isDrawed') == 'false') {
                        renderSubeArea(this);
                        subeli.setAttribute('isDrawed', 'true');
                    }
                    else {
                        subelerLayers.clearLayers();
                        subeli.setAttribute('isDrawed', 'false');
                    }
                });
                subelerUl.appendChild(subeli);
            })

            var bolgeLi = document.getElementById('li' + bolgeAdi);
            bolgeLi.appendChild(subelerUl);
        })
    }

    function printSpans() {
        var bolgelerUl = document.");
            WriteLiteral(@"getElementById('bolgelerUL');
        console.log(bolgelerUl);

    }



</script>

<script>
    var xd = 5;
    function openNav() {
        document.getElementById(""mySidenav"").style.width = ""20%"";
    }

    function closeNav() {
        document.getElementById(""mySidenav"").style.width = ""0"";
    }
</script>

<div id=""mapid"">


    <script>

        var subelerLayers = new L.featureGroup();
        function renderSubeArea(e) {

            $.get(""/Map/GetSubeArea"", { '_id': e.getAttribute('id') }, function (data, status) {
                var jsonData = JSON.parse(data);
                subeler = jsonData;


                //mymap.removeLayer(subelerLayers);
                subelerLayers.clearLayers();

                jsonData.forEach((sube) => {
                    var geojsonFeature = {
                        ""type"": ""Feature"",
                        ""properties"": {
                            ""name"": ""Coors Field"",
                            ""amenity"": ""Base");
            WriteLiteral(@"ball Stadium"",
                            ""popupContent"": ""This is where the Rockies play!"",
                            'adi': sube.Adi,
                            'ilAdi': sube.IlAdi,
                            'ilceAdi': sube.IlceAdi,
                            'personelSayisi': sube.PersonelSayisi,
                            'sorumluKisi': sube.SorumluKisi,
                            'subeId': sube.SubeAdi,
                            '_id': sube._id
                        },
                        ""geometry"": {
                            ""type"": sube.Geo.type,
                            ""coordinates"": sube.Geo.coordinates
                        }
                    };
                    L.geoJSON(geojsonFeature).addTo(subelerLayers);
                })

                subelerLayers.bindPopup('Getir').addTo(mymap);
            })
        }

        // create map
        var mymap = L.map('mapid', { zoomControl: false }).setView([41.0113, 29.05], 12);
        L.tileLay");
            WriteLiteral(@"er('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', {
            attribution: '<a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors, Imagery © <a href=""https://www.mapbox.com/"">Mapbox</a>',
            maxZoom: 18,
            id: 'mapbox/streets-v11',
            tileSize: 512,
            zoomOffset: -1,
            accessToken: 'pk.eyJ1Ijoib2xjYXlhcnBhYyIsImEiOiJja3B3YjV1NW8wYzJ1Mm90Y3BuMHMybXphIn0.jHkMd-4j9zKVhWaOXati0A'

        }).addTo(mymap);

        // geomap control panel
        mymap.pm.addControls({
            position: 'topright',

            drawCircle: false,
            drawCircleMarker: false,
            drawRectangle: false,
            cutPolygon: true,
            editPolygon: true,
        });


        // create polygon layers and add popup functionality
        var polygons = new L.featureGroup();
        polygons.bindPopup().addTo(mymap);
        var points = new L.featureGroup();
        p");
            WriteLiteral(@"oints.bindPopup().addTo(mymap);
        var lines = new L.featureGroup();
        lines.bindPopup().addTo(mymap);

        // Polygons: popup open listener
        polygons.on('popupopen', (e) => {
            var popup = e.popup;
            // create div for showing coordinates
            var geoJSON = e.layer.toGeoJSON();
            var geo = L.DomUtil.create('div');
            geo.innerHTML = JSON.stringify(geoJSON.geometry, null, 2) + '\n';

            // create form
            var ilInput = document.createElement('INPUT');
            ilInput.setAttribute('type', 'TEXT');
            ilInput.setAttribute('id', 'IlAdi');
            ilInput.setAttribute('placeholder', 'IlAdi');


            var ilceInput = document.createElement('INPUT');
            ilceInput.setAttribute('type', 'TEXT');
            ilceInput.setAttribute('id', 'IlceAdi');
            ilceInput.setAttribute('placeholder', 'IlceAdi');

            var adInput = document.createElement('INPUT');
            ");
            WriteLiteral(@"adInput.setAttribute('type', 'TEXT');
            adInput.setAttribute('id', 'Adi');
            adInput.setAttribute('placeholder', 'Adi');

            var sorumluInput = document.createElement('INPUT');
            sorumluInput.setAttribute('type', 'TEXT');
            sorumluInput.setAttribute('id', 'SorumluKisi');
            sorumluInput.setAttribute('placeholder', 'SorumluKisi');

            var personelInput = document.createElement('INPUT');
            personelInput.setAttribute('type', 'number');
            personelInput.setAttribute('id', 'PersonelSayisi');
            personelInput.setAttribute('placeholder', 'PersonelSayisi');

            // create button to add to database
            var btn = L.DomUtil.create('button', '', L.DomUtil.create('div'));
            btn.setAttribute('type', 'button');
            btn.innerHTML = 'Add to database';
            // add listener to button
            L.DomEvent.on(btn, 'click', () => sendPolygonToDb(geoJSON));

            // sh");
            WriteLiteral(@"ow popupDiv
            var popupDiv = L.DomUtil.create('div');
            popupDiv.setAttribute('id', 'popupDiv');
            //popupDiv.appendChild(geo);
            popupDiv.appendChild(ilInput);
            popupDiv.appendChild(ilceInput);
            popupDiv.appendChild(adInput);
            popupDiv.appendChild(sorumluInput);
            popupDiv.appendChild(personelInput);

            popupDiv.appendChild(document.createElement('br'))
            popupDiv.appendChild(btn);
            popup.setContent(popupDiv);
        })

        points.on('popupopen', (e) => {
            var geoJSON = e.layer.toGeoJSON();
            var popup = e.popup;
            var btn = L.DomUtil.create('button', '', L.DomUtil.create('div'));
            btn.setAttribute('type', 'button');
            btn.innerHTML = 'Add to database';
            // add listener to button
            L.DomEvent.on(btn, 'click', () => sendPointToDb(geoJSON));
            // show popupDiv
            var popupDiv = ");
            WriteLiteral(@"L.DomUtil.create('div');
            popup.setContent(btn);
        })

        lines.on('popupopen', (e) => {
            var geoJSON = e.layer.toGeoJSON();
            var popup = e.popup;
            var btn = L.DomUtil.create('button', '', L.DomUtil.create('div'));
            btn.setAttribute('type', 'button');
            btn.innerHTML = 'Add to database';
            // add listener to button
            L.DomEvent.on(btn, 'click', () => sendLineToDb(geoJSON));
            // show popupDiv
            var popupDiv = L.DomUtil.create('div');
            popup.setContent(btn);
        })



        mymap.on('pm:create', (e) => {
            if (e.shape == ""Polygon"" || e.shape == ""Poly"" || e.shape == ""Rectangle"") { e.layer.addTo(polygons); }
            else if (e.shape == ""Marker"") { e.layer.addTo(points); }
            else if (e.shape == ""Line"") { e.layer.addTo(lines); }

        });


        function sendPointToDb(geoJSON) {
            $.ajax({
                type: ""POS");
            WriteLiteral(@"T"",
                url: ""/Map/PostPoint"",
                data: JSON.stringify(geoJSON.geometry),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
            });
            mymap.closePopup();
        }

        function sendLineToDb(geoJSON) {
            $.ajax({
                type: ""POST"",
                url: ""/Map/PostLineString"",
                data: JSON.stringify(geoJSON.geometry),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
            });
            mymap.closePopup();
        }


        function sendPolygonToDb(geoJSON) {

            // POST REQUEST HERE
            var geo = {};
            var testPolygon = [];

            polygons.eachLayer(function (layer) {
                if (layer.toGeoJSON().type == ""Feature"") {
                    //console.log(""Feature"");
                    //console.log(layer.toGeoJSON());
                    testPolygon.push(la");
            WriteLiteral(@"yer.toGeoJSON().geometry.coordinates);
                }
            });

            if (testPolygon.length == 1) {
                geo.type = ""Polygon"";
                geo.coordinates = testPolygon[0];
            }
            else {
                geo.type = ""MultiPolygon"";
                geo.coordinates = testPolygon;
            }

            var subeInfo = {
                ""IlAdi"": document.getElementById('IlAdi').value,
                ""IlceAdi"": document.getElementById('IlceAdi').value,
                ""Adi"": document.getElementById('Adi').value,
                ""SorumluKisi"": document.getElementById('SorumluKisi').value,
                ""PersonelSayisi"": document.getElementById('PersonelSayisi').value,
                ""Geo"": geo
            }

            console.log(JSON.stringify(subeInfo));
            // post request to controller
            $.ajax({
                type: ""POST"",
                url: (""/Map/Post"" + geo.type + ""Sube""),
                data: JSON.s");
            WriteLiteral(@"tringify(subeInfo),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
            });


            polygons.clearLayers();
            mymap.closePopup();

        }







        // function to handle bug of ""popup opening on remove event""
        mymap.on('pm:remove', (e) => {
            setTimeout(function () {
                mymap.closePopup();
            }, 10);


        });


        // close popup, when clicked to outside of popup
        $(document).mouseup(function (e) {
            var container = $('#popupDiv');

            // if the target of the click isn't the container nor a descendant of the container
            if (!container.is(e.target) && container.has(e.target).length === 0) {
                mymap.closePopup();
            }
        });

    </script>
</div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
