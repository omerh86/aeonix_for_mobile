using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using LinphoneXamarin.iOS;
using LinphoneXamarin.components.userControllers;
using System.Drawing;

[assembly: ExportRenderer(typeof(ToolbarItem), typeof(CustomToolBarIconsRenderer))]
namespace LinphoneXamarin.iOS
{

    public class CustomToolBarIconsRenderer : PageRenderer
    {
       //I used UITableView for showing the menulist of secondary toolbar items.
List<ToolbarItem> secondaryItems;
UITableView _table;

protected override void OnElementChanged(VisualElementChangedEventArgs e)
{
    //Get all secondary toolbar items and fill it to the gloabal list variable and remove from the content page.
    if (e.NewElement is ContentPage page)
    {
        secondaryItems = page.ToolbarItems.Where(i => i.Order == ToolbarItemOrder.Secondary).ToList();
        secondaryItems.ForEach(t => page.ToolbarItems.Remove(t));
    }
    base.OnElementChanged(e);
}

public override void ViewWillAppear(bool animated)
{
    var element = (ContentPage)Element;
    //If global secondary toolbar items are not null, I created and added a primary toolbar item with image(Overflow) I         
            // want to show.
    if (secondaryItems != null && secondaryItems.Count > 0)
    {
        element.ToolbarItems.Add(new ToolbarItem()
        {
            Order = ToolbarItemOrder.Primary,
            Icon = "chat.png",
            Priority = 1,
            Command = new Command(() =>
            {
                toolClicked();
            })
        });
    }
    base.ViewWillAppear(animated);
}

//Create a table instance and added it to the view.
private void toolClicked()
{
    if (_table == null)
    {
        //Set the table position to right side. and set height to the content height.
        var childRect = new RectangleF((float)View.Bounds.Width - 250, 0, 250, secondaryItems.Count() * 56);
                _table = new UITableView(childRect)
        {
            Source = new TableSource(secondaryItems) // Created Table Source Class as Mentioned in the 
                            //Xamarin.iOS   Official site
        };
        Add(_table);
        return;
    }
    foreach (var subview in View.Subviews)
    {
        if(subview == _table)
        {
            _table.RemoveFromSuperview();
            return;
        }
    }
    Add(_table);
}   
    }
}