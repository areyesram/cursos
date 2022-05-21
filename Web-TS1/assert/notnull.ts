interface Named {
    name: string;
}

function showme(e?: Named) {
    if (e == null) return;
    let s = e!.name;
}

showme(null);
showme({ name: "Alex" });
