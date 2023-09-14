using System.CodeDom.Compiler;
using System.Reflection;

namespace AssetRipper.Text.SourceGeneration.Tests;

public class DocumentationTests
{
	[Test]
	public void SummaryWithoutNewLines()
	{
		AssertCorrectOutput((writer) =>
		{
			writer.WriteSummaryDocumentation("This is a summary.");
		},
		"""
		/// <summary>
		/// This is a summary.
		/// </summary>
		
		""");
	}

	[Test]
	public void SummaryWithoutNewLinesButIndented()
	{
		AssertCorrectOutput((writer) =>
		{
			writer.Indent++;
			writer.WriteSummaryDocumentation("This is a summary.");
		},
		"""
			/// <summary>
			/// This is a summary.
			/// </summary>
		
		""");
	}

	[Test]
	public void SummaryWithNewLines()
	{
		AssertCorrectOutput((writer) =>
		{
			writer.Indent++;
			writer.WriteSummaryDocumentation("This is a summary.\r\nIt has a second line\rand a third line.\nA fourth line is here, too.");
		},
		"""
			/// <summary>
			/// This is a summary.<br />
			/// It has a second line<br />
			/// and a third line.<br />
			/// A fourth line is here, too.
			/// </summary>
		
		""");
	}

	private static void AssertCorrectOutput(Action<IndentedTextWriter> writeAction, string expectedOutput)
	{
		using StringWriter writer = new()
		{
			NewLine = "\n",
		};
		using IndentedTextWriter indentedWriter = new(writer, "\t")
		{
			NewLine = "\n",
		};
		typeof(IndentedTextWriter).GetField("_tabsPending", BindingFlags.NonPublic | BindingFlags.Instance)!.SetValue(indentedWriter, true);
		//https://github.com/dotnet/runtime/issues/92039
		writeAction(indentedWriter);
		Assert.That(writer.ToString(), Is.EqualTo(expectedOutput));
	}
}
