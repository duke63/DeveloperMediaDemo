﻿//define(['jquery', 'polyfills/cufon', 'fonts/buxtonSketch'], function ($, cufon) {
var cufon = window.Cufon;

    $.cufon = function () {
        cufon.replace('h1, h2', { fontFamily: 'Buxton Sketch' });
    };
//});