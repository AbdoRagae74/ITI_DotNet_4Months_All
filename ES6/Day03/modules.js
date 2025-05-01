class Shape{

    constructor(w,h){
    this.width = w;
    this.height = h;

}
calcArea = function(){}
calcPerimeter = function(){}
toString = function(){
    console.log(`Area = ${this.calcArea()}`);
    console.log(`Perimeter = ${this.calcPerimeter()}`);
}
}

export class Square extends Shape {
    constructor(w){
        super(w,w);
    }
    calcArea = function(){
        return this.width*this.height;
    }
calcPerimeter = function(){
    return 4 * width;
}
}

export class Rect extends Shape {
    constructor(w,h){
        super(w,h);
    }
    calcArea = function(){
        return this.width*this.height;
    }
calcPerimeter = function(){
    return 2*(this.width+this.height);
}
}
export class Circle extends Shape{
    constructor(r){
        super(r);
    }

    calcArea = function(){
        return Math.PI * r*r;
    }
calcPerimeter = function(){
    return 2*Math.PI*r;
}
}