// There is a retail shop which need to manage the inventory, whenever some purchase is being 
// made product quantity should be reduced, if quanity is less than 5 reorder request should be raised.
// Design an interface and classes for the same.


interface ShopInterface { 
    product:string
 } 



 var ProductArr: ShopInterface[] = [
    { product:"one"},
    { product:"two"},
    { product:"three"},
    { product:"four"},
    { product:"five"},
    { product:"six"}
];



for(var a of ProductArr){
    console.log(a.product);
}

function purchase(){

console.log("welcome to store");
    var question ="Y";


    switch (question){
        case "Y":
            if(ProductArr.length<5){
                console.log("reorder")
            }
            else{
            ProductArr.pop();
            console.log("new quantity : "+ProductArr.length);
            console.log("purchased")
            }
            break;
        case "N":
            console.log("new quantity"+ProductArr.length);
            break;
        default:
            console.log("wrong input press only Y or N ")
            break;
    }

}


ProductArr.forEach(function (val) {
    console.log(val.product);
    });


purchase();

