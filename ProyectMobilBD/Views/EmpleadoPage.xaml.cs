using ProyectMobilBD.ViewModels;

namespace ProyectMobilBD.Views;


public partial class EmpleadoPage : ContentPage
{
	public EmpleadoPage(EmpleadoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}