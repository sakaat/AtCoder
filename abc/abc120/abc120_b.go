// https://atcoder.jp/contests/abc120/submissions/16643403

package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

const (
	initialBufSize = 1e4
	maxBufSize     = 1e8
)

var sc = bufio.NewScanner(os.Stdin)

func init() {
	buf := make([]byte, initialBufSize)
	sc.Buffer(buf, maxBufSize)
	sc.Split(bufio.ScanWords)
}

func next() string {
	sc.Scan()
	return sc.Text()
}

func nextInt() int {
	a, _ := strconv.Atoi(next())
	return a
}

func min(x, y int) int {
	if x > y {
		return y
	} else {
		return x
	}
}

func main() {
	A, B, K := nextInt(), nextInt(), nextInt()
	result := 0
	r := 0

	for i := min(A, B); ; i-- {
		if A%i == 0 && B%i == 0 {
			r++
			if K == r {
				result = i
				break
			}
		}
	}
	fmt.Println(result)
}
