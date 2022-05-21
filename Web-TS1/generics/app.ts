class Queue<T> {
    _queue: T[];

    constructor() {
        this._queue = [];
    }

    enqueue(x: T): void {
        this._queue.push(x);
    }
    dequeue(): T {
        return this._queue.shift();
    }
    isEmpty() {
        return this._queue.length == 0;
    }
}

const q = new Queue<number>();
q.enqueue(123);
q.enqueue(234);
q.enqueue(345);
// no function
// q.enqueue("END");
while (!q.isEmpty()) {
    console.log(q.dequeue());
}
