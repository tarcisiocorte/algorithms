class BinarySearch {
    constructor(private valeToSearch: number, private array: number[]) {

    }

    public search(): number {
        var bottom: number = 0;
        var top: number = this.array.length - 1;
        var middle: number;
        var index: number;

        while (bottom <= top) {
            middle = Math.floor((top + bottom) / 2);
            if (this.array[middle] == this.valeToSearch) {
                index = middle;
                break;
            } else {
                if (this.array[middle] < this.valeToSearch) {
                    bottom = middle + 1;
                } else {
                    top = middle - 1;
                }
            }
        }
        return index;
    }
}

let array = [10, 11, 16, 18, 20, 26, 31, 40];
let value = 15;
var binarySearch = new BinarySearch(value, array);
let index = binarySearch.search();
alert(index);