// There is a retail shop which need to manage the inventory, whenever some purchase is being 
// made product quantity should be reduced, if quanity is less than 5 reorder request should be raised.
// Design an interface and classes for the same.
//  class emm implements ShopInterface { 
//     // engine:string;
//     // constructor(engine:string) { 
//     //    this.engine = engine 
//     // }  
//     // disp():void { 
//     //    console.log("this is method ") 
//     // } 
//  }
var ProductArr = [
    { product: "one" },
    { product: "two" },
    { product: "three" },
    { product: "four" },
    { product: "five" },
    { product: "six" }
];
for (var _i = 0, ProductArr_1 = ProductArr; _i < ProductArr_1.length; _i++) {
    var a = ProductArr_1[_i];
    console.log(a.product);
}
function purchase() {
    console.log("welcome to store");
    var question = "Y";
    var promptValue = prompt('enter Y or N', '');
    switch (promptValue) {
        case "Y":
            if (ProductArr.length < 5) {
                console.log("reorder");
            }
            else {
                ProductArr.pop();
                console.log("new quantity : " + ProductArr.length);
                console.log("purchased");
            }
            break;
        case "N":
            console.log("new quantity" + ProductArr.length);
            break;
        default:
            console.log("wrong input press only Y or N ");
            break;
    }
}
ProductArr.forEach(function (val) {
    console.log(val.product);
});
purchase();
