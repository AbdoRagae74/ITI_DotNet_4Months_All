function Rectangle(w, h) {
    Rectangle.Count++;
    this.width = Number(w);
    this.height = Number(h);
}
Rectangle.Count=0;
Rectangle.getCount = function(){
    console.log(Rectangle.Count);
}
Rectangle.prototype.calculateArea = function () {
     return this.width * this.height;
 }
Rectangle.prototype.calculatePerimeter = function () {
  return 2*this.width +2*this.height;
 }
Rectangle.prototype.toString = function () {
  return this.displayInfo();
 }

Rectangle.prototype.displayInfo = function () {

    var area = this.calculateArea();
    var perimeter = this.calculatePerimeter();

    console.log(`width = ${this.width}\nheight = ${this.height}  `);
    console.log(`area = ${area}\nperimeter = ${perimeter}  `);
}



var r1 = new Rectangle(12,7);
var r2 = new Rectangle(12,7);
var r3 = new Rectangle(12,7);
var r4 = new Rectangle(12,7);
var r5 = new Rectangle(12,7);
console.log(Rectangle.getCount());




