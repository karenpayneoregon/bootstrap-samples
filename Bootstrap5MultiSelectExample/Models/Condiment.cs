#pragma warning disable CS8618
namespace Bootstrap5MultiSelectExample.Models;

public class Condiment
{
    /// <summary>
    /// Value of option
    /// </summary>
    public int Value { get; set; }
    /// <summary>
    /// Text for option
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Is selected
    /// </summary>
    public bool Selected { get; set; }
    public override string ToString() => Name;

}