using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace AnimatedLabel
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    protected void btnAnimatelblMessage_Click(object sender, RoutedEventArgs args)
    {
      // Take 4 seconds to complete the animation.
      DoubleAnimation dblAnim = new DoubleAnimation();
      dblAnim.From = 40;
      dblAnim.To = 200;

      // Reverse when done.
      dblAnim.AutoReverse = true;

      // Uncomment the following code statements to test.

      // Loop forever.
      dblAnim.RepeatBehavior = RepeatBehavior.Forever;

      // Loop three times.
      //dblAnim.RepeatBehavior = new RepeatBehavior(3);

      // Loop for 30 seconds.
      //dblAnim.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(30));

      dblAnim.Duration = new Duration(TimeSpan.FromSeconds(4));
      lblHeight.BeginAnimation(Label.HeightProperty, dblAnim);
    }

    protected void btnAnimatelblTransparency_Click(object sender, RoutedEventArgs args)
    {
      // This will change the opacity of the label
      DoubleAnimation dblAnim = new DoubleAnimation();
      dblAnim.From = 1.0;
      dblAnim.To = 0.0;
      dblAnim.Duration = new Duration(TimeSpan.FromSeconds(10));
      lblTransparency.BeginAnimation(Label.OpacityProperty, dblAnim);
    }
  }
}
