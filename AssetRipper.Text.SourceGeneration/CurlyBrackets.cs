namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct CurlyBrackets
{
	private readonly IndentedTextWriter writer;

	[Obsolete("Use CurlyBrackets(IndentedTextWriter) instead.", true)]
	public CurlyBrackets() => throw new NotSupportedException();

	public CurlyBrackets(IndentedTextWriter writer)
	{
		this.writer = writer;
		writer.WriteLine("{");
		writer.Indent++;
	}

	public void Dispose()
	{
		writer.Indent--;
		writer.WriteLine("}");
	}
}
