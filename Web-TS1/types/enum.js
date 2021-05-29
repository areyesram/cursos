var severity;
(function (severity) {
    severity[severity["Critical"] = 1] = "Critical";
    severity[severity["High"] = 2] = "High";
    severity[severity["Medium"] = 3] = "Medium";
    severity[severity["Low"] = 4] = "Low";
})(severity || (severity = {}));
console.log(severity.High);
console.log(severity[1]);
function setSeverity(value) {
    console.log(value);
}
setSeverity(severity.High);
