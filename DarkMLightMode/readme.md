# About

Modified version of Bootstrap dark/light mode by Karen Payne. This is prior to native support for Bootstrap

[Source code](https://github.com/GoogleChromeLabs/dark-mode-toggle/tree/main)

## Purpose for this project

In project **CSSVariables1** was used to show basics of CSS property scoped globally while this project shows how to target specific pages.

Suppose there is a need for CSS isolation for a plain HTML project (not Blazor or Razor Pages)? Let's look at a rule for index.html.

```css
:root.indexPage .special {
    color: white;
    background-color: black;
}
```

Then in index.html specify the rule in the **html** tag.

```html
<html class="indexPage">
```

Then lets target a single button.

```html
<button type="button"  class="special">Go</button>
```

Another method with child selectors, in this case placed into a sparate file.

```css
:root {
  --color-one: yellow;
  --color-two: green;
  background-color: var(--color-one);
  color: var(--color-two);
}

:root.posts {
  --color-one: green;
  --color-two: yellow;
  background-color: var(--color-one);
  color: var(--color-two);
}

.special {
  color: #f0f;
  font-style: italic;
}

:root.posts .special {
  color: #f90;
  font-style: normal;
  text-transform: uppercase;
  text-shadow: 2px 2px 6px rgba(0, 0, 0, 0.5);
}
```

The html

```html
<!DOCTYPE html>
<html lang="en" class="posts">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link href="lib/site.css" rel="stylesheet" />
</head>
<body>
    <p>
        Hello
    </p>
    <p class="special">Special content</p>
</body>
</html>
```
