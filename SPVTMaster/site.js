// ***** Alert cars create empty fields must be filled out ***** //
function validation() {
    var make = document.getElementById("make").value;
    var model = document.getElementById("model").value;
    var color = document.getElementById("color").value;
    var lpn = document.getElementById("lpn").value;

    if (make === "" && model === "" && color === "" && lpn === "") {
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
    
}//Testing for bullshit
