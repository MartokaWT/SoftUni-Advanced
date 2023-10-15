public static class Kata
{
	public static int SquareSum(int[] numbers)
	{
		for (int i = 0; i < numbers.Length; i++)
		{
			numbers[i] *= numbers[i];
		}

		int result = 0;

		foreach (int number in numbers)
		{
			result += number;
		}

		return result;
	}
}