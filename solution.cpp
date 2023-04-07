```cpp
#include <iostream>
#include <vector>

std::vector<int> productExceptSelf(std::vector<int>& nums) {
    int n = nums.size();
    std::vector<int> res(n, 1);
    for (int i = 1; i < n; ++i) {
        res[i] = res[i - 1] * nums[i - 1];
    }
    int right = 1;
    for (int i = n - 1; i >= 0; --i) {
        res[i] *= right;
        right *= nums[i];
    }
    return res;
}

int main() {
    std::vector<int> nums = {1, 2, 3, 4};
    std::vector<int> res = productExceptSelf(nums);
    for (int i = 0; i < res.size(); ++i) {
        std::cout << res[i] << " ";
    }
    return 0;
}
```