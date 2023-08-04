namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct If
{
	private readonly CurlyBrackets curlyBrackets;

	public IndentedTextWriter Writer => curlyBrackets.Writer;

	public If(IndentedTextWriter writer, string condition)
	{
		writer.WriteLine($"if ({condition})");
		curlyBrackets = new CurlyBrackets(writer);
	}

	public void Dispose()
	{
		curlyBrackets.Dispose();
	}

	public static void Write(IndentedTextWriter writer, IEnumerable<(string, Action<IndentedTextWriter>?)> ifBlocks, Action<IndentedTextWriter>? elseBlock = null)
	{
		bool first = true;
		foreach ((string condition, Action<IndentedTextWriter>? block) in ifBlocks)
		{
			if (first)
			{
				first = false;
				using (new If(writer, condition))
				{
					block?.Invoke(writer);
				}
			}
			else
			{
				using (new ElseIf(writer, condition))
				{
					block?.Invoke(writer);
				}
			}
		}
		if (elseBlock is not null)
		{
			using (new Else(writer))
			{
				elseBlock.Invoke(writer);
			}
		}
	}
}
