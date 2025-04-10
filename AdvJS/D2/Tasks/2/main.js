function Shape(w,h){
    if(this.constructor == Shape)
    throw("this is not a construnctor");    
    this.width = Number(w);
    this.height = Number(h);

}

// ss1 = new Shape(3,5); ERROR

function Rectangle(w,h) {
    if(Rectangle.Count==1 && this.constructor==Rectangle)
        throw("One object from Rect already existed");    
    Shape.call(this,w,h);
    Rectangle.Count++;

}
Rectangle.prototype =  Object.create(Shape.prototype);
Rectangle.prototype.constructor = Rectangle;
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

r1 = new Rectangle(2,3); // No Problem
//r2 = new Rectangle(2,3); // Problem

function Square(w,h){
    if(Square.Count==1 && this.constructor==Square)
        throw("One object from Square already existed");    
    Rectangle.call(this,w,h);
    Square.Count++;
}
Square.Count=0;
Square.prototype = Object.create(Rectangle.prototype);
Square.prototype.constructor = Square;
s1 = new Square(3,5); // No Problem
// s1 = new Square(3,5); // Problem

console.log(s1);



