using System.Text;

public static class StringExtensions
{
    public static string SpacesForCamelCase(this string str)
    {
        StringBuilder sb = new();
        for (int i = 0; i < str.Length; i++)
        {
            if (i>0 && str[i] >= 'A' && str[i] <= 'Z')
            {
                sb.Append(' ');
            }
            sb.Append(str[i]);
        }
        return sb.ToString();
    }
}