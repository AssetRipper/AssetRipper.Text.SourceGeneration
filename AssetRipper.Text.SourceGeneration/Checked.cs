namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Checked
{
	private readonly NamedBlock block;

	public IndentedTextWriter Writer => block.Writer;

	public Checked(IndentedTextWriter writer)
	{
		block = new NamedBlock(writer, "checked");
	}

	public void Dispose()
	{
		block.Dispose();
	}
}
