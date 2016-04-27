using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Actividad8
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			
			return new CarouselPage {

				Children ={
					new ContentPage{
						Content = new Image
						{
							Source = "http://cursosformarte.com/wp-content/uploads/2016/04/Cursos-online-portada-1.jpg"

						}
					},

					new ContentPage{
						Content = new Image
						{
							Source = "http://bateriaonline.com/wordpress/wp-content/uploads/2013/01/bater%C3%ADa-estandard.png"

						}
					},

					new ContentPage{
						Content = new Image
						{
							Source = "http://devstickers.com/assets/img/pro/2p4i.png"

						}
					},

					new ContentPage{
						Content = new Image
						{
							Source = "http://www.iztacala.unam.mx/rrivas/imagenes/Escudos%20UNAM/logounam.jpg"

						}
					},

					new ContentPage{
						Content = new Image
						{
							Source = "http://www.sefca.com.mx/images/patrocinadores/FCA.png"

						}
					},
				}

			};

		}
	}
}

