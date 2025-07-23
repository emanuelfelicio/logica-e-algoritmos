function minimumDistances(a) {
  const lastIndexes = new Map();
  let minDistance = -1;
  let n = a.length;
  for (let index = 0; index < n; index++) {
    if (lastIndexes.has(a[index])) {
      let value = lastIndexes.get(a[index]);
      if (minDistance === -1) {
        minDistance = index - value;
      } else {
        minDistance = Math.min(minDistance, index - value);
      }
      lastIndexes.set(a[index], index);
    } else {
      lastIndexes.set(a[index], index);
    }
  }
  return minDistance;
}
