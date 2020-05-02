# https://atcoder.jp/contests/abc165/submissions/12671808

import itertools

N, M, Q = map(int, input().split())
A = [list(map(int, input().split())) for _ in range(Q)]

result = 0
for x in itertools.combinations_with_replacement(range(1, M + 1), N):
    temp = 0
    for a, b, c, d in A:
        if x[b - 1] - x[a - 1] == c:
            temp += d
    if temp > result:
        result = temp

print(result)
