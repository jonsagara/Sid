# Sid: `Stopwatch` in `IDisposable`

This is a simple class that contains a `System.Diagnostics.Stopwatch`. The constructor starts the `Stopwatch`, and the `Dispose` method stops it. By default, the elapsed time is written to the console, though you can customize that by passing an `Action<string, TimeSpan>` argument to the constructor.

# Usage

```csharp
using StopwatchInIDisposable;

Console.WriteLine("Starting test of Sid...");

// This will dispose at the end of the program.
using var totalTime = new Sid("total");

// This will dispose at the end of the block.
using (var fakeDelay = new Sid("fake delay"))
{
    await Task.Delay(millisecondsDelay: 3_000);
}

// This will dispose at the end of the block, and it has customized output.
using (var customOutput = new Sid("custom output", (tag, elapsed) => Console.WriteLine($"Custom output for '{tag}': {elapsed}")))
{
    await Task.Delay(millisecondsDelay: 500);
}

Console.WriteLine("Done.");
```

Output:

```
Starting test of Sid...
'fake delay' took 00:00:03.0064106.
Custom output for 'custom output': 00:00:00.5099668
Done.
'total' took 00:00:03.5288611.

Process finished with exit code 0.
```

# Buy why?

Over the years, I have found myself writing this pattern over and over again:

```csharp
var sw = Stopwatch.StartNew();
try
{
    // Do some stuff
}
finally
{
    sw.Stop();
    Console.WriteLine($"Doing some stuff took {sw.Elapsed}.");
}
```

With `Sid`, I can simplify the call site to this:

```csharp
using (var sid = new Sid("Doing some stuff"))
{
    // Do some stuff
}
```