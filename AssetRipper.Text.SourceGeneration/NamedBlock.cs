namespace AssetRipper.Text.SourceGeneration;

internal readonly ref struct NamedBlock
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public NamedBlock(IndentedTextWriter writer, string name)
	{
		writer.WriteLine(name);
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
