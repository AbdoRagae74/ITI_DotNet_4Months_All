function randomNames(names){
    var res ="Randamoized names : " 
    for(var i = 0 ; i < 2;i++) 
        res+= names[Math.floor(Math.random()*5)]+" , ";
    return res;
}

var names =["ahmed","Islam","Sandra","Fatma","Ali"]

var ans = randomNames(names);
ans = ans.slice(0,-2);
document.writeln(`<h1>${ans}</h1>`)

