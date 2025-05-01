async function getAllUsers() {
    let data = await fetch("https://jsonplaceholder.typicode.com/users");
    let response = await data.json();

    return response;
}
async function getUsersPosts() {
    let data = await fetch("https://jsonplaceholder.typicode.com/posts");
    let response = await data.json();
    return response;
}
let x = getAllUsers();
async function addButtons(usersData) {

    const section = document.getElementById("buttons");
    let users = await usersData;
    let posts = await getUsersPosts();
    // console.log(posts);
    // console.log(users);
    var section2 = document.createElement("section");
    users.forEach(element => {
        var buttonVar = document.createElement("button");
        section.appendChild(buttonVar);
        buttonVar.innerText = element.name;
        buttonVar.classList.add("btn")
        // var cnt = 0;
        buttonVar.addEventListener("click", () => {
            section2.innerHTML = "";
            document.body.appendChild(section2);
            posts.forEach(postsData => {
                if (postsData.userId == element.id) {
                    var post = document.createElement("p");
                    post.innerText = postsData.body;
                    section2.appendChild(post);
                    // cnt++;
                }
            });
            // console.log(cnt);

        })
    });

}
addButtons(getAllUsers())

