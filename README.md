# How to Filter Dropdown Items in WPF Editable ComboBox
## Overview
This example demonstrates how to filter dropdown items in the Syncfusion WPF ComboBoxAdv control when it is editable. Filtering allows users to quickly find relevant items by typing text in the combo box.

## Steps to Implement
### 1. Add ComboBoxAdv in XAML
```XAML
<Grid>
    <syncfusion:ComboBoxAdv Height="30" Width="150"/>
</Grid>
```

### 2. Add ComboBoxAdv in C#
```C#
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ComboBoxAdv comboBoxAdv = new ComboBoxAdv
        {
            Height = 30,
            Width = 150,
            DefaultText = "Choose Items"
        };
        this.Content = comboBoxAdv;
    }
}
```
## Filtering Logic
Use the KeyUp event to filter items dynamically based on user input.

**XAML**
```XAML
<Grid>
    <syncfusion:ComboBoxAdv x:Name="comboBoxAdv"
                             Width="200"
                             Height="25"
                             ItemsSource="{Binding List}"
                             DisplayMemberPath="Name"
                             IsEditable="True">
        <i:Interaction.Triggers>
            <i:EventTrigger EventName="KeyUp">
                <local:FilterAction/>
            </i:EventTrigger>
        </i:Interaction.Triggers>
    </syncfusion:ComboBoxAdv>
</Grid>
````

**C#**
```C#
public class FilterAction : TargetedTriggerAction<ComboBoxAdv>
{
    protected override void Invoke(object parameter)
    {
        CollectionView items = (CollectionView)CollectionViewSource.GetDefaultView(Target.ItemsSource);
        items.Filter = (o) =>
        {
            if (string.IsNullOrEmpty(Target.Text))
                return true;
            return (o as Model).Name.Contains(Target.Text);
        };
        items.Refresh();
    }
}
```

## Reference
For more details, refer to the official KB article: https://www.syncfusion.com/kb/11499/how-to-filter-dropdown-items-in-wpf-editable-comboboxadv

##  How to Run
- Clone the How-to-filter-dropdown-items-in-WPF-editable-combobox repository.
- Open the solution in Visual Studio 2022.
- Build and run the project.

## Troubleshooting
**Path Too Long Exception**

If you encounter this error:
- Close Visual Studio.
- Rename the repository folder to a shorter name.
- Reopen and build the project.
