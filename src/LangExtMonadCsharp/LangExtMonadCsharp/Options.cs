using System;

namespace LangExtMonadCsharp;

static internal class Options
{
    public static void WorkingWithOptions()
    {
        Option<int> someValue = Option<int>.Some(42);
        Option<int> noneValue = Option<int>.None;

        WriteLine(@$"
            Option<int> someValue = Option<int>.Some(42);
            Option<int> noneValue = Option<int>.None;
                <Match>
        ");

        // Working with Option
        someValue.Match(
            v => WriteLine($"Value: {v}"),
            () => WriteLine("No value")
        );

        noneValue.Match(
            v => WriteLine($"Value: {v}"),
            () => WriteLine("No value")
        );

        // IfSome will execute only for Right values
        someValue.IfSome(v => WriteLine($"Right value: {v}")); // Prints "Right value: 42"
        noneValue.IfSome(v => WriteLine($"This will not be printed for Left"));
    }
}
