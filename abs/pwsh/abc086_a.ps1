[int] $a, [int] $b = (Read-Host).Split()
if ($a * $b % 2 -ne 0)
{
    'Odd'
}
else
{
    'Even'
}
