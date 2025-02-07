using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Serilog;
using SeriLogThemesLibrary;

namespace Bootstrap5ModalExample.Classes;

/// <summary>
/// For setting up SeriLog to keep Program.Main clean and allows code to be easily copied to other projects.
/// </summary>
public class SetupLogging
{
    /// <summary>
    /// Development logging
    /// </summary>
    public static void Development()
    {

        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console(theme: SeriLogCustomThemes.Default())
            .CreateLogger();
    }


}
/// <summary>
/// A custom <see cref="TagHelper"/> that generates a <c>div</c> element with predefined inline styles.
/// </summary>
/// <remarks>
/// This tag helper targets elements with the name <c>div-with-style</c> and applies specific styling attributes
/// to create a styled <c>div</c> element.
/// https://stackoverflow.com/a/56861783/5509738
///
/// https://duongnt.com/tag-helpers/
/// https://github.com/duongntbk/TagHelpersDemo/tree/master
/// </remarks>
[HtmlTargetElement("div-with-style")]
public class StyleTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.Attributes.SetAttribute("style", "height:40px;width: 40px;background-color: black;");
    }
}

[HtmlTargetElement("hello-world")]
public class HelloWorldTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.TagMode = TagMode.StartTagAndEndTag;

        TagBuilder hello = new("span");
        hello.InnerHtml.AppendHtml("<strong>Hello</strong>,");
        output.Content.AppendHtml(hello);

        TagBuilder world = new("a");
        world.InnerHtml.AppendHtml("World!");
        world.Attributes.Add("href", "https://example.com");
        output.Content.AppendHtml(world);
    }
}
