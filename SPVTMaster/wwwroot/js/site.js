// Write your JavaScript code.
function validation() {
    var make = document.getElementById("make").value;
    if (make === "" || make == null) {
        alert("Make input must be filled out!")
    }
    var model = document.getElementById("model").value;
    if (model === "" || model == null) {
        alert("Model input must be filled out!")
    }
    var color = document.getElementById("color").value;
    if (color === "" || color == null) {
        alert("Color input must be filled out!")
    }
    var lpn = document.getElementById("lpn").value;
    if (lpn === "" || lpn == null) {
        alert("License Plate input must be filled out!")
    } 
    var vtype = document.getElementById("vtype").value;
    if (vtype === "" || vtype == null) {
        alert("Violation Type input must be filled out!")
    }
}