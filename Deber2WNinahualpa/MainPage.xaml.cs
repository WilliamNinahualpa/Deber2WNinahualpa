using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Deber2WNinahualpa
{
    public partial class MainPage : ContentPage
    {
        public MainPage(String usuario, String clave)
        {
            InitializeComponent();
            lblUser.Text = usuario;
          
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                //acciones del programa
                double notaSeguimiento1 = Convert.ToDouble(txtNotaSeguimiento1.Text);
                double examen1 = Convert.ToDouble(txtExamen1.Text);
                double notaSeguimiento2 = Convert.ToDouble(txtNotaSeguimiento2.Text);
                double examen2 = Convert.ToDouble(txtExamen2.Text);

                double notaParcial1 = (notaSeguimiento1*0.3)+(examen1*0.2) ;
                txtNotaParcial1.Text = notaParcial1.ToString();

                double notaParcial2 = (notaSeguimiento2 * 0.3) + (examen2 * 0.2);
                txtNotaParcial2.Text = notaParcial2.ToString();

                double notaFinal = notaParcial1 + notaParcial2;
                txtNotaFinal.Text = notaFinal.ToString();

                if (notaFinal >= 7)
                {
                    txtEstado.Text = "Aprobado";
                } else if(notaFinal >=5 && notaFinal<=6.9){
                    txtEstado.Text = "Complementario";
                }
                else if (notaFinal < 7)
                {
                    txtEstado.Text = "Reprobado";
                }
            }
            catch (Exception ex)
            {
                //excepciones - Errores del programa
                DisplayAlert("Alerta", ex.Message, "OK");
            }
        }
    }
}
