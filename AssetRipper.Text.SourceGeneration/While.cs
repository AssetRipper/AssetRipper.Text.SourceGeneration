namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct While
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public While(IndentedTextWriter writer, string condition = "true")
	{
		writer.WriteLine($"while ({condition})");
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
