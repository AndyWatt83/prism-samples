using System.Windows;
using System.ComponentModel.Composition;

namespace WireFrame.Shell
{
    [Export()]
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
        }
    }
}
