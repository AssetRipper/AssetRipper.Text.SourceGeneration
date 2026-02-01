namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Set
{
	private readonly NamedBlock block;

	public IndentedTextWriter Writer => block.Writer;

	public Set(IndentedTextWriter writer)
	{
		block = new NamedBlock(writer, "set");
	}

	public void Dispose()
	{
		block.Dispose();
	}
}
