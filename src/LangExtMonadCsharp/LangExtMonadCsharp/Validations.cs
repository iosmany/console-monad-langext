namespace LangExtMonadCsharp;

static internal class Validations
{
    public static void WorkingWithValidations()
    {
        Validation<string, int> success = Validation<string, int>.Success(42);
        Validation<string, int> failure = Validation<string, int>.Fail(Seq1("Failure"));

        WriteLine(@"
Validation<string, int> success = Validation<string, int>.Success(42);
Validation<string, int> failure = Validation<string, int>.Fail(Seq1(""Failure""));

<Match>
        ");

        success.Match(
            Succ: v => WriteLine($"Valid: {v}"),
            Fail: e => WriteLine($"Invalid: {e}")
        );

        failure.Match(
            Succ: v => WriteLine($"Valid: {v}"),
            Fail: e => WriteLine($"Invalid: {e}")
        );
    }
}
