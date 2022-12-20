using factorial;
using System;
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
//var res = 500000.AsParallelFactorial(); //21.7
//var res = 500000.ParallelForFactorial(); // 20.5
//var res = 500000.TaskFactorial(); // 20.2
//var res = 500000.ThreadFactorial(); // 36.8
//var res = 500000.Factorial(); // я не дождался
//var res = 500000.ParallelForFactorial(1024); // 11
var res = 100.TaskFactorial(); // 5.8
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);