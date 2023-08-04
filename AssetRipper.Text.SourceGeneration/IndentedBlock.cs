namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct IndentedBlock
{
	private readonly IndentedTextWriter writer;

	public IndentedBlock(IndentedTextWriter writer)
	{
		this.writer = writer;
		writer.Indent++;
	}

	public void Dispose()
	{
		writer.Indent--;
	}
}
