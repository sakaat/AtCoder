// https://atcoder.jp/contests/abc175/submissions/16534926

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

func abs(x int64) int64 {
	if x < 0 {
		return -x
	}
	return x
}

func min(x, y int64) int64 {
	if x > y {
		return y
	} else {
		return x
	}
}

func main() {
	var X, K, D int64 = abs(int64(nextInt())), int64(nextInt()), int64(nextInt())
	var r int64 = min(K, X/D)
	var X1 int64 = X - r*D
	if (K-r)%2 == 1 {
		fmt.Println(abs(X1 - D))
	} else {
		fmt.Println(X1)
	}
}
