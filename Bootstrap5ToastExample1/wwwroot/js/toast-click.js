(function () {
    function ready(fn) {
        if (document.readyState === 'loading') {
            document.addEventListener('DOMContentLoaded', fn);
        } else { fn(); }
    }

    ready(function () {
        var btn = document.getElementById('showToastBtn');
        var el = document.getElementById('appToast');
        if (!btn || !el || typeof bootstrap === 'undefined' || !bootstrap.Toast) return;

        btn.addEventListener('click', function () {
            var t = bootstrap.Toast.getOrCreateInstance(el);
            t.show();
        });
    });
})();