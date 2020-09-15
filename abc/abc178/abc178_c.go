// https://atcoder.jp/contests/abc178/submissions/16758011

package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

const (
	mod            = 1e9 + 7
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

func modPow(x int64, y int) int64 {
	m := x % mod
	for i := 1; i < y; i++ {
		m = (m * x) % mod
	}
	return m
}

func main() {
	N := nextInt()
	result := modPow(10, N)
	result = (result + mod - modPow(9, N)) % mod
	result = (result + mod - modPow(9, N)) % mod
	result = (result + modPow(8, N)) % mod
	fmt.Println(result)
}
