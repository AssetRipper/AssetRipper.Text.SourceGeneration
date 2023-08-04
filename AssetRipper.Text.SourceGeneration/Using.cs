namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Using
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public Using(IndentedTextWriter writer, string content)
	{
		writer.WriteLine($"using ({content})");
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
