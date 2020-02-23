
function multiply(number: number) {
    return function decorator(target, name, descriptor) {
        const original = descriptor.value;
        if (typeof original === 'function') {
            descriptor.value = function (...args) {
                const result = original.apply(this, args);
                return result * number;
            }
        }
        return descriptor;
    };
}

function subtract(number: number) {
    return function decorator(target, name, descriptor) {
        const original = descriptor.value;
        if (typeof original === 'function') {
            descriptor.value = function (...args) {
                const result = original.apply(this, args);
                return result - number;
            }
        }
        return descriptor;
    };
}

class MathClass {

    @subtract(1)
    @multiply(2)
    addOne(number: number) {
        return number + 1;
    }
}

console.log(new MathClass().addOne(2)) //should print 5
