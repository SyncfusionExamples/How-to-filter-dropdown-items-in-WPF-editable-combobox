using Microsoft.Xaml.Behaviors;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Windows.Data;

namespace ComboBoxAdvSample
{
    public class FilterAction : TargetedTriggerAction<ComboBoxAdv>
    {
        protected override void Invoke(object parameter)
        {
            CollectionView items = (CollectionView)CollectionViewSource.GetDefaultView(Target.ItemsSource);
            items.Filter = ((o) =>
            {
                if (String.IsNullOrEmpty(Target.Text))
                    return true;
                else
                {
                    if ((o as Model).Name.Contains(Target.Text))
                        return true;
                    else
                        return false;
                }
            });
            items.Refresh();
        }
    }
}
