function tellme(what: number | "N/A") {
    console.log(what ?? "");
}

tellme(0);
tellme(123);
tellme(undefined);
tellme("N/A");

// no funciona
// tellme("pancho lopez");

let num: 0 | 1 | 2;
num = 0;
num = 1;
num = 2;

// no funciona
// num = 3;

// no funciona
// num = parseInt("3");

//ok
num = <0 | 1 | 2>parseInt("2");

//no marca error pero esta mal
num = <0 | 1 | 2>parseInt("3");
console.log(num);

//ok
num = parseInt("2") as 0 | 1 | 2;
