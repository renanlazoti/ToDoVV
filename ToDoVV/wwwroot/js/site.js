document.getElementById('open_btn').addEventListener('click', function () {
    const sidebar = document.getElementById('sidebar');
    sidebar.classList.toggle('open-sidebar');

    if (sidebar.classList.contains('open-sidebar')) {
        document.getElementById('open_btn').style.right = "5px";
    } else {
        document.getElementById('open_btn').style.right = "";
    }
})