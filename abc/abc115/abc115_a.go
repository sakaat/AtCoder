// https://atcoder.jp/contests/abc115/submissions/16818300

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
	d := "Christmas"
	switch nextInt() {
	case 24:
		d += " Eve"
	case 23:
		d += " Eve Eve"
	case 22:
		d += " Eve Eve Eve"
	}
	fmt.Println(d)
}
