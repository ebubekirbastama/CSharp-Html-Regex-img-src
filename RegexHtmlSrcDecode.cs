namespace ebstimecms
{
    public class kategoriler
    {
       public string  regexsrc(string EBSHtmlveri)
        {
            return Regex.Match(EBSHtmlveri, "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
        }
    }
}

