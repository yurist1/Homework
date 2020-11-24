using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Wpf_example2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Patient> patients { get; private set; }


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Init();

            //lb1.DataContext = patients;
            dpListBox.DataContext = patients;
            // lb1.ItemsSource = patients.Select(d => d.name);
        }

        private void Init()
        {
            patients = new List<Patient>();
            patients.Add(new Patient("최유리1", "1", "치과", 29, "F"));
            patients.Add(new Patient("최유리2", "2", "외과", 29, "F"));
            patients.Add(new Patient("최유리3", "3", "내과", 29, "F"));
            patients.Add(new Patient("최유리4", "4", "정형외과", 29, "M"));
            patients.Add(new Patient("최유리5", "5", "성형외과", 29, "M"));
        }


    }


}