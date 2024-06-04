document.addEventListener('DOMContentLoaded', () => {

    const htmlElement = document.documentElement;
    const currentTheme = localStorage.getItem('bsTheme') || 'dark';

    htmlElement.setAttribute('data-bs-theme', currentTheme);

    var buttons = document.querySelectorAll('.btn');
    for (var index = 0; index < buttons.length; index++) {
        
        buttons[index].classList.remove(...["btn-primary", "btn-secondary"]);

        if (currentTheme === 'dark') {
            buttons[index].classList.add('btn-secondary');
        } else {
            buttons[index].classList.add('btn-primary');
        }
    }

    var badges = document.querySelectorAll('span.badge');
    for (var index = 0; index < badges.length; index++) {
        
        badges[index].classList.remove(...["bg-primary", "bg-secondary"]);

        if (currentTheme === 'dark') {
            badges[index].classList.add('bg-secondary');
        } else {
            badges[index].classList.add('bg-primary');
        }
    }

    var checkBoxes = document.querySelectorAll("input[type='checkbox']");
    for (var index = 0; index < checkBoxes.length; index++) {

        checkBoxes[index].classList.remove("bg-dark-subtle");

        if (currentTheme === 'dark') {
            checkBoxes[index].classList.add('bg-dark-subtle');
        } 
    }

    var fieldSets = document.getElementsByTagName('fieldset');
    for (var index = 0; index < fieldSets.length; index++) {

        fieldSets[index].classList.remove("border-dark");

        if (currentTheme != 'dark') {
            fieldSets[index].classList.add('border-dark');
        } 
    }

    // handle nav bar
    document.getElementById('nav_header_text').classList.remove(...["text-black", "text-white"]);

    if (currentTheme === 'dark') {
        document.getElementById('nav_header_text').classList.add('text-white');
    } else {
        
    } document.getElementById('nav_header_text').classList.add('text-black');
    
});
