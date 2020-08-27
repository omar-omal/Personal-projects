
//Writes the date in the website
document.getElementById("demo").innerHTML = "Hello world";

function currentDate() {


    document.getElementById("demo").innerHTML = Date();
}



//Find the position of certain word in the string, aka the 
//position of the first letter in the word.
function positionOfword() {

    var para = " 3 items: Adds 1487 Armor";

    var position= para.indexOf("Adds");
    document.getElementById("positiondemo").innerHTML = position;
    
   
}

//Finds the position of the last occurance of the word
function positionOflastword() {

    var para = " 3 items: Adds 1487 Armor";

    var position= para.lastIndexOf("Adds");
    document.getElementById("lastpositiondemo").innerHTML = position;
    
   
}

//Extract the a string bit at en exact position, in this case the value of armor which is a number.

function amrorValue(){

var para = " 3 items: Adds 1487 Armor"
var position = para.indexOf("Adds");
var lastletter = position + 5;
var res = para.slice(lastletter,lastletter + 4);
document.getElementById("wordextracted").innerHTML = res;

}

