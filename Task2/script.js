
function addRow() {
    var text = document.getElementById("myValue").value;
    var table = document.getElementById('myTable');

    var newRow = table.insertRow();
    var newCell = newRow.insertCell(0);
    var newText = document.createTextNode(text);
    newCell.appendChild(newText);
}