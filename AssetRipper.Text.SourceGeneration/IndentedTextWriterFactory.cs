namespace AssetRipper.Text.SourceGeneration;

public static class IndentedTextWriterFactory
{
	/// <summary>
	/// Make a new <see cref="IndentedTextWriter"/>.
	/// </summary>
	/// <remarks>
	/// This writer uses <see cref="StreamWriter.AutoFlush"/>, LF line endings, and tab indentation.
	/// </remarks>
	/// <param name="directoryPath">The target directory of the file to create.</param>
	/// <param name="fileName">The name of the target file without any file extension.</param>
	/// <returns>An <see cref="IndentedTextWriter"/> for a newly created file at the location specified.</returns>
	public static IndentedTextWriter Create(string directoryPath, string fileName)
	{
		string path = Path.Combine(directoryPath, $"{fileName}.g.cs");
		Directory.CreateDirectory(directoryPath);
		FileStream stream = File.Create(path);
		return Create(stream);
	}

	/// <summary>
	/// Make a new <see cref="IndentedTextWriter"/>.
	/// </summary>
	/// <remarks>
	/// This writer uses <see cref="StreamWriter.AutoFlush"/>, LF line endings, and tab indentation.
	/// </remarks>
	/// <param name="stream">The stream to write to.</param>
	/// <returns>An <see cref="IndentedTextWriter"/> for the specified <paramref name="stream"/>.</returns>
	public static IndentedTextWriter Create(Stream stream)
	{
		StreamWriter streamWriter = new StreamWriter(stream)
		{
			NewLine = "\n",
			AutoFlush = true,
		};
		return Create(streamWriter);
	}

	/// <summary>
	/// Make a new <see cref="IndentedTextWriter"/>.
	/// </summary>
	/// <param name="writer">The <see cref="TextWriter"/> to use for output.</param>
	/// <returns>An <see cref="IndentedTextWriter"/> that outputs to the specified <paramref name="writer"/>.</returns>
	public static IndentedTextWriter Create(TextWriter writer)
	{
		return new IndentedTextWriter(writer, "\t")
		{
			NewLine = "\n",
		};
	}
}
