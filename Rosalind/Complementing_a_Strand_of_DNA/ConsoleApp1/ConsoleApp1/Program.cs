using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Program
    {
        static string Reverse(string text)
        // The reverse complement of a DNA string 's' is the string 'sc'
        // formed by reversing the symvbols of 's'.
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        static string ConvertToDNAComplement(string text)
        // In DNA strings, symbols 'A' and 'T'; are complements of each 
        // other, as are 'C' and 'G'.
        {
            char[] array = text.ToCharArray();
            string complementedString = "";

            foreach (char c in array)
            {
                if (c == 'A')
                {
                    complementedString += 'T';
                }
                else if (c == 'T')
                {
                    complementedString += 'A';
                }
                else if (c == 'C')
                {
                    complementedString += 'G';
                }
                else if (c == 'G')
                {
                    complementedString += 'C';
                }
            }

            return complementedString;
        }

        static void Main(string[] args)
        // Test dnaString = 'AAAACCCGGT', expect 'ACCGGGTTTT'
        {
            string dnaString = "TCGTCTTGCGCGTTTAAGGCGCGGAAAGTATTGTCCCGACCCTCGATGGACCCTGATATTAACCTCTGGGGCACTTTCTCCGAATCAGTTCATCATCTATACTTCCTTGTCTACCTAGTCATCTCTCGGTCTCCCAACGAGACAGTGGATCCCTGACTCAGTTTTTCTCAAACGAAGATGAATAAACAGCCGGCTCTGCTGTTGGCTAGGGCATGACGAATGGACGCCCACGTCTCCTGACCATGTTATGATTGAGAGACATGCGCGTGGCAAATCTCACTAAAGGCTACCTAGGAACTTAATGTGTAACCGTCCACTGTGTTAGACTCGATCAGCCGAACGGTAAGGTGGTGCACCCAAGCAACTCTGCGTGAGCAAGGCGTTCTCCGGCTCTTTCGGATCAAGTAATAGGCAGTTGGATAATGCGCCTAGCGCGGGAGAACTATGGTGAGGCCCTCACCTTCCGTGCGTCACTGTGATTCGTAATGGGATAGCATCGCACTGGATTATGGTCTACTGAGTATAATATCTCCTCCCTAAACAACCCTAGCTCACGCTGTCAGGCCCCCTGTATTGACTCATCACGACACCACAGCCTCGATTTGCATTGACCATTAGAACTTTAAGAATTGCTGGCACCACCGGGTGCGTAGCCTTCCCAGGCTGAGTTCAATTACTGTCACATGGGGTTCAGGCCCGTTTAAACTGAGTTTAATGGATTGACCACTCAGTGTCAACTTCTCGCTTTCTAAGATTGGGGTATGATAGCAGTGGTATTATTGCCAGTATCGGACGCCCGAGGACCGCGACGCTGGACGACTTACGGATTTAGTCTGCTTACT";
            string reversedString = Reverse(dnaString);
            string complementedString = ConvertToDNAComplement(reversedString);
            Console.WriteLine(complementedString);
            Console.ReadKey();
        }
    }
}
