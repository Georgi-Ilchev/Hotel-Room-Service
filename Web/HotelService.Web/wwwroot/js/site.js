﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(".alert-dismissible").fadeTo(3000, 500).slideUp(500, function () {
    $(".alert-dismissible").alert('close');
});