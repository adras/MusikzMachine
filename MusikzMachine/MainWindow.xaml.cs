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


            //int notesPerOctave = 8;
            //int octaves = 4;
            //int numButtons = notesPerOctave * octaves;

            //spKeys.Children.Clear();

            //double currentFrequency = 440;

            //for (int i = 0; i < numButtons; i++)
            //{
            //    Button newButton = CreateButton(currentFrequency);
            //    spKeys.Children.Add(newButton);

            //    currentFrequency += currentFrequency * Intervals.quart;
            //}

            double[] frequencies = new double[] { 264, 297,330, 352, 396, 440, 495, 528 };
            for (int i = 0; i < frequencies.Length; i++)
            {
                Button newButton = CreateButton(frequencies[i]);
                spKeys.Children.Add(newButton);

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
            // https://stackoverflow.com/questions/33693676/mousedown-up-events-not-working-properly-in-wpf
            newButton.PreviewMouseDown += NewButton_MouseDown;
            newButton.PreviewMouseUp += NewButton_MouseUp;
            //newButton.MouseLeftButtonDown += NewButton_MouseDown;
            //newButton.MouseLeftButtonUp += NewButton_MouseUp;

            return newButton;
        }

        private void NewButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is not Button senderButton)
                return;

            SignalGenWaveOut waveOut = senderButton.Tag as SignalGenWaveOut;
            waveOut.WaveOut.Stop();
        }

        private void NewButton_MouseDown(object sender, MouseButtonEventArgs e)
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
