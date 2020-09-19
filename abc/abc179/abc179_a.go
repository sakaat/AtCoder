// https://atcoder.jp/contests/abc179/submissions/16892086

package main

import (
	"bufio"
	"fmt"
	"os"
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

func main() {
	S := next()
	result := S
	if S[len(S)-1] == 's' {
		result += "es"
	} else {
		result += "s"
	}
	fmt.Println(result)
}
