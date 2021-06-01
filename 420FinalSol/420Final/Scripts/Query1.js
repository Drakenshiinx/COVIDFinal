function GetShowDataQuery1() {

    $.getJSON("api/covid/query1")
        .done(function (data) {
            let table = document.getElementById("table1");
            console.log(data);
            generateTable(table, data);
        });
}

function generateTable(table, data) {
    for (let element of data) {
        let row = table.insertRow();
        for (key in element) {
            let cell = row.insertCell();
            let text = document.createTextNode(element[key]);
            cell.appendChild(text);
        }
    }
}

