namespace LangExtMonadCsharp;

static internal class Try
{

    public static void WorkingWithTry()
    {
        Try<int> success = Try(() => 42);
        Try<int> failure = Try<int>(() => throw new Exception("Something went wrong"));

        WriteLine(@"
Try<int> success = Try(() => 42);
Try<int> failure = Try<int>(() => throw new Exception(""Something went wrong""));

<Match>
");


        success.Match(
            res => Console.WriteLine($"Success: {res}"),
            ex => Console.WriteLine($"Error: {ex.Message}")
        );

        failure.Match(
            res => Console.WriteLine($"Success: {res}"),
            ex => Console.WriteLine($"Error: {ex.Message}")
        );
    }
}
