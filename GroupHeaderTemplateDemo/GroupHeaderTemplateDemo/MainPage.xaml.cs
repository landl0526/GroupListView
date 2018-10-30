using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GroupHeaderTemplateDemo
{
	public partial class MainPage : ContentPage
	{
        ObservableCollection<ListItemCollection> list;
        public MainPage()
		{
			InitializeComponent();

            list = new ObservableCollection<ListItemCollection>();
            for (int i=0; i<10; i++)
            {
                ListItemCollection items = new ListItemCollection("title" + i);
                for (int j=0; j<10; j++)
                {
                    items.Add(new Item { Name = "name" + j, Description = "Description" + j });
                }
                list.Add(items);
            }
            itemListView.ItemsSource = list;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            itemListView.ScrollTo(list[2][3], list[2], ScrollToPosition.Start, true);
        }
    }
}
