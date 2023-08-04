﻿namespace AssetRipper.Text.SourceGeneration;

public readonly ref struct Namespace
{
	private readonly CurlyBrackets curlyBrackets;

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
