{
	public static void main(String[] args)
	{
		int n = 6;
		System.out.println("Fatorial de 6 = " + fatorial(n));
	}
	public static int fatorial(int n)
	{
		if (n == 0)
			return 1;
		else
			return (n * fatorial (n - 1));
	}
}
