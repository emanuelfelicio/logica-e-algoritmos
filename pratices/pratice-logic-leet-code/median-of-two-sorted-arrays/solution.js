/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function (nums1, nums2) {
  let leftLength = nums1.length;
  let rightLength = nums2.length;
  let arrResult = new Array(leftLength + rightLength);

  let left = 0;
  let right = 0;
  let current = 0;

  while (left < leftLength && right < rightLength) {
    if (nums1[left] <= nums2[right]) {
      arrResult[current] = nums1[left];
      left++;
    } else {
      arrResult[current] = nums2[right];
      right++;
    }

    current++;
  }

  while (left < leftLength) {
    arrResult[current] = nums1[left];

    current++;
    left++;
  }
  while (right < rightLength) {
    arrResult[current] = nums2[right];
    current++;
    right++;
  }

  const n = arrResult.length;
  const result =
    n % 2 === 0
      ? Math.floor(arrResult[Math.floor(n / 2)] + arrResult[Math.floor(n / 2) - 1]) / 2
      : arrResult[Math.floor(n / 2)];

  return result;
};

const result = findMedianSortedArrays([1, 3], [2]);
