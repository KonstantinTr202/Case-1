using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

public class Reader
{
    public static int _markA;
    public static int _markB;
    public static int _markC;
    public void Read()
    {
        string digit = "";
        string fileFolderPath = @"C:\Users\Maksim\source\repos\Case 1\Case 1\Plan.txt";
        bool B = false;
        bool C = false;
        StreamReader sr = new StreamReader(fileFolderPath);
        string text = File.ReadAllText(fileFolderPath);


        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsDigit(text[i]) && B == false && C == false)
            {
                digit += text[i];
            }
            if (text[i] == 'B')
            {
                _markA = Convert.ToInt32(digit);
                digit = "";
                B = true;
            }
            if (char.IsDigit(text[i]) && B == true)
            {
                digit += text[i];
            }
            if (text[i] == 'C')
            {
                _markB = Convert.ToInt32(digit);
                digit = "";
                C = true;
                B = false;
            }
            if (char.IsDigit(text[i]) && C == true)
            {
                digit += text[i];
                _markC = Convert.ToInt32(digit);
            }
        }
    }
}
    


