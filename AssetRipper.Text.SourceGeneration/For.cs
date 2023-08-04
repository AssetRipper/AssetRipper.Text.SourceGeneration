namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct For
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public For(IndentedTextWriter writer, string? initializer, string? condition, string? iterator)
	{
		writer.WriteLine($"for ({initializer}; {condition}; {iterator})");
		curlyBrackets = new CurlyBrackets(writer);
	}

	public static For Increment(IndentedTextWriter writer, string iterator = "i", string start = "0", string maximum = "0")
	{
		return new For(writer, $"int {iterator} = {start}", $"{iterator} < {maximum}", $"{iterator}++");
	}

	public static For Decrement(IndentedTextWriter writer, string iterator = "i", string start = "0", string minimum = "0")
	{
		return new For(writer, $"int {iterator} = {start}", $"{iterator} >= {minimum}", $"{iterator}--");
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
