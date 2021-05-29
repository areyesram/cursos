function add(a: string, b: string): string;

function add(a: number, b: number): number;

function add(a: any, b: any): any {
    return a + b;
}

add("Hello ", "world");
add(10, 20);

// no funciona
// add("Hello ", 10);
