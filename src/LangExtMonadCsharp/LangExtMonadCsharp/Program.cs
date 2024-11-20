
using LangExtMonadCsharp;

WriteLine("Hello, World!");
WriteLine("Using LanguageExt (Functional programming Csharp)");

Options.WorkingWithOptions();
EitherResults.WorkinWithEither();
LangExtMonadCsharp.Try.WorkingWithTry();

//lazy loading
//Lazy<int> lazyValue = Lazy<int>(() => 42);

//Sequences
Seq<int> seq = Seq(1, 2, 3, 4, 5);
seq.Map(x => x * 2).ToList().ForEach(WriteLine);

Validations.WorkingWithValidations();

Option<int> result = Option<int>.Some(42)
           .Do(value => WriteLine($"Value before transformation: {value}"))
           .Map(value => value * 2)
           .Do(value => WriteLine($"Value after transformation: {value}"));

Seq<int> anotherSeq = Seq(1, 2, 3, 4, 5, 6);
Seq<int> evenNumbers = anotherSeq.Filter(x => x % 2 == 0);
evenNumbers.ToList().ForEach(WriteLine);


Seq<int> __seq = Seq(1, 2, 3, 4, 5, 6);
__seq.Filter(x => x % 2 == 0)  // Filter even numbers
    .Do(x => WriteLine($"Processing even number: {x}"))
    .ForAll(x => { WriteLine($"Final even number: {x}"); return true; });



ReadLine();
