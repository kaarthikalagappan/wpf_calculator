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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		long firstNumber = 0;
		long secondNumber = 0;
		sbyte operation = 0;
/*		enum Buttons
		{
			Button MainWindow.btnPLUS = 1,
			btnMINUS,
			btnDIV,
			btnMULT,
			btnMOD 
		}

		Buttons opButtons;*/

		public MainWindow()
		{
			InitializeComponent();
		}

		private void btn1_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10 + 1;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10 + 1;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btn2_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10 + 2;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10 + 2;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btn3_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10 + 3;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10 + 3;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btn4_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10 + 4;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10 + 4;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btn5_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10 + 5;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10 + 5;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btn6_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10 + 6;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10 + 6;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btn7_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10 + 7;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10 + 7;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btn8_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10 + 8;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10 + 8;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btn9_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10 + 9;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10 + 9;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btn0_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber * 10;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber * 10;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private void btnCE_Click(object sender, RoutedEventArgs e)
		{
			operation = 0;
			firstNumber = 0;
			secondNumber = 0;
			numberDisplay.Text = "0";
		}

		private void btnbackspace_Click(object sender, RoutedEventArgs e)
		{
			if (operation == 0)
			{
				firstNumber = firstNumber / 10;
				numberDisplay.Text = firstNumber.ToString();
			}
			else
			{
				secondNumber = secondNumber / 10;
				numberDisplay.Text = secondNumber.ToString();
			}
		}

		private Button findOpButton(sbyte op)
		{
			Button foundButton;
			switch (operation)
			{
				case 1:
					foundButton = btnPLUS;
					break;
				case 2:
					foundButton = btnMINUS;
					break;
				case 3:
					foundButton = btnDIV;
					break;
				case 4:
					foundButton = btnMULT;
					break;
				case 5:
					foundButton = btnMOD;
					break;
				default:
					foundButton = btnPLUS;
					break;
			}
			return foundButton;
		}

		private void deselectButton(Button givenBtn)
		{
			givenBtn.BorderBrush = (Brush)FindResource("borderbutton");
			givenBtn.BorderThickness = new Thickness(1);
		}

		private void selectButton(Button givenBtn)
		{
			givenBtn.BorderThickness = new Thickness(2);
			givenBtn.BorderBrush = new SolidColorBrush(Colors.Black);
		}

		private void operationButton(Button givenBtn, sbyte op)
		{
			if (operation == op && secondNumber == 0)
			{
				operation = 0;
				numberDisplay.Text = firstNumber.ToString();
				deselectButton(givenBtn);
			}
			else
			{
				if (operation != op && operation != 0) {
					Button curButton = findOpButton(operation);
					deselectButton(curButton);
				}
				operation = op;
				selectButton(givenBtn);
			}
		}

		private void btnPLUS_Click(object sender, RoutedEventArgs e)
		{
			operationButton(btnPLUS, 1);
		}

		private void btnMINUS_Click(object sender, RoutedEventArgs e)
		{
			/*if (operation == 2 && secondNumber == 0)
			{
				operation = 0;
				numberDisplay.Text = firstNumber.ToString();
				btnMINUS.BorderBrush = (Brush)FindResource("borderbutton");
			}
			operation = 2;
			btnMINUS.BorderThickness = new Thickness(2);
			btnMINUS.BorderBrush = new SolidColorBrush(Colors.Black);*/
			operationButton(btnMINUS, 2);
		}

		private void btnDIV_Click(object sender, RoutedEventArgs e)
		{
			operationButton(btnDIV, 3);
		}

		private void btnMULT_Click(object sender, RoutedEventArgs e)
		{
			operationButton(btnMULT, 4);
		}

		private void btnMOD_Click(object sender, RoutedEventArgs e)
		{
			operationButton(btnMOD, 5);
		}

		private void btnEQ_Click(object sender, RoutedEventArgs e)
		{
			long finalResult = 0;
			switch (operation)
			{
				case 1:
					finalResult = firstNumber + secondNumber;
					break;
				case 2:
					finalResult = firstNumber - secondNumber;
					break;
				case 3:
					if (secondNumber != 0)
						finalResult = firstNumber / secondNumber;
					else
						finalResult = 0;
					break;
				case 4:
					finalResult = firstNumber * secondNumber;
					break;
				case 5:
					finalResult = firstNumber % secondNumber;
					break;
			}

			numberDisplay.Text = finalResult.ToString();
			deselectButton(findOpButton(operation));
			operation = 0;
			firstNumber = 0;
			secondNumber = 0;
		}

		private void menuClick(object sender, RoutedEventArgs e)
		{
			ContextMenu cm = this.FindResource("cmButton") as ContextMenu;
			if (cm.IsOpen)
			{
				cm.IsOpen = false;
				return;
			}
			cm.PlacementTarget = sender as Button;
			cm.IsOpen = true;
		}

		private void exitApp(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
		private void loadMatrix(object sender, RoutedEventArgs e)
		{
			Window matrix = new Matrices();
			matrix.Show();
			ContextMenu cm = this.FindResource("cmButton") as ContextMenu;
			if (cm.IsOpen)
			{
				cm.IsOpen = false;
				return;
			}
		}
	}
}
