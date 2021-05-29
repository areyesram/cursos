interface kvp {
    key: number;
    value: String;
}

function insert(a: kvp[], x: kvp) {
    a.push(x);
}

const arr: kvp[] = [];
insert(arr, { key: 123, value: "Monterrey" });
