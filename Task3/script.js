var uri = "https://localhost:44331/api/Numbers/"

function addRow(number) {
    var myRow = '<tr><td>' + number + '</td></tr>';
    var myElement = $('#myTable > tbody:last-child');
    myElement.append(myRow);
}

$("#addRowButton").click(function (e) {
    var input = $("#myValue");
    var number = input && input[0] ? input[0].value : null;
    if (!number) return;

    $.ajax({
        url: uri + number,
        type: "get",
        success: function (response) {
            addRow(response);
        },
        error: function (xhr) {
            console.log("An error has occurred");
        }
    });
});