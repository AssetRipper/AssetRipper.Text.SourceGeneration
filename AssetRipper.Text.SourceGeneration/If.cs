namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct If
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public If(IndentedTextWriter writer, string condition)
	{
		writer.WriteLine($"if ({condition})");
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
