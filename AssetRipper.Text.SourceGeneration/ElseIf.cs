namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct ElseIf
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public ElseIf(IndentedTextWriter writer, string condition)
	{
		writer.WriteLine($"else if ({condition})");
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
