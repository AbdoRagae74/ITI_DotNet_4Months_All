document.addEventListener("keydown", function(e) {
    console.log(e);
    var character = e.key ;
    var ascii = character.charCodeAt(0);
    


    alert(`U pressed ${character} with ascii code ${ascii}`);  // Show key information in an alert box
  });


 