// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Chatroom mainscreen section

$(document).ready(function () {
    // Collect heights of elements for sidebar
    let userDetails = $(".user-details").outerHeight();
    let topConfigBar = $(".top-config-bar").outerHeight();
    let bottomConfigBar = $(".bottom-config-bar").outerHeight();
    let chatroomList = $(".chatroom-list");
    let windowHeight = $(window).height();
    chatroomList.css('height', windowHeight - (userDetails + topConfigBar + bottomConfigBar));
    $(window).resize(function () {
        userDetails = $(".user-details").outerHeight();
        topConfigBar = $(".top-config-bar").outerHeight();
        bottomConfigBar = $(".bottom-config-bar").outerHeight();
        windowHeight = $(window).height();
        chatroomList.css('height', windowHeight - (userDetails + topConfigBar + bottomConfigBar))
    });

    // Collect heights of elements for message area
    let chatroomTopBar = $(".chatroom-top-bar").outerHeight();
    let chatroomConstructArea = $(".chatroom-construct-area").outerHeight();
    let chatroomWindow = $(".chatroom-message-area");
    chatroomWindow.css('height', windowHeight - (chatroomTopBar + chatroomConstructArea));
    $(window).resize(function () {
        chatroomTopBar = $(".chatroom-top-bar").outerHeight();
        chatroomConstructArea = $(".chatroom-construct-area").outerHeight();
        chatroomWindow.css('height', windowHeight - (chatroomTopBar + chatroomConstructArea));
    })


});