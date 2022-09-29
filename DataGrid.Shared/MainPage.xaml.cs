using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

using CommunityToolkit.WinUI.UI.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataGrid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // DataGrid instantiated here
            var dataGrid = new CommunityToolkit.WinUI.UI.Controls.DataGrid
            {
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                AutoGenerateColumns = false,
                ColumnHeaderHeight = 32,
                GridLinesVisibility = DataGridGridLinesVisibility.Horizontal,
                HeadersVisibility = DataGridHeadersVisibility.Column,
                IsReadOnly = true,

            };

            dataGrid.Columns.Add(new DataGridTextColumn
            {
                Header = "DataGrid Rank"
            });
            dataGrid.Columns.Add(new DataGridComboBoxColumn
            {
                Header = "DataGrid Mountain"
            });
            dataGrid.Columns.Add(new DataGridTextColumn
            {
                Header = "DataGrid Height"
            });

            Grid.SetRow(dataGrid, 1);
            _grid.Children.Add(dataGrid);


            // DataGridSubclass instantiated here
            var dataGridSubclass = new DataGridSubclass
            {
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                AutoGenerateColumns = false,
                ColumnHeaderHeight = 32,
                GridLinesVisibility = DataGridGridLinesVisibility.Horizontal,
                HeadersVisibility = DataGridHeadersVisibility.Column,
                IsReadOnly = true,

            };

            dataGridSubclass.Columns.Add(new DataGridTextColumn
            {
                Header = "Subclass Rank"
            });
            dataGridSubclass.Columns.Add(new DataGridComboBoxColumn
            {
                Header = "Subclass Mountain"
            });
            dataGridSubclass.Columns.Add(new DataGridTextColumn
            {
                Header = "Subclass Height"
            });

            Grid.SetRow(dataGridSubclass, 1);
            Grid.SetColumn(dataGridSubclass, 1);
            _grid.Children.Add(dataGridSubclass);

        }
    }
}
