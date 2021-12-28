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

namespace MusikzMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            InitializeKeyboardButtons();
        }

        private void InitializeKeyboardButtons()
        {
            int notesPerOctave = 12;
            int octaves = 4;
            int numButtons = notesPerOctave * octaves;

            spKeys.Children.Clear();

            for (int i = 0; i < numButtons; i++)
            {
                Button newButton = CreateButton(440);
                spKeys.Children.Add(newButton);
            }
        }

        private Button CreateButton(double frequency)
        {
            Button newButton = new Button();
            newButton.Content = "X";
            newButton.Tag = new ToneInfo { frequency = frequency };

            newButton.Width = 80;
            newButton.Height = 150;
            newButton.Click += KeyboardKey_Pressed;

            return newButton;
        }

        private void KeyboardKey_Pressed(object sender, RoutedEventArgs e)
        {
            if (sender is not Button senderButton)
                return;


        }
    }
}
