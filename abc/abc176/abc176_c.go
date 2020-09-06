// https://atcoder.jp/contests/abc176/submissions/16531029

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

func main() {
	var N int = nextInt()
	var A = make([]int, N)
	for i := 0; i < N; i++ {
		A[i] = nextInt()
	}
	var M int = A[0]
	var sum int
	for i := 1; i < N; i++ {
		if A[i] < M {
			sum += M - A[i]
		} else {
			M = A[i]
		}
	}
	fmt.Println(sum)
}
