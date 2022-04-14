using System.Diagnostics;

namespace StopwatchInIDisposable;

/// <summary>
/// Stopwatch wrapped in IDisposable. Slightly simplifies the use of Stopwatch by not
/// requiring you to explicitly write a try/finally block.
/// </summary>
public class Sid : IDisposable
{
    private static readonly Action<string, TimeSpan> _defaultOutput =
        (tag, elapsed) => Console.WriteLine($"'{tag}' took {elapsed}.");
    
    private readonly string _tag;
    private readonly Action<string, TimeSpan> _output;
    private readonly Stopwatch _stopwatch;

    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="tag">A user-friendly name for the stopwatch.</param>
    /// <param name="output">Takes the tag and the elapsed TimeSpan as arguments and outputs a string
    /// after stopping the Stopwatch in the Dispose method.</param>
    public Sid(string tag, Action<string, TimeSpan>? output = null)
    {
        ArgumentNullException.ThrowIfNull(tag);

        _tag = tag;
        _output = output ?? _defaultOutput;
        _stopwatch = Stopwatch.StartNew();
    }
    
    public void Dispose()
    {
        _stopwatch.Stop();
        _output(_tag, _stopwatch.Elapsed);
    }
}
