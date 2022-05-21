import Validator from "./validator";

const v = new Validator();
console.log(v.isNonNegativeInteger("123"));
console.log(v.isNonNegativeInteger("u123"));
