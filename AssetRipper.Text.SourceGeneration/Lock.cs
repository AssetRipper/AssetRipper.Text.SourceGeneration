namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Lock
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public Lock(IndentedTextWriter writer, string variable)
	{
		writer.WriteLine($"lock ({variable})");
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
