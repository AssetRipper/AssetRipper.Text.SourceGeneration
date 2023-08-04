namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Indented
{
	public IndentedTextWriter Writer { get; }

	public Indented(IndentedTextWriter writer)
	{
		Writer = writer;
		Writer.Indent++;
	}

	public void Dispose()
	{
		Writer.Indent--;
	}
}
