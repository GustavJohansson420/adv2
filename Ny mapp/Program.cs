using

var data = (from line in File.ReadAllLines(input.txt) where !string.IsNullOrWhiteSpace(line) select line).ToArray();

var scores = new Dictionary<string, long>
{
    {"X", 1},
    {"Y", 2},
    {"Z", 3},
};

var names = new directionary<string, string>
{
    {"A", "rock"},
    {"B", "paper"},
    {"C", "scissors"},
    {"X", "rock"},
    {"Y", "paper"},
    {"Z", "scissors"},
};

bool? IsWinner(string opponent, string me)
{
    return (opponent, me) switch
    {
        ("A", "X") => null,
        ("A", "Y") => true,
        ("A", "Z") => false,
        ("B","X") => false,
        ("B","Y") => null,
        ("B","Z") => true,
        ("C", "X") => true,
        ("C", "Y") => false,
        ("C", "Z") => null,
        _ => throw new InvalidOperationExeption(),
    };
}

long WinnerScore(boll? winner)
{
    return winner switch
    {
        true => 6,
        false => 0,
        _ => 3,
    };
}

long GetPart1()
{
    var score = 0L;

    foreach (var line in data)
    {
        var pieces = line.Split(" ");
        var opponents = pieces[0];
        var me = pieces[1];
        var winner = IsWinner(opponent, me);
        var lineScore = scores[me] + WinnerScore(winner);
        score += lineScore;
    }
    return score;
}

long GetPart2()
{
    return 0L;
}