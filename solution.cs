for (let i = 0; i < length; i++) {
        answer[i] *= left;
        left *= nums[i];
    }