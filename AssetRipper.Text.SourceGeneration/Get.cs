namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Get
{
	private readonly NamedBlock block;

	public IndentedTextWriter Writer => block.Writer;

	public Get(IndentedTextWriter writer)
	{
		block = new NamedBlock(writer, "get");
	}

	public void Dispose()
	{
		block.Dispose();
	}
}
