namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct CurlyBrackets
{
	private readonly Indented indented;

	public IndentedTextWriter Writer => indented.Writer;

	public CurlyBrackets(IndentedTextWriter writer)
	{
		writer.WriteLine('{');
		indented = new Indented(writer);
	}

	public void Dispose()
	{
		indented.Dispose();
		Writer.WriteLine('}');
	}
}
