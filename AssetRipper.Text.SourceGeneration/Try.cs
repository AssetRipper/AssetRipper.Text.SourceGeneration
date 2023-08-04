namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Try
{
	private readonly NamedBlock block;

	public IndentedTextWriter Writer => block.Writer;

	public Try(IndentedTextWriter writer)
	{
		block = new NamedBlock(writer, "try");
	}

	public void Dispose()
	{
		block.Dispose();
	}
}
