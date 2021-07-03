// https://atcoder.jp/contests/abc205/submissions/23934958

function main(input) {
  input = input.split("\n");
  const N = Number(input[0]);
  const A = input[1]
    .split(" ")
    .map(Number)
    .sort((x, y) => x - y);

  let result = "Yes";
  for (let i = 0; i < N; i++) {
    if (i + 1 !== A[i]) {
      result = "No";
      break;
    }
  }
  console.log(result);
}

main(require("fs").readFileSync("/dev/stdin", "utf8"));
