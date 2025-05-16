function Rectangle(w, h) {

    this.width = Number(w);
    this.height = Number(h);
}
Rectangle.prototype.calculateArea = function () {
     return this.width * this.height;
 }
Rectangle.prototype.calculatePerimeter = function () {
  return 2*this.width +2*this.height;
 }


Rectangle.prototype.displayInfo = function () {

    var area = this.calculateArea();
    var perimeter = this.calculatePerimeter();

    console.log(`width = ${this.width}\nheight = ${this.height}  `);
    console.log(`area = ${area}\nperimeter = ${perimeter}  `);
}


var r1 = new Rectangle(12,7);

console.log(r1.calculateArea());
console.log(r1.calculatePerimeter());
r1.displayInfo();




