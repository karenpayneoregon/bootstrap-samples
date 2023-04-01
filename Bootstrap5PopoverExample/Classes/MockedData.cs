namespace Bootstrap5PopoverExample.Classes;

public class MockedData
{
    public static List<PopOverContainer> PopOverList() =>
        new()
        {
            new()
            {
                Title = "Top", 
                Content = "Content for first", Text = "Top", 
                Placement = "top",
                ButtonForeColor = "btn-primary"
            },
            new()
            {
                Title = "Left", 
                Content = "Content for first", 
                Text = "Left", 
                Placement = "left",
                ButtonForeColor = "btn-success"
            },
            new()
            {
                Title = "Right", 
                Content = "Content for first", 
                Text = "Right", 
                Placement = "right",
                ButtonForeColor = "btn-info"
            },
            new()
            {
                Title = "Bottom", 
                Content = "Content for first", 
                Text = "Bottom", 
                Placement = "bottom",
                ButtonForeColor = "btn-dark"
            }
        };
}
