using MahApps.Metro.Controls;
using System;
using System.Windows;

namespace belifeplus
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(Object sender, RoutedEventArgs e)
		{
			var w = new ClientMenuView();
			w.Closed += (_, __) => Show();
			Hide();
			w.ShowDialog();
		}
	}
}
