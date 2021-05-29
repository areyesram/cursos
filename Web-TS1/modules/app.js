"use strict";
exports.__esModule = true;
var validator_1 = require("./validator");
var v = new validator_1["default"]();
console.log(v.isNonNegativeInteger("123"));
console.log(v.isNonNegativeInteger("u123"));
