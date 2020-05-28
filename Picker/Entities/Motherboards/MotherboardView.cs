﻿namespace Picker
{
    using System.Windows.Forms;

    internal partial class MotherboardView : Form, IMotherboardView
    {
        private MotherboardPresenter _presenter;

        public MotherboardView(MotherboardPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}