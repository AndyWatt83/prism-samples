﻿using System.ComponentModel.Composition;
using System.Windows;

namespace TaskList.Shell
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
