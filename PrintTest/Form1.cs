using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           string str = "郭  楠";
           string str2 = "郭郭楠楠";
            string str1 = "陈 乾";
            string str3 = "郭郭楠";
            Console.WriteLine(str);
            Console.WriteLine(ToSBC(str));
            Console.WriteLine(str2);
            Console.WriteLine(str1);
            Console.WriteLine(ToSBC(str1));
            Console.WriteLine(ToSBC(str3));

        }
        private static string ToSBC(string input)
        {
            
           
            char[] chr = input.ToCharArray();
            for(int i = 0;i<chr.Length;i++)
            {
                if(chr[i]==32)
                {
                    chr[i] = (char)12288;
                    continue;
                }
                if(chr[i]<127)
                {
                    chr[i] = (char)(chr[i] + 65248);
                }
                

            }
             return new String(chr);
        }
       
    }
}
