// https://atcoder.jp/contests/abc175/submissions/16534651

package main

import (
	"bufio"
	"fmt"
	"os"
	"sort"
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
	var L []int = make([]int, N)
	for i := 0; i < N; i++ {
		L[i] = nextInt()
	}
	sort.Ints(L)
	var result int
	for i := 0; i < N; i++ {
		for j := i + 1; j < N; j++ {
			for k := j + 1; k < N; k++ {
				if L[i] != L[j] && L[j] != L[k] && L[k] != L[i] {
					if L[k] < L[i]+L[j] {
						result++
					}
				}
			}
		}
	}
	fmt.Println(result)
}
