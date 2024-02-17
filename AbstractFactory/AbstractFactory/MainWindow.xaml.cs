using AbstractFactory.Factory;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
namespace AbstractFactory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Client client;
        private FactoryBlack factoryBlack = new FactoryBlack();
        private FactoryOrange factoryOrange = new FactoryOrange();
        public MainWindow()
        {
            InitializeComponent();
            client = new Client(factoryBlack);
        }
        int x = 0;
        int y = 0;
        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            if (cmbColors.SelectedItem != null)
            {
                var comboItem = cmbColors.SelectedItem as ComboBoxItem;
                if (comboItem != null)
                {
                    var textBlock = comboItem.Content as TextBlock;
                    if (textBlock != null)
                    {
                        switch (textBlock.Text)
                        {
                            case "Black Square":
                                client.ChangeFactory(factoryBlack);
                                var a = client.CreateSquare(30);
                                System.Drawing.Color color3 = a.GetColor();
                                System.Windows.Media.Color newColor3 = System.Windows.Media.Color.FromArgb(color3.A, color3.R, color3.G, color3.B);
                                SolidColorBrush col3 = new SolidColorBrush(newColor3);
                                System.Windows.Shapes.Rectangle rectangle = new System.Windows.Shapes.Rectangle
                                {
                                    Width = a.GetSideSize(),
                                    Height = a.GetSideSize(),
                                    Fill = col3
                                };
                                CanvasCreator.Children.Add(rectangle);
                                Canvas.SetLeft(rectangle, x);
                                Canvas.SetTop(rectangle, y);
                                x += a.GetSideSize();
                                break;
                            case "Orange Square":
                                client.ChangeFactory(factoryOrange);
                                var b = client.CreateSquare(20);
                                System.Drawing.Color color2 = b.GetColor();
                                System.Windows.Media.Color newColor2 = System.Windows.Media.Color.FromArgb(color2.A, color2.R, color2.G, color2.B);
                                SolidColorBrush col2 = new SolidColorBrush(newColor2);
                                System.Windows.Shapes.Rectangle rectangle1 = new System.Windows.Shapes.Rectangle
                                {
                                    Width = b.GetSideSize(),
                                    Height = b.GetSideSize(),
                                    Fill = col2
                                };
                                CanvasCreator.Children.Add(rectangle1);
                                Canvas.SetLeft(rectangle1, x);
                                Canvas.SetTop(rectangle1, y);
                                x += b.GetSideSize();
                                break;
                            case "Orange Circle":
                                client.ChangeFactory(factoryOrange);
                                var c = client.CreateCircle(20);
                                System.Drawing.Color color1 = c.GetColor();
                                System.Windows.Media.Color newColor1 = System.Windows.Media.Color.FromArgb(color1.A, color1.R, color1.G, color1.B);
                                SolidColorBrush col1 = new SolidColorBrush(newColor1);
                                Ellipse circle = new Ellipse
                                {
                                    Width = c.GetRadius(),
                                    Height = c.GetRadius(),
                                    Fill = col1

                                };
                                CanvasCreator.Children.Add(circle);
                                Canvas.SetLeft(circle, x);
                                Canvas.SetTop(circle, y);
                                x += c.GetRadius();
                                break;
                            case "Black Circle":
                                client.ChangeFactory(factoryBlack);
                                var d = client.CreateCircle(50);
                                System.Drawing.Color color = d.GetColor();
                                System.Windows.Media.Color newColor = System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
                                SolidColorBrush col = new SolidColorBrush(newColor);
                                Ellipse circle1 = new Ellipse
                                {
                                    Width = d.GetRadius(),
                                    Height = d.GetRadius(),
                                    Fill = col

                                };
                                // This is your color to convert from
                                // This is your color to convert from
                                
                                CanvasCreator.Children.Add(circle1);
                                Canvas.SetLeft(circle1, x);
                                Canvas.SetTop(circle1, y);
                                x += d.GetRadius();
                                break;

                        }
                    }
                }
            }
        }
    }
}
