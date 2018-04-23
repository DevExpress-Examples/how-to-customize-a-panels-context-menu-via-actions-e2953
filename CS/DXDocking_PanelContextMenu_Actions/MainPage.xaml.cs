using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DXDocking_PanelContextMenu_Actions {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void bAbout_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            MessageBox.Show("About Window");
        }

    }
}
