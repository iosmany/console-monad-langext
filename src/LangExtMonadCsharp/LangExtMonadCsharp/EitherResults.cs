using LanguageExt.SomeHelp;

namespace LangExtMonadCsharp;

static internal class EitherResults
{
    public static void WorkinWithEither()
    {
        Either<string, int> success = Right(42);
        Either<string, int> failure = Left("Error occurred");

        WriteLine(@"
Either<string, int> success = Right(42);
Either<string, int> failure = Left(""Error occurred"");

<Match>        
");

        success.Match(
            Right: v => WriteLine($"Success: {v}"),
            Left: e => WriteLine($"Failure: {e}")
        );

        failure.Match(
            Right: v => WriteLine($"Success: {v}"),
            Left: e => WriteLine($"Failure: {e}")
        );

        var result = success.Bind(x => Either<string, int>.Right(x * 2));

        WriteLine(
            @"

var result = success.Bind(x => Either<string, int>.Right(x * 2));
");

        result.Match(
            Right: v => WriteLine($"Transformed value: {v}"),
            Left: e => WriteLine($"Error: {e}")
        );
        failure.Bind(x => Either<string, int>.Right(x * 2))
               .Match(
                   Right: v => WriteLine($"Transformed value: {v}"),
                   Left: e => WriteLine($"Error: {e}")
               );


        result= success.BiBind(
            Right: x => Either<string, int>.Right(x * 2),
            Left: e => Either<string, int>.Left(e.ToUpper())
        );

        WriteLine(
            @"
result= success.BiBind(
            Right: x => Either<string, int>.Right(x * 2),
            Left: e => Either<string, int>.Left(e.ToUpper())
        );
");

        result.Match(
            Right: v => WriteLine($"Transformed Right value: {v}"),
            Left: e => WriteLine($"Transformed Left value: {e}")
        );

        // BiBind on Left
        var failureResult = failure.BiBind(
            Right: x => Either<string, int>.Right(x * 2),
            Left: e => Either<string, int>.Left(e.ToUpper())
        );

        failureResult.Match(
            Right: v => WriteLine($"Transformed Right value: {v}"),
            Left: e => WriteLine($"Transformed Left value: {e}")
        );

    }
}
