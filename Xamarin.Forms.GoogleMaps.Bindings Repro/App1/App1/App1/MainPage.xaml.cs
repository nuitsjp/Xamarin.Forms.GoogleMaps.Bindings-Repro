using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace App1
{
	public partial class MainPage : ContentPage
	{
        public ObservableCollection<Pin> Pins
        {
            get { return (ObservableCollection<Pin>)GetValue(PinsProperty); }
            set { SetValue(PinsProperty, value); }
        }
        public static readonly BindableProperty PinsProperty = BindableProperty.Create(
            propertyName: "Pins",
            returnType: typeof(ObservableCollection<Pin>),
            declaringType: typeof(MainPage),
            defaultValue: new ObservableCollection<Pin>(),
            defaultBindingMode: BindingMode.OneWay
        );
        public MainPage()
		{
			InitializeComponent();
            Pins = new ObservableCollection<Pin>()
            {
                new Pin(){
                    Label = "Test1",
                    Address ="1, rue Lala",
                    Position = new Position(49.628222, 6.164697)
                },
                new Pin(){
                    Label = "Test2",
                    Address ="1, rue Lala",
                    Position = new Position(49.627166, 6.162937)
                },
                new Pin(){
                    Label = "Test3",
                    Address ="1, rue Lala",
                    Position = new Position(49.627360, 6.164944)
                }
            };
        }
    }
}
