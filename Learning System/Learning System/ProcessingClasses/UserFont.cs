using iText.Kernel.Font;


namespace Learning_System.ProcessingClasses
{
    internal class UserFont
    {
        public static PdfFont GetFont(string userFont)
        {
            try
            {
                if (userFont == "BOLD ITALIC")
                    return PdfFontFactory.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\TimesBI.TTF", "Identity-H");
                else if (userFont == "BOLD")
                    return PdfFontFactory.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\TimesBD.TTF", "Identity-H");
                else if (userFont == "ITALIC")
                    return PdfFontFactory.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\TimesI.TTF", "Identity-H");
                else if (userFont == "REGULAR")
                    return PdfFontFactory.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\Times.TTF", "Identity-H");
                else
                    throw new Exception();
            }
            catch
            {
                return PdfFontFactory.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\Times.TTF", "Identity-H");
            }
        }
    }
}
