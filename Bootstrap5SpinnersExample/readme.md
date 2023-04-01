# Bootstrap 5 Spinners

:open_book: [documentation](https://getbootstrap.com/docs/5.0/components/spinners/)

This code sample shows how to test drive spinners which are not for buttons per-say, the button allows testing spinners out without a load on a page to see what they look like.

The button wraps a `span` which has a class [d-none](https://getbootstrap.com/docs/5.0/utilities/display/) which gets removed to show the spinner for five seconds than hide the spinner with `d-done`.

```javascript
$(document).ready(function () {
    $(() => {
        $('button').on('click',
            e => {
                let spinner = $(e.currentTarget).find('span');
                spinner.removeClass('d-none');
                setTimeout(_ => spinner.addClass('d-none'), 5000);
            });
    });

});
```

```html
<button class="btn btn-primary w-25 mt-2" type="button">
    <span class="d-none spinner-grow spinner-grow-sm" role="status" aria-hidden="true"></span>
    Click me...
</button>
```

# Typical usage

```html
<div class="spinner-border" role="status">
  <span class="visually-hidden">Loading...</span>
</div>
```