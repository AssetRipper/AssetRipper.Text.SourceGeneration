namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Else
{
	private readonly NamedBlock block;

	public IndentedTextWriter Writer => block.Writer;

	public Else(IndentedTextWriter writer)
	{
		block = new NamedBlock(writer, "else");
	}

	public void Dispose()
	{
		block.Dispose();
	}
}
