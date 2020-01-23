"use strict";

$(document).ready(function () {
    $("#btnPartial").click(function () {

        $.get("Cars/PartialCar/1", function (data, status) {

            console.log("Data: " + data + "\nStatus: " + status);

            $("#targetPartial").html(data);
        });
    });

    function changeButtontext() {
        var btn = document.getElementById("submitbutton");
        btn.onclick = ReGet;
        btn.value = "New number";
    }

    function ReGet() {
        var btn = document.getElementById("submitbutton");
        btn.value = "New number";

        var myform = document.createElement("form");
        myform.action = "Index";
        myform.controller = "NumGuessingGame";
        myform.method = "get";
        myform.submit()

    }

});