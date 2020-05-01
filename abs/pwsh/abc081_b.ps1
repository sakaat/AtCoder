# https://atcoder.jp/contests/abs/tasks/abc081_b

$_ = Read-Host
[int[]] $A = (Read-Host).Split()

$i = 0
while ($true)
{
    if (($A | ? { $_ % 2 -ne 0 }).Count -ne 0)
    {
        $i
        break
    }
    $A = $A | % { $_ / 2 }
    $i++
}
