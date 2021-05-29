function SayHello(who: string): void {
    console.log(`Hello, ${who}!`);
    const x = 1 ?? 0;
}

SayHello("world");

//no funciona
// SayHello(new Date());
