namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Namespace
{
	internal readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public Namespace(IndentedTextWriter writer, string @namespace)
	{
		writer.WriteLine($"namespace {@namespace}");
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
