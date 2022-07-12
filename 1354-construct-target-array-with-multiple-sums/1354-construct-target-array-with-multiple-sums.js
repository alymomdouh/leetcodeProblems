/**
 * @param {number[]} target
 * @return {boolean}
 */
//w/ MaxPriorityQueue():
var isPossible = function(target) {
    let pq = new MaxPriorityQueue({priority: x => x}), sum = 0
    for (let num of target) sum += num, pq.enqueue(num)
    while (pq.front().element !== 1) {
        let num = pq.dequeue().element
        sum -= num
        if (num <= sum || sum < 1) return false
        num %= sum, sum += num, pq.enqueue(num || sum)
    }
    return true
};

//w/ Max-Heap:
var isPossible = function(target) {
    let heap = [,], sum = 0

    const heapify = val => {
        let i = heap.length, par = i >> 1, temp
        heap.push(val)
        while (heap[par] < heap[i]) {
            temp = heap[par], heap[par] = heap[i], heap[i] = temp
            i = par, par = i >> 1
        }
    }
    const extract = () => {
        if (heap.length === 1) return null
        let top = heap[1], left, right, temp,
            i = 1, child = heap[3] > heap[2] ? 3 : 2
        if (heap.length > 2) heap[1] = heap.pop()
        else heap.pop()
        while (heap[i] < heap[child]) {
            temp = heap[child], heap[child] = heap[i], heap[i] = temp
            i = child, left = i << 1, right = left + 1
            child = heap[right] > heap[left] ? right : left
        }
        return top
    }

    for (let num of target) sum += num, heapify(num)
    while (heap[1] !== 1) {
        let num = extract()
        sum -= num
        if (num <= sum || sum < 1) return false
        num %= sum, sum += num, heapify(num || sum)
    }
    return true
};