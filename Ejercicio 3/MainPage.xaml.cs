namespace Ejercicio_3;
///<Summary>
///<Createddate>2023/06/19</Createddate>
///<company>SandBox</company>
///<lastmodificationdate>2023/06/21</lastmodificationdate>
///<lastmodificationdescription>
///Agregamos un mensaje de error, con DisplayAlert
///</lastmodificationdescription>
///<lastmodifierautor>Lorena vasquez</lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	/// <summary>
	/// Contrusctor de la clase
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		//definimos variables para las 5 notas y una de resultado
		//luego hacemos una sumatoria de las 5 y las dividimos para que al final 
		//el resultado se muestre en resul.

		if (!string.IsNullOrEmpty(Nota1.Text) && !string.IsNullOrEmpty(Nota2.Text)
			&& !string.IsNullOrEmpty(Nota3.Text) && !string.IsNullOrEmpty(Nota4.Text) 
			&& !string.IsNullOrEmpty(Nota5.Text))
		{

			double nota1, nota2, nota3, nota4, nota5, resultado;
			nota1 = Convert.ToDouble(Nota1.Text);
			nota2 = Convert.ToDouble(Nota2.Text);
			nota3 = Convert.ToDouble(Nota3.Text);
			nota4 = Convert.ToDouble(Nota4.Text);
			nota5 = Convert.ToDouble(Nota5.Text);

			Convert.ToString(resul);
			resultado = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
			resul.Text = Convert.ToString(resultado);
		}
		else
		{
			DisplayAlert("Error", "Introduce todas las calificaciones", "ok");
		}

	}
}

