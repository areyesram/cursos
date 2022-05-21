enum severity {
    Critical = 1,
    High,
    Medium,
    Low,
}

console.log(severity.High);
console.log(severity[1]);

function setSeverity1(value: severity) {
    console.log(value);
}

setSeverity1(severity.High);

//--

function setSeverity2(value: "Cri" | "Hi" | "Med" | "Low") {
    console.log(value);
}

setSeverity2("Hi");

// no funciona
// setSeverity2("Bye");
