﻿namespace Picker
{
    using System.Windows.Forms;

    internal partial class BuildListView : Form, IBuildListView
    {
        private BuildListPresenter _presenter;

        public BuildListView(BuildListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}