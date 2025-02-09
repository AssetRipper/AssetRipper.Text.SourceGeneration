namespace AssetRipper.Text.SourceGeneration;

public static class XmlFormatter
{
	public static string SeeCref(string cref) => $"<see cref=\"{cref}\"/>";
	public static string SeeHref(string href) => $"<see href=\"{href}\"/>";
	public static string SeeHref(string href, string text) => $"<see href=\"{href}\">{text}</see>";
	public static string SeeLangword(string langword) => $"<see langword=\"{langword}\"/>";

	public static string SeeAlsoCref(string cref) => $"<seealso cref=\"{cref}\"/>";
	public static string SeeAlsoHref(string href) => $"<seealso href=\"{href}\"/>";
	public static string SeeAlsoHref(string href, string text) => $"<seealso href=\"{href}\">{text}</seealso>";
	public static string SeeAlsoLangword(string langword) => $"<seealso langword=\"{langword}\"/>";
}
