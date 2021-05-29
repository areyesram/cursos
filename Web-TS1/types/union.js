function tellme(what) {
    console.log(what !== null && what !== void 0 ? what : "");
}
tellme(0);
tellme(123);
tellme(undefined);
tellme("N/A");
// no funciona
// tellme("pancho lopez");
var num;
num = 0;
num = 1;
num = 2;
// no funciona
// num = 3;
// no funciona
// num = parseInt("3");
//ok
num = parseInt("2");
//no marca error pero esta mal
num = parseInt("3");
console.log(num);
//ok
num = parseInt("2");
