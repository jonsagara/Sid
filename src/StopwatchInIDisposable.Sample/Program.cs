// See https://aka.ms/new-console-template for more information

using StopwatchInIDisposable;

Console.WriteLine("Starting test of Sid...");

using var totalTime = new Sid("total");

using (var fakeDelay = new Sid("fake delay"))
{
    await Task.Delay(millisecondsDelay: 3_000);
}

Console.WriteLine("Done.");
