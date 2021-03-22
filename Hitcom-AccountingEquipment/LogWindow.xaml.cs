using Syncfusion.Windows.Shared;
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

namespace Hitcom_AccountingEquipment
{
    /// <summary>
    /// Логика взаимодействия для LogWindow.xaml
    /// </summary>
    public partial class LogWindow : ChromelessWindow
    {
        SenderMail Class = new SenderMail();
        public LogWindow()
        {
            Syncfusion.SfSkinManager.SfSkinManager.ApplyStylesOnApplication = true;
            InitializeComponent();
            FrameManager.LogFrame = FrameLogin;
            FrameManager.LogFrame.Navigate(new PageFolder.LogPage());
        }
    }
}
