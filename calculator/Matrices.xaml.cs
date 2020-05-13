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

namespace calculator
{
    /// <summary>
    /// Interaction logic for Matrices.xaml
    /// </summary>

    public partial class Matrices : Window
    {
        static int size = 2;
        TextBox[,] matrix1TextBoxes, matrix2TextBoxes;

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            if(! String.IsNullOrEmpty(noOfRows.Text))
            {
                size = int.Parse(noOfRows.Text);
                initializeMatrix();
            }
        }

        private void theDotProduct(object sender, RoutedEventArgs e)
        {
            int tempResult = 0;
            for (int i = 0; i < size; i++)
            {
                for(int j=0; j < size; j++)
                {
                    tempResult += int.Parse(matrix1TextBoxes[i, j].Text) * int.Parse(matrix2TextBoxes[j,i].Text);
                }
            }
            matrix1TextBoxes[0, 0].Text = tempResult.ToString();
        }
        private void matMultiply(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix1TextBoxes[i, j].Text = (int.Parse(matrix1TextBoxes[i, j].Text) * int.Parse(matrix2TextBoxes[i, j].Text)).ToString();
                }
            }
            matrix2Grid.Visibility = System.Windows.Visibility.Hidden;
        }

        public void initializeMatrix()
        {
            matrix1Grid.Children.Clear();
            matrix2Grid.Children.Clear();

            matrix1TextBoxes = new TextBox[size, size];
            matrix2TextBoxes = new TextBox[size, size];

            matrix1Grid.Margin = new Thickness(0, 0, 0, 15);
            matrix1.Height = 30 * 2 * size;
            matrix1.Width = 40 * size;

            for (int i = 0; i < size; i++)
            {
                RowDefinition newRow = new RowDefinition();
                matrix1Grid.RowDefinitions.Add(newRow);
            }
            for (int i = 0; i < size; i++)
            {
                ColumnDefinition newCol = new ColumnDefinition();
                matrix1Grid.ColumnDefinitions.Add(newCol);
            }
            for (int i = 0; i < (size * size); i++)
            {
                TextBox txt = new TextBox();
                txt.MaxWidth = 40;
                txt.Width = 40;
                txt.Height = 25;
                txt.MaxHeight = 25;
                txt.BorderBrush = (Brush)FindResource("borderbutton");
                txt.BorderThickness = new Thickness(1);
                txt.Margin = new Thickness(1, 1, 1, 1);
                txt.Background = (Brush)FindResource("Button");
                txt.Foreground = new SolidColorBrush(Colors.White);
                txt.Text = (i % size).ToString();
                Grid.SetRow(txt, i / size);
                Grid.SetColumn(txt, i % size);
                matrix1TextBoxes[i / size, i % size] = txt;
                matrix1Grid.Children.Add(txt);
            }
            for (int i = 0; i < size; i++)
            {
                RowDefinition newRow = new RowDefinition();
                matrix2Grid.RowDefinitions.Add(newRow);
            }
            for (int i = 0; i < size; i++)
            {
                ColumnDefinition newCol = new ColumnDefinition();
                matrix2Grid.ColumnDefinitions.Add(newCol);
            }
            for (int i = 0; i < (size * size); i++)
            {
                TextBox txt = new TextBox();
                txt.MaxWidth = 40;
                txt.Width = 40;
                txt.Height = 25;
                txt.MaxHeight = 25;
                txt.BorderBrush = new SolidColorBrush(Colors.Black);
                txt.BorderThickness = new Thickness(1);
                txt.Margin = new Thickness(1, 1, 1, 1);
                txt.Background = new SolidColorBrush(Colors.White);
                txt.Text = (i % size).ToString();
                Grid.SetRow(txt, i / size);
                Grid.SetColumn(txt, i % size);
                matrix2TextBoxes[i / size, i % size] = txt;
                matrix2Grid.Children.Add(txt);
            }
            matrix1Grid.Visibility = System.Windows.Visibility.Visible;
            matrix2Grid.Visibility = System.Windows.Visibility.Visible;
        }

        public Matrices()
        {
            InitializeComponent();
            initializeMatrix();

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
        private void SimpleMatrix(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton") as ContextMenu;
            if (cm.IsOpen)
            {
                cm.IsOpen = false;
            }
            this.Close();
        }
    }
}
