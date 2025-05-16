function countes(str){
    cnt = 0;
    for(var i = 0 ; i<str.length;i++) if(str[i]=='e') cnt++;
    return cnt;
}


input = prompt("Enter text")

ans = countOs(input);
document.writeln(`<h1>Count of character e in ${input} => ${ans} </h1>`)
