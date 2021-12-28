using NAudio.Wave;
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
        WaveOut waveOut;


        public MainWindow()
        {
            InitializeComponent();
            InitializeKeyboardButtons();
        }



        private void InitializeKeyboardButtons()
        {


            int notesPerOctave = 8;
            int octaves = 4;
            int numButtons = notesPerOctave * octaves;

            spKeys.Children.Clear();

            double currentFrequency = 440;

            for (int i = 0; i < numButtons; i++)
            {
                Button newButton = CreateButton(currentFrequency);
                spKeys.Children.Add(newButton);

                currentFrequency += currentFrequency * Intervals.quart;
            }
        }

        private Button CreateButton(double frequency)
        {
            SignalGenWaveOut waveOut = SignalGenWaveOutFactory.Create(frequency);
            WaveOutContainer.instance.Value.AddWaveOut(waveOut);

            Button newButton = new Button();
            newButton.Content = frequency.ToString();
            newButton.Tag = waveOut;


            newButton.Width = 80;
            newButton.Height = 150;
            newButton.Click += KeyboardKey_Pressed;

            return newButton;
        }

        private void KeyboardKey_Pressed(object sender, RoutedEventArgs e)
        {
            if (sender is not Button senderButton)
                return;

            SignalGenWaveOut waveOut = senderButton.Tag as SignalGenWaveOut;
            waveOut.WaveOut.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WaveOutContainer.instance.Value.StopAll();
        }
    }
}
