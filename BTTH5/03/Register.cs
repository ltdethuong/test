using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPass.Text;
            string repass = txtRepass.Text;

            if (!System.IO.File.Exists("user.txt"))
                System.IO.File.Create("user.txt");
            string[] user_pass_str = System.IO.File.ReadAllLines("user.txt");
            bool is_ok = true;
           // int is_ok = 1; // 0 ok , 1 wrong user, 2 wrong pass
            foreach (var line in user_pass_str)
            {
                string[] subs = line.Split('|');
                if(username.CompareTo(subs[0]) == 0)
                {
                    
                    break;
                }
            }

            if(!is_ok)
            {
                MessageBox.Show("");
            }
            else
            {
                if(password.CompareTo(repass) == 0)
                {
                    using (MD5 md5 = MD5.Create())
                    {
                        string hash = GetMd5Hash(md5, password);

                       // System.IO.File.AppendAllLines("user.txt",)
                    }
                }
            }
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
