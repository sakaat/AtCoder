// https://atcoder.jp/contests/abc179/submissions/16892576

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
	N := nextInt()
	D := make([][]int, N)
	for i := 0; i < N; i++ {
		D[i] = make([]int, 2)
		D[i][0], D[i][1] = nextInt(), nextInt()
	}
	count := 0
	result := "No"
	for i := 0; i < N; i++ {
		if D[i][0] == D[i][1] {
			count++
		} else {
			count = 0
		}
		if count == 3 {
			result = "Yes"
			break
		}
	}
	fmt.Println(result)
}
