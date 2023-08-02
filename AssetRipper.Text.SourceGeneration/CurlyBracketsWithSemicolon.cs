namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct CurlyBracketsWithSemicolon
{
	private readonly IndentedTextWriter writer;

	[Obsolete("Use CurlyBracketsWithSemicolon(IndentedTextWriter) instead.", true)]
	public CurlyBracketsWithSemicolon() => throw new NotSupportedException();

	public CurlyBracketsWithSemicolon(IndentedTextWriter writer)
	{
		this.writer = writer;
		writer.WriteLine("{");
		writer.Indent++;
	}

	public void Dispose()
	{
		writer.Indent--;
		writer.WriteLine("};");
	}
}
