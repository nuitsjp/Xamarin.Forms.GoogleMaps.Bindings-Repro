using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;
using Xamarin.Forms.Xaml;

    public partial class MapView : Map
    {
        public MoveToRegionRequest MoveToRegionRequest { get; } = new MoveToRegionRequest();
        public MapView()
        {
            InitializeComponent();
        }
    }

