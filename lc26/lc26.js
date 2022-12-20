"use strict";

//  Leetcode: 26
//  In Javascript

const removeDuplicates = function (nums) {
  let l = 1;

  for (let r = 1; r < nums.length; r++) {
    if (nums[r] != nums[r - 1]) {
      nums[l] = nums[r];
      l += 1;
    }
  }

  console.log(nums);
  return l;
};

const a = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
console.log(removeDuplicates(a));
