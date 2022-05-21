var Queue = /** @class */ (function () {
    function Queue() {
        this._queue = [];
    }
    Queue.prototype.enqueue = function (x) {
        this._queue.push(x);
    };
    Queue.prototype.dequeue = function () {
        return this._queue.shift();
    };
    Queue.prototype.isEmpty = function () {
        return this._queue.length == 0;
    };
    return Queue;
}());
var q = new Queue();
q.enqueue(123);
q.enqueue(234);
q.enqueue(345);
q.enqueue("END");
while (!q.isEmpty()) {
    console.log(q.dequeue());
}
