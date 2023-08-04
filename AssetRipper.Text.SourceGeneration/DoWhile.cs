namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct DoWhile
{
	private readonly Indented indented;
	private readonly string condition;

	public IndentedTextWriter Writer => indented.Writer;

	public DoWhile(IndentedTextWriter writer, string condition = "true")
	{
		this.condition = condition;
		writer.WriteLine("do");
		writer.WriteLine('{');
		indented = new Indented(writer);
	}

	public void Dispose()
	{
		indented.Dispose();
		Writer.WriteLine($"}} while ({condition});");
	}
}
