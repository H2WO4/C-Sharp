using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Benchmarking;

public static class Program
{
	public static void Main(string[] args)
	{
		BenchmarkRunner.Run<Benchmark>();
	}
}

[MemoryDiagnoser]
public class Benchmark
{
	[Benchmark(Baseline = true)]
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void Assignment()
	{
		Methods.Assignment(5);
		Methods.Assignment(-30);
		Methods.Assignment(678545749);
	}
	
	[Benchmark]
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void AugmentedAssignment()
	{
		Methods.AugmentedAssignment(5);
		Methods.Assignment(-30);
		Methods.Assignment(678545749);
	}
	
	[Benchmark]
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void PostIncrementation()
	{
		Methods.PostIncrementation(5);
		Methods.Assignment(-30);
		Methods.Assignment(678545749);
	}
	
	[Benchmark]
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void PreIncrementation()
	{
		Methods.PreIncrementation(5);
		Methods.Assignment(-30);
		Methods.Assignment(678545749);
	}
}

public static class Methods
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Assignment(int x)
	{
		x = x + 1;
		x = x + 1;
		x = x + 1;
		x = x + 1;
		x = x + 1;
		x = x + 1;
		x = x + 1;
		x = x + 1;
		x = x + 1;
		x = x + 1;
	}
	
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void AugmentedAssignment(int x)
	{
		x += 1;
		x += 1;
		x += 1;
		x += 1;
		x += 1;
		x += 1;
		x += 1;
		x += 1;
		x += 1;
		x += 1;
	}
	
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void PostIncrementation(int x)
	{
		x++;
		x++;
		x++;
		x++;
		x++;
		x++;
		x++;
		x++;
		x++;
		x++;
	}
	
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void PreIncrementation(int x)
	{
		++x;
		++x;
		++x;
		++x;
		++x;
		++x;
		++x;
		++x;
		++x;
		++x;
	}
}