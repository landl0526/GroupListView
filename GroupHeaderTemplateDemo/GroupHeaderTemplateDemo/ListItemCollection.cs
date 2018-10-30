using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace GroupHeaderTemplateDemo
{
public class ListItemCollection : ObservableCollection<Item>
{
    public string Title { set; get; }

    public ListItemCollection(string title)
    {
        Title = title;

        ExpandCommand = new Command<ListItemCollection>((listItem) =>
        {

        });
    }

    public Command<ListItemCollection> ExpandCommand { set; get; }
}

    public class Item
    {
        public string Name { set; get; }
        public string Description { set; get; }
    }
}
