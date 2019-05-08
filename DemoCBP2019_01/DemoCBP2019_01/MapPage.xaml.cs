using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.Xamarin.Forms;
using System.Linq;
using Xamarin.Forms;

#if WINDOWS_UWP
using Colors = Windows.UI.Colors;
#else
using Colors = System.Drawing.Color;
#endif


namespace DemoCBP2019_01
{
  public partial class MapPage : ContentPage
  {
    public MapPage()
    {
      InitializeComponent();
    }

    // Map initialization logic is contained in MapViewModel.cs

    private void BotonCentrar_Clicked(object sender, System.EventArgs e)
    {
      // TODO 8. Centrar Mapa
      //var mapPoint = new MapPoint(-74.051331, 4.673646, SpatialReferences.Wgs84);
      //await Mapa.SetViewpointAsync(new Viewpoint(mapPoint, 5000));
    }

    private void Mapa_GeoViewTapped(object sender, GeoViewInputEventArgs e)
    {
      // TODO 7. Dibujar Eventos en el Mapa
      //var graphic = new Graphic()
      //{
      //  Geometry = e.Location,
      //  Symbol = new SimpleMarkerSymbol
      //  {
      //    Color = Colors.Red,
      //    Style = SimpleMarkerSymbolStyle.Diamond,
      //    Size = 20
      //  }
      //};
      //var graphicOverlay = Mapa.GraphicsOverlays.Where(go => go.Id == "Eventos").FirstOrDefault();
      //if(graphicOverlay != null)
      //{
      //  graphicOverlay.Graphics.Add(graphic);
      //}
    }

    private void BotonBorrar_Clicked(object sender, System.EventArgs e)
    {
      // TODO 9. Borrar eventos
      //var graphicOverlay = Mapa.GraphicsOverlays.Where(go => go.Id == "Eventos").FirstOrDefault();
      //if (graphicOverlay != null)
      //{
      //  graphicOverlay.Graphics.Clear();
      //}

    }
  }
}
