
import { products, addToCartLogic } from "./utils.js";
const productContainer = document.querySelector('.pro-container');
if (localStorage.getItem("currentUserName") == "NULL") location.replace("index.html");

const productCard = document.createElement('div');
productCard.className = '';
productCard.innerHTML = `
<img src="${products[localStorage.clickedItem].img}"> 
<div class="">
<span>${products[localStorage.clickedItem].description}</span>
<h2> ${products[localStorage.clickedItem].title}</h2>    
<h2>Price : ${products[localStorage.clickedItem].price}</h2> 
<button id="addTocartbtn" class="btn btn-primary" type="button">Add to cart</button>         
</div>
`
productContainer.appendChild(productCard);
const btn = document.getElementById("addTocartbtn");
btn.onclick = function () { 
    addToCartLogic(localStorage.currentUser, localStorage.clickedItem);
}
const name = document.getElementById("user-name");
const userName = localStorage.getItem("currentUserName"); 
const logout = document.getElementById("log-out");

name.innerText = userName;
logout.onclick = function () {
  localStorage.setItem("currentUserName", "NULL");
  location.replace("index.html");
}