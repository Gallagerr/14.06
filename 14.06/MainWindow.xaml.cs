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
using Microsoft.Win32;
using System.IO;

namespace _14._06
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    var WMP = new MediaPlayer();
    public MainWindow()
    {
      InitializeComponent();
    }
    private void Save_Click(object sender, RoutedEventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      if (saveFileDialog.ShowDialog() == true)
        File.WriteAllText(saveFileDialog.FileName, textbox.Text);
    }

    private void OnMusic_Click(object sender, RoutedEventArgs e)
    {
      WMP.URL = @"C:\Users\ШахпутовГ\source\repos\14.06\14.06\Tim McMorris – On Top of The World.mp3"; // файл музыкальный
      WMP.settings.volume = 100; // меняя значение можно регулировать громкость
      WMP.controls.play(); // Старт
    }

    private void OffMusic_Click(object sender, RoutedEventArgs e)
    {
      WMP.controls.stop(); // Стоп
    }
  }
}
