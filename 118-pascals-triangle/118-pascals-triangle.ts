/**
 * Pascal's Triangle
 * Given a non-negative integer numRows, 
 * generate the first numRows of Pascal's triangle.
 *
 * Time Complexity: O(n*n)
 * Space Complexity: O(n*n)
 *
 * generate(3) // [[1],[1,1],[1,2,1]]
 * generate(4) // [[1],[1,1],[1,2,1],[1,3,3,1]]
 */
function generate(numRows: number): number[][] {
    let triangle: number[][] = [];
    let y = 0;
    
    while (y < numRows) {
        // row 1
        if (y === 0) {
            triangle.push([1]);
        }
        // row 2
        else if (y === 1) {
            triangle.push([1, 1]);
        }
        // row n+1
        else {
            let x = 0;
            let row = [1];
            while (x < y - 1) {
                row.push(triangle[y-1][x]
                       + triangle[y-1][x+1]);
                x += 1;
            }
            row.push(1);
            triangle.push(row);    
        }
        y += 1;
    }
    
    return triangle;
}