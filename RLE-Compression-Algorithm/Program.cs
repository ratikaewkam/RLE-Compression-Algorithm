namespace RLE_Compression_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aabbbccdeeefffff -> 16
            // 2a3b2c1d3e5f -> 12

            Console.WriteLine(Encode("aabbbccdeeefffff"));
        }

        static string Encode(string text)
        {
            text += " ";
            string encode_text = "";
            int num = 1;

            for (int i=0;i<text.Length-1;i++)
            {
                if (text[i] == text[i + 1])
                {
                    num++;
                }
                else
                {
                    encode_text += num.ToString() + text[i];
                    num = 1;
                }

            }

            return encode_text;
        }
    }
}