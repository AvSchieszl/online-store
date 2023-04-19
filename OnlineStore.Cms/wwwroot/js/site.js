// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function updateUrl() {
    var sort = document.getElementById('sort').value;
    var category = document.getElementById('category').value;

    var newUrl = '?';

    if (sort && sort !== 'default') {
        newUrl += 'sort=' + sort;
    }

    if (category && category !== 'all') {
        newUrl += (newUrl.length > 1 ? '&' : '') + 'category=' + category;
    }

    window.location.href = newUrl;
}