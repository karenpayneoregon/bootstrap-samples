using Bootstrap5MultiSelectExample.Models;

namespace Bootstrap5MultiSelectExample.Classes;

#pragma warning disable CS8618
public class MockedData
{
    public static List<Condiment> Condiments() =>
        new()
        {
            new() { Value = 1, Name = "Cheese"},
            new() { Value = 2, Name = "Tomatoes"},
            new() { Value = 3, Name = "Mozzarella"},
            new() { Value = 4, Name = "Mushrooms"},
            new() { Value = 5, Name = "Anchovies"},
            new() { Value = 6, Name = "Pepperoni"},
            new() { Value = 7, Name = "Onions"},
        };
}