namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct SquareBrackets
{
	private readonly Indented indented;

	public IndentedTextWriter Writer => indented.Writer;

	public SquareBrackets(IndentedTextWriter writer)
	{
		writer.WriteLine('[');
		indented = new Indented(writer);
	}

	public void Dispose()
	{
		indented.Dispose();
		Writer.WriteLine(']');
	}
}
