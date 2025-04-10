function execute(){
    var tagValue = document.getElementById("tags").value;
    var classValue = document.getElementById("classes").value;
    var idValue = document.getElementById("IDs").value;
    var nameValue = document.getElementById("names").value;
    var span = document.getElementById("outputSpan");

    var tagCnt = document.getElementsByTagName(tagValue);
    var classCnt = document.getElementsByClassName(classValue);
    var idExist = document.getElementById(idValue);
    var namesCnt = document.getElementsByName(nameValue);
    span.innerHTML=`# of tag ${tagValue} => ${tagCnt.length} <br> Class content ${classValue}  => ${classCnt.length} <br> id ${idValue} => ${idExist?"True":"False"} <br>Name ${nameValue} => ${namesCnt.length}`;
    console.log(`Tags => ${tagCnt.length}`);
    console.log(`Classes => ${classCnt.length}`);
    console.log(`IDs => ${idExist?"True":"False"}`);
    console.log(`Names => ${namesCnt.length}`);
}