<Query Kind="Program" />

void Main()
{
	var arr = Enumerable.Range(1,100).ToArray();
	ReverseInPlace(arr);
	arr.Dump();
}

// was not able to do this on a whiteboard in an interview without allocating a new array
// this is one potential solution
public void ReverseInPlace(int[] arr)
{
	var start = 0;
	var end = arr.Length - 1;
	
	while(start < end)
	{
		var tmp = arr[start];
		arr[start] = arr[end];
		arr[end] = tmp;
		start++;
		end--;
	}
}