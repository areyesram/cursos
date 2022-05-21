const fn = "Hello";
// no funciona
// fn();

function func(cb: () => {}) {
    cb();
}

// no funciona
// func("Hello");

// no funciona
// const x = func + 1;
