# https://atcoder.jp/contests/abc158/submissions/10623651

import math

N, A, B = map(int, input().split())
print(A * math.floor(N / (A + B)) + min(A, N % (A + B)))
