﻿namespace tomenglertde.ResXManager.View.Visuals
{
    using System.Windows;
    using System.Windows.Controls;

    using TomsToolbox.Wpf;

    /// <summary>
    /// Interaction logic for Translations.xaml
    /// </summary>
    public partial class Translations
    {
        public Translations()
        {
            InitializeComponent();
        }

        private void ComboBox_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!true.Equals(e.NewValue))
                return;

            var row = ((DependencyObject) sender).TryFindAncestor<DataGridRow>();
            if (row != null)
            {
                row.IsSelected = true;
            }
        }
    }
}
