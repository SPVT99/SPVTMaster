// Write your JavaScript code.
function validation() {
    var make = document.getElementById("make").value;
    var model = document.getElementById("model").value;
    var color = document.getElementById("color").value;
    var lpn = document.getElementById("lpn").value;
    var vtype = document.getElementById("vtype").value;

    if (make === "" && model === "" && color === "" && lpn === "" && vtype === "") {
        alert("DON'T BE A BANAN!!!!")
    }
    else if (make === "" || make == null) {
        alert("Make input must be filled out!")
    }
    else if (model === "" || model == null) {
        alert("Model input must be filled out!")
    }
    else if (color === "" || color == null) {
        alert("Color input must be filled out!")
    }
    else if (lpn === "" || lpn == null) {
        alert("License Plate input must be filled out!")
    }
    else if (vtype === "" || vtype == null) {
        alert("Violation Type input must be filled out!")
    }
}
//test