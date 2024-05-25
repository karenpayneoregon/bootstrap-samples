//document.addEventListener('DOMContentLoaded', () => {

//    document.querySelectorAll('.nav-link').forEach(link => {

//        link.classList.remove('border-bottom');
//        link.classList.remove('border-top');

//        if (link.getAttribute('href').toLowerCase() === location.pathname.toLowerCase()) {
//            link.classList.add('border-danger');
//            link.classList.add('border-bottom');
//            link.classList.add('border-top');
//        } else {
//            link.classList.add('text-danger');
//        }
//    });
//});

//document.addEventListener('DOMContentLoaded', () => {

//    document.querySelectorAll('.nav-link').forEach(link => {

//        link.classList.remove('text-dark');
//        link.classList.remove('bg-primary');

//        if (link.getAttribute('href').toLowerCase() === location.pathname.toLowerCase()) {
//            link.classList.add('text-white');
//            link.classList.add('bg-primary');
//        } else {
//            link.classList.add('text-dark');
//        }
//    });
//})

document.addEventListener('DOMContentLoaded', () => {

    document.querySelectorAll('.nav-link').forEach(link => {

        link.classList.remove('active');

        if (link.getAttribute('href').toLowerCase() === location.pathname.toLowerCase()) {
            link.classList.add('active');
        }
    });
});