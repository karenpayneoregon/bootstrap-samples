document.addEventListener('DOMContentLoaded', () => {

    const htmlElement = document.documentElement;
    const currentTheme = localStorage.getItem('bsTheme') || 'dark';

    htmlElement.setAttribute('data-bs-theme', currentTheme);

    var buttons = document.querySelectorAll('.btn');

    for (var index = 0; index < buttons.length; index++) {

        buttons[index].classList.remove('btn-primary');
        buttons[index].classList.remove('btn-secondary');

        if (currentTheme === 'dark') {
            buttons[index].classList.add('btn-secondary');
        } else {
            buttons[index].classList.add('btn-primary');
        }
    }

    document.getElementById('nav_header_text').classList.remove('text-black');
    document.getElementById('nav_header_text').classList.remove('text-white');

    if (currentTheme === 'dark') {
        document.getElementById('nav_header_text').classList.add('text-white');
    } else {
        
    } document.getElementById('nav_header_text').classList.add('text-black');
    
});
