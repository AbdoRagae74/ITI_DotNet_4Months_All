const student = {
    name : "John Doe",
    age:20,
    grades:{
        math:90,
        science:85,
        literature:88
    },
    contactInfo:{
        email:"johndoe@example.com",
        phone:"123-456-789"
    }
}

// for(var key in student) 
// {
//     if(typeof student[key] !="object") {
//         console.log(key," : ",student[key])
//     }
//     else{
//         for(var key2 in student[key]){
//             console.log(`${key}.${key2} : ${student[key][key2]}`)
//         }
//     }

// }
function displayObject(object,parentKey=""){
    for(var key in object){
        var fullKey = parentKey ? `${parentKey}.${key}` : key;
        // console.log(key," => ",fullKey)
        if(typeof object[key]!="object"){
            document.writeln(`${fullKey} : ${object[key]}<br>`)
                // console.log(`${fullKey} : ${object[key]}`)
        }
        else{
            displayObject(object[key],fullKey)
        }
    }
}

displayObject(student)