// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById('open_btn').addEventListener('click', function () {
    document.getElementById('sidebar').classList.toggle('open-sidebar');
})

function setActiveClass(element) {
    const items = document.querySelectorAll('.side-item');
    items.forEach(item => {
        item.classList.remove('active');
    });

    element.classList.add('active');
}

document.querySelectorAll('.side-item').forEach(item => {
    item.addEventListener('click', () => {
        setActiveClass(item);
    });
});