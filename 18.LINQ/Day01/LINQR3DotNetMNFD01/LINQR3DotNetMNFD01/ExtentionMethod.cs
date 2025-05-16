namespace LINQR3DotNetMNFD01
{
    // Extention Method
    // Class => static
    // Method => static
    // this
    public static class ExtentionMethod
    {
        /*-------------------------------------------------------------------------*/
        public static int GetWordsCount(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                int count = str.Split(' ').Length;
                return count;
            }
            return 0;
        }
        /*-------------------------------------------------------------------------*/
    }
}
