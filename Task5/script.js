
var apiUrl = "http://localhost:57923/api/Users";


function addRow(firstValue, secondValue) {
    var myRow = '<tr><td>' + firstValue + '</td><td>' + secondValue + '</td></tr>';
    var myElement = $('#myTable > tbody:last-child');
    myElement.append(myRow);
}

$(document).ready(function () {
    $(function () {
        $.ajax({
            url: apiUrl,
            type: "get",
            dataType: "json",

            success: function (response) {
                response.forEach(element => {
                    addRow(element.firstName, element.lastName);
                });
            },
            error: function (xhr) {
                console.log("An error has occurred");
            }
        });
    });

    $("#addUser").click(function (e) {
        var firstName1 = $("#firstName")[0].value;
        var lastName1 = $("#lastName")[0].value;

        $.ajax({
            url: apiUrl,
            method: "post",
            crossDomain: true,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify({
                firstName: firstName1,
                lastName: lastName1
            }),
            success: function (data) {
                addRow(data.firstName, data.lastName);
            },
            failure: function (err) {
                alert('Error: ' + JSON.stringify(err))
            }
        });
    });
});

