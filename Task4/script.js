var uri = "http://localhost:57923/api/Users/";

function addRow(firstValue, secondValue) {
    var myRow = '<tr><td>' + firstValue + '</td><td>' + secondValue + '</td></tr>';
    var myElement = $('#myTable > tbody:last-child');
    myElement.append(myRow);
}

$("button").click(function (e) {

    var input = $("#myValue");
    var number = input && input[0] ? input[0].value : null;
    if (!number) return;

    $.ajax({
        url: uri + number,
        type: "get",
        dataType: "json",

        success: function (response) {
            addRow(response.firstName, response.lastName)
        },
        error: function (xhr) {
            console.log("An error has occurred");
        }
    });

});