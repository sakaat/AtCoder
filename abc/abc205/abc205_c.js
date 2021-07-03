// https://atcoder.jp/contests/abc205/submissions/23935030

function main(input) {
  const [A, B, C] = input.split(" ").map(Number);
  const vC = C % 2 === 0 ? 2 : 1;

  let result;
  if (Math.pow(A, vC) === Math.pow(B, vC)) {
    result = "=";
  } else if (Math.pow(A, vC) > Math.pow(B, vC)) {
    result = ">";
  } else {
    result = "<";
  }
  console.log(result);
}

main(require("fs").readFileSync("/dev/stdin", "utf8"));
