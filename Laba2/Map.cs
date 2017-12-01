using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System.Drawing;
using System.Threading.Tasks;

namespace Laba2
{
    class Map
    {
        public Map()
        {
            m_overlayMarkers = new GMapOverlay();
            m_overlayRoute = new GMapOverlay();
        }

        public void Init(ref GMapControl gMapControl)
        {
            gMapControl.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl.SetPositionByKeywords("Taganrog, Russia");
            gMapControl.Zoom = 12;
            gMapControl.ShowCenter = false;
        }

        public void DrawMarker(ref GMapControl gMapControl, PointLatLng point)
        {
            GMapMarker marker = new GMarkerGoogle
                (
                    new PointLatLng(point.Lat, point.Lng),
                    GMarkerGoogleType.yellow_small
                    );

            m_overlayMarkers.Markers.Add(marker);
            gMapControl.Overlays.Add(m_overlayMarkers);
            gMapControl.UpdateMarkerLocalPosition(marker);
        }

        public void ClearMarkers()
        {
            m_overlayMarkers.Clear();
        }

        public void DrawRoute(ref GMapControl gMapControl, ref List<PointLatLng> route)
        {
            GMapRoute gmapRoute = new GMapRoute(route, " ");
            gmapRoute.Stroke.Color = Color.Blue;
            m_overlayRoute.Routes.Add(gmapRoute);
            gMapControl.Overlays.Add(m_overlayRoute);
            gMapControl.UpdateRouteLocalPosition(gmapRoute);
        }

        public void ClearRoutes()
        {
            m_overlayRoute.Clear();
        }

        private GMapOverlay m_overlayMarkers;
        private GMapOverlay m_overlayRoute;
    }
}
