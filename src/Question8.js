function multiply(number) {
    return function decorator(target, name, descriptor) {
        var original = descriptor.value;
        if (typeof original === 'function') {
            descriptor.value = function () {
                var args = [];
                for (var _i = 0; _i < arguments.length; _i++) {
                    args[_i] = arguments[_i];
                }
                var result = original.apply(this, args);
                return result * number;
            };
        }
        return descriptor;
    };
}
function subtract(number) {
    return function decorator(target, name, descriptor) {
        var original = descriptor.value;
        if (typeof original === 'function') {
            descriptor.value = function () {
                var args = [];
                for (var _i = 0; _i < arguments.length; _i++) {
                    args[_i] = arguments[_i];
                }
                var result = original.apply(this, args);
                return result - number;
            };
        }
        return descriptor;
    };
}
//# sourceMappingURL=Question8.js.map