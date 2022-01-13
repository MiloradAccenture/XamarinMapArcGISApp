using Esri.ArcGISRuntime.Mapping;
using Xamarin.Forms;

namespace XamarinArcGis
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Map myMap = new Map(Basemap.CreateImagery());
            MyMapView.Map = myMap;
        }
    }
}
