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

namespace Wpf_for_blog
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count;
        public MainWindow()
        {
            count = 0;
            InitializeComponent();
        }

        //의존 속성 생성 및 등록!!!! 완전 중요 !!!!!! 
        public static readonly DependencyProperty BgColorProperty =
                               DependencyProperty.Register("BgColor", typeof(string), typeof(MainWindow), new FrameworkPropertyMetadata(new PropertyChangedCallback(OnBgColorPropertyChange)));

        public string BgColor 
        {
            get 
            {
                return GetValue(BgColorProperty).ToString();
            }
            set 
            {
                SetValue(BgColorProperty, value);
            }
        }

        //속성이 변경될 때마다 실행 됨!!!! 이것도 완전 중요!!!!!! 
        public static void OnBgColorPropertyChange(DependencyObject d, DependencyPropertyChangedEventArgs e) 
        {
            MainWindow window = d as MainWindow;
            SolidColorBrush brush = (SolidColorBrush)new BrushConverter().ConvertFromString(e.NewValue.ToString());
            window.btn.Background = brush;
        }

        // 변수처럼 사용된 애가 이거임. 
        //버튼이 클릭할 때 버튼 색이 바뀌도록 구현 
        //프로퍼티에 어떤 변화를 줄것인지 구현하면 됌
        private void BtnClick(object sender, RoutedEventArgs e) 
        {
            count++;
            if (count % 3 == 0)
            {
                BgColor = "Red";
            } 
            else if (count % 3 == 1) 
            {
                BgColor = "Green";
            }
            else 
            {
                BgColor = "Blue";
            }
        }
    }
}
