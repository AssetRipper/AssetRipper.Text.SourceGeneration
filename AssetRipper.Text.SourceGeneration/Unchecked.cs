namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Unchecked
{
	private readonly NamedBlock block;

	public IndentedTextWriter Writer => block.Writer;

	public Unchecked(IndentedTextWriter writer)
	{
		block = new NamedBlock(writer, "unchecked");
	}

	public void Dispose()
	{
		block.Dispose();
	}
}
