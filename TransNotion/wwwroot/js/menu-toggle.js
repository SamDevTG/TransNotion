document.addEventListener('DOMContentLoaded', function () {
    const menuToggle = document.getElementById('menu-toggle');
    const sidebar = document.getElementById('sidebar');
    const pageContent = document.getElementById('page-content-wrapper');

    menuToggle.addEventListener('click', function () {
        if (sidebar.style.marginLeft === '0px' || sidebar.style.marginLeft === '') {
            sidebar.style.width = '0';
            sidebar.style.marginLeft = '-250px';
            pageContent.style.marginLeft = '0';
        } else {
            sidebar.style.width = '250px';
            sidebar.style.marginLeft = '0';
            pageContent.style.marginLeft = '250px';
        }
    });
});
