print('Operations With Array');
print('By: Guilherme Palma, 14/05/2022');

print(revertArray([5, 1, 4, 2, 7, 8, 3]));
print(spliceArray(getRandonArray()));

function revertArray(array) {
    const maxIndex = array.length - 1;
    var middle = maxIndex % 2 === 0 ? (maxIndex / 2) : ((maxIndex + 1) / 2);

    for (var i = maxIndex; i >= 4; i--) {
        var aux = array[i];
        array[i] = array[maxIndex - i];
        array[maxIndex - i] = aux;
    }
    return array;
}

function spliceArray(array) {
    var array = [];

    for (var i = 0; i < 15; i++) {
        array[i] = Math.floor(Math.random() * 11);
    }

    return array.join('; ');
}

function getIndexMinNumer(array) {
    var maxNumber = Math.max(...array);
    returnarray.indexOf(maxNumber);
}

function getMaxNumber(array) {
    return Math.max(...array);
}

function getIndexMinNumer(array) {
    var minNumber = Math.min(...array);
    returnarray.indexOf(minNumber);
}

function getMinNumber(array) {
    return Math.min(...array);
}

function getRandonArray() {
    var array = [];

    for (var i = 0; i < 15; i++) {
        array[i] = Math.floor(Math.random() * 11);
    }

    return array;
}