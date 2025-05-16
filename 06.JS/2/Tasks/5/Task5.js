    function inputFun(ch){
        if(ch==1)
        return prompt("Enter your text");
    else return prompt("Enter letter to search for");
    }

    function getCharCnt(text,letter){
        var idx=[];
        for(var i = 0 ; i<text.length;i++) if(text[i].toLowerCase()==letter.toLowerCase() ) idx.push(i+1);
        return idx;
    }

    function main()
    {

        var text = inputFun(1);
        var letter;
        do {
            letter = inputFun(2)
        } while(letter.length!=1)

        var idx = getCharCnt(text,letter);
        var txt;
        txt="[";
        for(var i = 0 ; i<idx.length;i++) {
            txt+=idx[i]+" ";
            if(i!=idx.length-1) txt+=", ";
        }
        txt+="]";
        document.writeln(`<h1> letter ${letter} appeared ${idx.length} ${idx.length!=1?"Times":"Time"} ${ idx.length>1 ? "at "+txt : ""} </h1>`)
    }

    main();