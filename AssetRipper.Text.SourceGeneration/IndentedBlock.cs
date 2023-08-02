namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct IndentedBlock
{
	private readonly IndentedTextWriter writer;

	[Obsolete("Use IndentedBlock(IndentedTextWriter) instead")]
	public IndentedBlock() => throw new NotSupportedException();

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
