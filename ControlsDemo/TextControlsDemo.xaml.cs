namespace ControlsDemo;
using System.Diagnostics;


public partial class TextControlsDemo : ContentPage
{
	public TextControlsDemo()
	{
		InitializeComponent();
	}

    private void txtName_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtName_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(txtName.Text);
    }
}