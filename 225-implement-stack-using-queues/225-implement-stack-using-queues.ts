class MyStack {
    private list :any[];
    constructor() {
  this.list = [];
    }

    push(x: number): void {
this.list.unshift(x); 
    }

    pop(): number {
return this.list.length > 0 ? this.list.shift() : -1;
    }

    top(): number {
return this.list.length > 0 ? this.list[0] : -1;
    }

    empty(): boolean {
 return this.list.length == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * var obj = new MyStack()
 * obj.push(x)
 * var param_2 = obj.pop()
 * var param_3 = obj.top()
 * var param_4 = obj.empty()
 */