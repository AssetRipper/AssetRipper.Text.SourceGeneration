namespace AssetRipper.Text.SourceGeneration;

// The deviation from our naming convention is intended to avoid
// conflict with System.Runtime.CompilerServices.Unsafe, which is
// commonly used in source generated code.
public readonly ref struct UnsafeBlock
{
	private readonly NamedBlock block;

	public IndentedTextWriter Writer => block.Writer;

	public UnsafeBlock(IndentedTextWriter writer)
	{
		block = new NamedBlock(writer, "unsafe");
	}

	public void Dispose()
	{
		block.Dispose();
	}
}
