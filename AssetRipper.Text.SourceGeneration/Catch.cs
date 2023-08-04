namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Catch
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public Catch(IndentedTextWriter writer, string? type = null, string? variable = null, string? condition = null)
	{
		string catchStatement = string.IsNullOrEmpty(type)
			? "catch"
			: string.IsNullOrEmpty(variable)
				? $"catch ({type})"
				: $"catch ({type} {variable})";
		string whenStatement = string.IsNullOrEmpty(condition) ? "" : $" when ({condition})";

		writer.WriteLine(catchStatement + whenStatement);
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}
}
