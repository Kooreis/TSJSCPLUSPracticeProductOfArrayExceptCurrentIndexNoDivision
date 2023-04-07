Here is a JavaScript solution for the problem:

```javascript
function productExceptSelf(nums) {
    let length = nums.length;
    let answer = Array(length).fill(1);
    let left = 1;
    let right = 1;

    for (let i = 0; i < length; i++) {
        answer[i] *= left;
        left *= nums[i];
    }

    for (let i = length - 1; i >= 0; i--) {
        answer[i] *= right;
        right *= nums[i];
    }

    return answer;
}

console.log(productExceptSelf([1, 2, 3, 4]));
```

This console application will output the product of an array except for the current index without using division. The function `productExceptSelf` takes an array of numbers as input and returns an array of products. The function uses two loops to calculate the product of the numbers to the left and right of each index. The product of the numbers to the left is stored in the `answer` array, and the product of the numbers to the right is multiplied with the corresponding value in the `answer` array. The final `answer` array is then returned. The console.log statement at the end of the script will print the output of the function when called with the array `[1, 2, 3, 4]`.