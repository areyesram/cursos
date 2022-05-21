/**
 * Suma dos numeros
 * @param a Primer numero
 * @param b Segundo numero
 * @returns Suma de ambos
 */
function sum(a: number, b: number) {
    return a + b;
}

let total = sum(123, 345);
// no funciona
// total = "hello";
console.log(total);

// no funciona
// console.log(add("Hello ", "world"));

let message: string;

message = "Hello";
//message = 123;    <-- no funciona
console.log(message);
