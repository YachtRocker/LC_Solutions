"use strict";

const removeElement = function (nums, val) {
  // remove element
  let total = 0;
  console.log(nums);
  nums.sort(function (a, b) {
    return a - b;
  });
  for (let i = nums.length - 1; i >= 0; i--) {
    if (nums[i] === val) {
      nums.splice(i, 1);
      total++;
    }
    if (nums[i] < val) {
      break;
    }
  }
  console.log(nums);
  return nums;
};

//const nums = [3, 2, 2, 3];
// const nums = [0, 1, 2, 2, 3, 0, 4, 2];
const nums = [
  7, 25, 21, 2, 20, 7, 24, 9, 24, 24, 6, 22, 5, 1, 26, 17, 18, 29, 25, 9, 8, 27,
  6, 26, 8, 5, 27, 5, 0, 29, 26, 29, 24, 18, 23, 14, 25, 17, 15, 20, 11, 22, 4,
  17, 15, 0, 26, 3, 21, 21, 12, 0, 10, 10, 26, 19, 15, 23, 16, 7, 14, 12, 7, 8,
  0, 0, 14, 26, 18, 22, 8, 21, 6, 12, 0, 21, 4, 26, 16, 26, 18, 21,
];
const val = 26;

console.log(removeElement(nums, val));
