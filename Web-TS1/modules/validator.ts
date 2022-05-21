export default class Validator {
    static numberRegexp = /^[0-9]+$/;
    isNonNegativeInteger(s: string) {
        return Validator.numberRegexp.test(s);
    }
}
