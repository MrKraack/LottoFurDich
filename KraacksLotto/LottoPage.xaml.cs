using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace KraacksLotto
{
    /// <summary>
    /// Interaction logic for LottoPage.xaml
    /// </summary>
    public partial class LottoPage : INotifyPropertyChanged
    {
        private bool isClear = true;
        private List<int> _lottoWinnigs = new List<int>();
        public List<int> LottoWinnigs
        {
            get { return _lottoWinnigs; }
            set
            {
                if (_lottoWinnigs != value)
                {
                    _lottoWinnigs = value;
                    OnPropertyChanged();
                }
            }
        }

        Random rng = new Random();

        public LottoPage()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void StartLotto_Click(object sender, RoutedEventArgs e)
        {
            GenerateWinningNumbers();
        }

        public void ClearLotto()
        {
            LottoWinnigs.Clear();
        }
        public void GenerateWinningNumbers()
        {
            int number;   
            for (int i = 0; i < 7; i++)
            {
                number = rng.Next(1, 36);
                LottoWinnigs.Add(number);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
