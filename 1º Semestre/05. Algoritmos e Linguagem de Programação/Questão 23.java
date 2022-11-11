{
	public static void main(String[] args)
	{
		int n = 10;
		System.out.println("Fibonacci de 10 é: " + fibonacci(n));
	}
	
	public static int fibonacci(int n)
	
	{
		if (n == 0 || n == 1)
			return n;
		else
			return fibonacci(n - 1) + fibonacci(n - 2);
	}
}
