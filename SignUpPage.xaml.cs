/// <summary>
/// Handles the event when the "Add Service" button is clicked.
/// Adds a new service entry along with a button to add subcategories.
/// </summary>
/// <param name="sender">The button that was clicked</param>
/// <param name="e">Event arguments associated with the button click</param>
/// <precondition>
/// - The 'ServicesStackLayout' must be initialized and not null.
/// </precondition>
/// <postcondition>
/// - A new StackLayout containing a service entry and a subcategory button is added to 'ServicesStackLayout'.
/// </postcondition>
private void OnAddServiceClicked(object sender, EventArgs e)
{
    // Create a new StackLayout for the service and its subcategories
    var serviceStackLayout = new StackLayout
    {
        Spacing = 10,
        Margin = new Thickness(0, 10)
    };

    // Add an Entry for the service
    var serviceEntry = new Entry
    {
        Placeholder = "Service",
        TextColor = Colors.White,
        PlaceholderColor = Colors.Gray,
        BackgroundColor = Colors.Transparent,
        HorizontalOptions = LayoutOptions.FillAndExpand
    };
    serviceStackLayout.Children.Add(serviceEntry);

    // Add a button to add subcategories
    var addSubcategoryButton = new Button
    {
        Text = "+ Add Subcategory",
        Style = (Style)Application.Current.Resources["TransparentButtonStyle"],
        Margin = new Thickness(0, 10)
    };
    addSubcategoryButton.Clicked += (s, args) => OnAddSubcategoryClicked(serviceStackLayout);
    serviceStackLayout.Children.Add(addSubcategoryButton);

    // Add the service stack layout to the main services stack layout
    ServicesStackLayout.Children.Add(serviceStackLayout);
}
