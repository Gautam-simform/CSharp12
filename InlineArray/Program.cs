using BenchmarkDotNet.Running;
using InlineArray;

var summary = BenchmarkRunner.Run<InlineArrayCreationBanchmark>();

/*
 
- Banchmark result says that Inline array does not allocate any heap memory and also the time to create a inline array is also less.
- The memory allocation is in the stack and not in the heap because inline arrays uses struct for create an instance.
- So inline array is performante than normal aray.
 
 */