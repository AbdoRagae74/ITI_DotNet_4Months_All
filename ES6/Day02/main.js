function generateCourseInfo (options ={}){

    let values ={
        courseName :"Crs default value",
        courseDuation :"Duration default value" ,
        courseOwner  :"Owner default value" 
    }
   let courseObject =  Object.assign(values,options);
    return courseObject;

}
let courseData={
    courseName :"OS",
    courseDuation :"12 hr" ,
}
console.log(generateCourseInfo(courseData));
