/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function (nums) {
  let result = 0;
  for (let index = 0; index < nums.length; index++) {
    result ^= nums[index];
  }
  return result
};
