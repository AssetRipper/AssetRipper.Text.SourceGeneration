namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct SquareBracketsWithSemicolon
{
	private readonly Indented indented;

	public IndentedTextWriter Writer => indented.Writer;

	public SquareBracketsWithSemicolon(IndentedTextWriter writer)
	{
		writer.WriteLine('[');
		indented = new Indented(writer);
	}

	public void Dispose()
	{
		indented.Dispose();
		Writer.WriteLine("];");
	}
}
