Here is a TypeScript solution for the problem:

```typescript
function productExceptSelf(nums: number[]): number[] {
    let length = nums.length;
    let answer = Array(length).fill(1);

    let left = 1;
    for (let i = 0; i < length; i++) {
        answer[i] *= left;
        left *= nums[i];
    }

    let right = 1;
    for (let i = length - 1; i >= 0; i--) {
        answer[i] *= right;
        right *= nums[i];
    }

    return answer;
}

console.log(productExceptSelf([1, 2, 3, 4]));
```

This solution works by first initializing an array of the same length as the input array with all elements as 1. Then it calculates the product of all the numbers to the left of each index and stores it in the answer array. Then it calculates the product of all the numbers to the right of each index and multiplies it with the corresponding element in the answer array. This gives the product of all numbers except the number at the current index.