function howManyGames(p, d, m, s) {
  let games = 0;
  while (s >= p) {
    s -= p;
    games++;
    p -= d;
    if (p < m) {
      p = m;
    }
  }
  return games;
}
