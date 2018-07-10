using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BeLife
{
	/// <summary>
	/// Lógica de interacción para ClientMenuView.xaml
	/// </summary>
	public partial class ClientMenuView : Window
	{
		public ClientMenuView()
		{
			InitializeComponent();
		}

		private void Button_Click(Object sender, RoutedEventArgs e)
		{
			var w = new ClientAddView();
			w.Closed += (_, __) => Show();
			Hide();
			w.ShowDialog();
		}

		private void Button_Click_1(Object sender, RoutedEventArgs e)
		{
			var w = new ClientGetView();
			w.Closed += (_, __) => Show();
			Hide();
			w.ShowDialog();
		}
	}
}
