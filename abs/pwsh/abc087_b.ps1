# https://atcoder.jp/contests/abs/tasks/abc087_b

[int] $A = Read-Host
[int] $B = Read-Host
[int] $C = Read-Host
[int] $X = Read-Host

$result = 0
for ($i = 0; $i -le $A; $i++)
{
    for ($j = 0; $j -le $B; $j++)
    {
        $k = ($X - $i * 500 - $j * 100) / 50
        if ($k -ge 0 -and $k -le $C)
        {
            $result++
        }
    }
}
$result
