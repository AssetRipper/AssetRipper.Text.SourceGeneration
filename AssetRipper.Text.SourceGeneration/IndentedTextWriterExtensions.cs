﻿namespace AssetRipper.Text.SourceGeneration;

public static class IndentedTextWriterExtensions
{
	/// <summary>
	/// Auto-generated code. Do not modify manually.
	/// </summary>
	/// <param name="writer"></param>
	public static void WriteGeneratedCodeWarning(this IndentedTextWriter writer) => writer.WriteComment("Auto-generated code. Do not modify manually.");
	public static void WriteUsing(this IndentedTextWriter writer, string @namespace) => writer.WriteLine($"using {@namespace};");
	public static void WriteGlobalUsing(this IndentedTextWriter writer, string @namespace) => writer.WriteLine($"global using {@namespace};");
	public static void WriteFileScopedNamespace(this IndentedTextWriter writer, string @namespace) => writer.WriteLine($"namespace {@namespace};");
	public static void WriteLineNoTabs(this IndentedTextWriter writer) => writer.WriteLineNoTabs(null);
	public static void WriteComment(this IndentedTextWriter writer, string comment) => writer.WriteLine($"// {comment}");
	public static void WriteSummaryDocumentation(this IndentedTextWriter writer, string summary) => writer.WriteXmlDocumentation("summary", summary);
	public static void WriteRemarksDocumentation(this IndentedTextWriter writer, string remarks) => writer.WriteXmlDocumentation("remarks", remarks);
	public static void WriteParameterDocumentation(this IndentedTextWriter writer, string parameterName, string parameterDescription)
	{
		writer.WriteLine($"/// <param name=\"{parameterName}\">{parameterDescription}</param>");
	}
	public static void WriteReturnsDocumentation(this IndentedTextWriter writer, string description)
	{
		writer.WriteLine($"/// <returns>{description}</returns>");
	}
	private static void WriteXmlDocumentation(this IndentedTextWriter writer, string tag, string content)
	{
		writer.WriteLine($"/// <{tag}>");
		if (content.Contains('\n') || content.Contains('\r'))
		{
			string[] lines = content.Split(NewLineSeparators, StringSplitOptions.None);
			for (int i = 0; ; i++)
			{
				if (i == lines.Length - 1)
				{
					writer.WriteLine($"/// {lines[i]}");
					break;
				}
				else
				{
					writer.WriteLine($"/// {lines[i]}<br />");
				}
			}
		}
		else
		{
			writer.WriteLine($"/// {content}");
		}
		writer.WriteLine($"/// </{tag}>");
	}

	private static readonly string[] NewLineSeparators = ["\r\n", "\r", "\n"];
}
