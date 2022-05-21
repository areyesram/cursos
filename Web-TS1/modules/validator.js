"use strict";
exports.__esModule = true;
var Validator = /** @class */ (function () {
    function Validator() {
    }
    Validator.prototype.isNonNegativeInteger = function (s) {
        return Validator.numberRegexp.test(s);
    };
    Validator.numberRegexp = /^[0-9]+$/;
    return Validator;
}());
exports["default"] = Validator;
