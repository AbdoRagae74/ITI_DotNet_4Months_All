var ans;
var img = document.createElement("img");
img.width = "400";
img.height = "400";
do {
    alert("Y/y for yes N/n for no ");
    ans = prompt("Do U Fly?")

} while (!(ans == 'Y' || ans == 'y' || ans == 'N' || ans == 'n'));

if (ans == "Y" || ans == "y") {

    do {
        alert("Y/y for yes N/n for no ");
        ans = prompt("Are U Wild?")

    } while (!(ans == 'Y' || ans == 'y' || ans == 'N' || ans == 'n'));

    if (ans == "Y" || ans == "y") {
        document.writeln("<h1>eagle</h1>");
        img.src = "eagle.jpg";
        document.body.appendChild(img);
    } else {
        document.writeln("<h1>Parrot</h1>");
        img.src = "parrot.jpg";
        document.body.appendChild(img);
    }
} else {
    do {
        alert("Y/y for yes N/n for no ");
        ans = prompt("Do U live undersea?")

    } while (!(ans == 'Y' || ans == 'y' || ans == 'N' || ans == 'n'));

    if (ans == "Y" || ans == "y") {

        do {
            alert("Y/y for yes N/n for no ");
            ans = prompt("Are U Wild?")

        } while (!(ans == 'Y' || ans == 'y' || ans == 'N' || ans == 'n'));
        if (ans == "Y" || ans == "y") {
            document.writeln("<h1>Shark</h1>");
            img.src = "shark.jpg";
            document.body.appendChild(img);
        } else {
            document.writeln("<h1>Dolphin</h1>");
            img.src = "dolphin.jpg";
            document.body.appendChild(img);
        }
    } else {
        do {
            alert("Y/y for yes N/n for no ");
            ans = prompt("Are U Wild?")

        } while (!(ans == 'Y' || ans == 'y' || ans == 'N' || ans == 'n'));
        if (ans == "Y" || ans == "y") {
            document.writeln("<h1>Lion</h1>");
            img.src = "Lion.jpg";
            document.body.appendChild(img);
        } else {
            document.writeln("<h1>Cat</h1>");
            img.src = "cat.jpg";
            document.body.appendChild(img);
        }

    }
}