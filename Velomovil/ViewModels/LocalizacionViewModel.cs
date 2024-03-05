using System;
using System.Collections.Generic;
using System.Text;
using Velomovil1.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Velomovil1.ViewModels
{
    public class LocalizacionViewModel : LocalizacionModel
    {
        public Command localizameCommand { get; set; }

        public LocalizacionViewModel()
        {
            localizameCommand = new Command(Localizar);
        }

        private async void Localizar()
        {
            try
            {
                var localizacion = await Geolocation.GetLastKnownLocationAsync();
                if(localizacion == null)
                {
                    localizacion = await Geolocation.GetLocationAsync(
                        new GeolocationRequest()
                        {
                            DesiredAccuracy = GeolocationAccuracy.Medium,
                            Timeout = TimeSpan.FromSeconds(25)
                        });
                }
                if (localizacion == null)
                {
                    Error = "No se donde estoy";
                }
                else
                {
                    Lon = localizacion.Longitude;
                    Lat = localizacion.Latitude;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
