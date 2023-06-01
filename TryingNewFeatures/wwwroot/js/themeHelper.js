var $themeHelper = $themeHelper || {};
$themeHelper = function() {

    var _document;
    var setDocument = function (doc) {
        _document = doc;
    }

    var indexPage = function () {

        var submitButton = _document.getElementById('btnSubmit');

        if (submitButton) {
            submitButton.classList.remove('btn-primary');
            submitButton.classList.remove('btn-secondary');
            var currentTheme = localStorage.getItem("theme");

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

            var currentTheme = localStorage.getItem("theme");

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

    var doNavigation = function() {

        var borderColor = '';
        var currentTheme = localStorage.getItem("theme");
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
        configureSubmitButton: indexPage,
        configureWithSubmitButtonAndAlert: aboutPage
    };
}();