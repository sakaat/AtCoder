// https://atcoder.jp/contests/abc115/submissions/16818494

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

func sum(x []int) int {
	s := x[0]
	for i := 1; i < len(x); i++ {
		s += x[i]
	}
	return s
}

func max(x []int) int {
	m := x[0]
	for i := 1; i < len(x); i++ {
		if m < x[i] {
			m = x[i]
		}
	}
	return m
}

func main() {
	N := nextInt()
	p := make([]int, N)
	for i := 0; i < N; i++ {
		p[i] = nextInt()
	}
	fmt.Println(sum(p) - max(p)/2)
}
