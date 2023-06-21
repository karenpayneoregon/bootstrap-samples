var $themeHelper = $themeHelper || {};
$themeHelper = function() {

    // ReSharper disable once InconsistentNaming
    var _document;

    var setDocument = function (doc) {
        _document = doc;
    }

    var indexPage = function () {

        var submitButton = _document.getElementById('btnSubmit');

        if (submitButton) {
            submitButton.classList.remove('btn-primary');
            submitButton.classList.remove('btn-secondary');
            var currentTheme = localStorage.getItem('theme');

            if (currentTheme !== null) {
                if (currentTheme === 'light') {
                    submitButton.classList.add('btn-primary');
                } else {
                    submitButton.classList.add('btn-secondary');
                }
            }
        }
    }
    
    var aboutPage = function () {

        var submitButton = _document.getElementById('btnSubmit');
        var alert = _document.getElementById('mainAlert');

        if (submitButton && alert) {
            submitButton.classList.remove('btn-primary');
            submitButton.classList.remove('btn-secondary');

            alert.classList.remove('alert-primary');
            alert.classList.remove('alert-dark');

            var currentTheme = localStorage.getItem('theme');

            if (currentTheme !== null) {
                if (currentTheme === 'light') {
                    submitButton.classList.add('btn-primary');
                    alert.classList.add('alert-primary');
                } else {
                    submitButton.classList.add('btn-secondary');
                    alert.classList.add('alert-dark');
                }
            }
        }
    }

    // change mode
    var changeMode =  function()
    {
        if (localStorage.getItem('theme') === null) {
            localStorage.setItem('theme', 'light');
        } else {
            var theme = localStorage.getItem('theme');
            _document.documentElement.setAttribute('data-bs-theme', theme);
            if (theme === 'dark') {
                _document.getElementById('lightSwitch').checked = true;
            } else {
                _document.getElementById('lightSwitch').checked = false;
            }

        }
    }

    // handles check box for switching dark mode
    var lightSwitchHandler = function() {
        if (_document.getElementById("lightSwitch").checked) {
            _document.documentElement.setAttribute('data-bs-theme', 'dark');
            localStorage.setItem('theme', 'dark');
        } else {
            _document.documentElement.setAttribute('data-bs-theme', 'light');
            localStorage.setItem('theme', 'light');
        }
    }

    /*
     * Handle individual pages
     */
    var toggleMode = function() {
        if (window.location.pathname === '/') {
            this.doNavigation();
            indexPage();
        } else if (window.location.pathname === '/About') {
            this.doNavigation();
            aboutPage();
        }
    }

    /*
     * Make current page in navigations
     */
    var doNavigation = function() {

        var borderColor = '';
        var currentTheme = localStorage.getItem('theme');

        if (currentTheme !== null) {
            if (currentTheme === 'light') {
                borderColor = 'border-black';
            } else {
                borderColor = 'border-white';
            }
        }

        _document.querySelectorAll('.nav-link').forEach(link => {

            link.classList.remove('border-bottom');
            link.classList.remove('border-top');
            link.classList.remove('border-white');

            if (link.getAttribute('href').toLowerCase() === location.pathname.toLowerCase()) {

                link.classList.add(borderColor);
                link.classList.add('border-bottom');
                link.classList.add('border-top');
            } else {
                link.classList.add(borderColor);
            }

        });
    }

    return {
        setDocument: setDocument,
        doNavigation: doNavigation,
        toggleMode: toggleMode,
        indexPage: indexPage,
        changeMode: changeMode,
        lightSwitchHandler: lightSwitchHandler,
        aboutPage: aboutPage
    };
}();