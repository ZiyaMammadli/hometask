using System;
namespace generic_constraint.models
{
	public class MyClass<T>
	{
		private T[] Arr;
		public MyClass()
		{
			Arr = new T[0];
		}
		public void Add(T obj)
		{
			Array.Resize(ref Arr, Arr.Length + 1);
			Arr[^1] = obj;
		}
		public void ShowAll()
		{
			foreach (var item in Arr)
			{
				Console.WriteLine(item);		
			}
			Console.WriteLine(Arr.Length);
		}
		public int FindIndexOF(T obj)
		{
			for(int i = 0; i < Arr.Length; i++)
			{
				if (obj.Equals(Arr[i]))
				{
					return i;
				}				
			}
			return -1;
		}
		public void Remove(T obj)
		{
			for(int i = 0; i <= Arr.Length-1; i++)
			{
				if (obj.Equals(Arr[i]))
				{
					Arr[i] = default;
					for(int j = i; j < Arr.Length - 1; j++)
					{
						Arr[j] = Arr[j + 1];
					}
						Array.Resize(ref Arr, Arr.Length - 1);
				}				
			}
		}
	}
}

