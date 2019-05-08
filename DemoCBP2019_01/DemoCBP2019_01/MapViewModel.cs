using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Location;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Security;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.Tasks;
using Esri.ArcGISRuntime.UI;

// TODO 3. Agregar alias a las Bibliotecas de Colores
//#if WINDOWS_UWP
//using Colors = Windows.UI.Colors;
//#else
//using Colors = System.Drawing.Color;
//#endif


namespace DemoCBP2019_01
{
  /// <summary>
  /// Provides map data to an application
  /// </summary>
  public class MapViewModel : INotifyPropertyChanged
  {
    public MapViewModel()
    {
      //TODO: 3. Agregar Código Constructor: 
      //GraphicsOverlayCollection = new GraphicsOverlayCollection()
      //{
      //  new GraphicsOverlay() { Id = "Esri Colombia"},
      //  new GraphicsOverlay() { Id = "Eventos"}
      //};

      //var mapPoint = new MapPoint(-74.051331, 4.673646, SpatialReferences.Wgs84);

      //var graphic = new Graphic()
      //{
      //  Geometry = mapPoint,
      //  Symbol = new SimpleMarkerSymbol
      //  {
      //    Color = Colors.Green,
      //    Style = SimpleMarkerSymbolStyle.Circle,
      //    Size = 10
      //  }
      //};
      //GraphicsOverlayCollection.First().Graphics.Add(graphic);
      //Map.InitialViewpoint = new Viewpoint(mapPoint, 5000);

    }

    private Map _map = new Map(Basemap.CreateStreets());

    /// <summary>
    /// Gets or sets the map
    /// </summary>
    public Map Map
    {
      get { return _map; }
      set { _map = value; OnPropertyChanged(); }
    }

    // TODO: 1. Agregar CapasGraficas y un gráfico
    //private GraphicsOverlayCollection _graphicOverlyaCollection;

    //public GraphicsOverlayCollection GraphicsOverlayCollection
    //{
    //  get { return _graphicOverlyaCollection; }
    //  set { _graphicOverlyaCollection = value; OnPropertyChanged(); }
    //}

    /// <summary>
    /// Raises the <see cref="MapViewModel.PropertyChanged" /> event
    /// </summary>
    /// <param name="propertyName">The name of the property that has changed</param>
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      var propertyChangedHandler = PropertyChanged;
      if (propertyChangedHandler != null)
        propertyChangedHandler(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
