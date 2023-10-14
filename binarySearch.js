var binarySearch = function (arr, item) {
    var low = 0;
    var high = arr.length - 1;
    while (low <= high) {
        var mid = Math.floor((low + high) / 2);
        var guess = arr[mid];
        if (guess == item) {
            return mid;
        }
        else if (guess > item) {
            high = mid - 1;
        }
        else {
            low = mid + 1;
        }
    }
    ;
    return null;
};
var myList = [1, 3, 5, 7, 9];
console.log(binarySearch(myList, +process.argv[2]));
