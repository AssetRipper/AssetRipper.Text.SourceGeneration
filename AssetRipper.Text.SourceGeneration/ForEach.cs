namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct ForEach
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public ForEach(IndentedTextWriter writer, string type, string variable, string enumerable)
	{
		writer.WriteLine($"foreach ({type} {variable} in {enumerable})");
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
