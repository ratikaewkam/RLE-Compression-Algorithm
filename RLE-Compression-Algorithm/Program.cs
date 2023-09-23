namespace RLE_Compression_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aabbbccdeeefffff -> 16
            // 2a3b2c1d3e5f -> 12

            Console.Write(Encode("aabbbccdeeefffff") + " Length = ");
            Console.WriteLine(Encode("aabbbccdeeefffff").Length);
            Console.Write(Decode("2a3b2c1d3e5f")+" Length = ");
            Console.WriteLine(Decode("2a3b2c1d3e5f").Length);
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

        static string Decode(string text)
        {
            string decode_text = "";

            for (int i = 0; i < text.Length; i += 2)
            {
                for (int j = 0; j < Convert.ToInt32(text[i]-'0'); j++)
                {
                    decode_text += text[i + 1];
                }
            }

            return decode_text;
        }
    }
}