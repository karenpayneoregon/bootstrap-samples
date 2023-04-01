# About

Although adding popovers when ready the Bootstrap documenation seems easy, many developers get it wrong which is the reason for this example.

Steps to setup for `popovers`

1. Include popper.js by adding via add client library
1. In _Layout.cshtml add a reference to popper library before any references to Bootstrap
1. In a page using popovers, you must intialize them manually

```csharp
@section scripts{
    <script>
        $(document).ready(function(e) {
            var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'));
            var popoverList = popoverTriggerList.map(function(popoverTriggerEl) {
                return new bootstrap.Popover(popoverTriggerEl);
            });
    </script>
}
```

## Extra

Note the use of a [skip-link](https://webaim.org/techniques/skipnav/), see comments in Index page. 

To do a skip link in Razor Pages we can not use href but instead `asp-fragment` which is the same as `href="#someIdentifier"`.

When first running this app, press <kbd>TAB</kbd> which makes the `skip link` visible, press <kbd>ENTER</kbd> to jump, in this case the first button on the page via the button id.

```html
<a
    class="skip-link btn btn-outline-primary mb-4"
    asp-fragment="button1"
    aria-label="skip to main content">
    skip to main content
</a>
```


## Documentation

:open_book: [Popovers](https://getbootstrap.com/docs/4.0/components/popovers/)