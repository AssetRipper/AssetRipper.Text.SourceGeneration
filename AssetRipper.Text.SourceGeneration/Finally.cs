namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Finally
{
	private readonly NamedBlock block;

	public IndentedTextWriter Writer => block.Writer;

	public Finally(IndentedTextWriter writer)
	{
		block = new NamedBlock(writer, "finally");
	}

	public void Dispose()
	{
		block.Dispose();
	}
}
