using System;
using System.IO;

namespace laba2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ADMIN\Documents\sergey\KPO\laba2_2\Butter.java";
            string line;
            string[] words;
            string result = " ";

            if(File.Exists(path)){    
                StreamReader stread = new StreamReader(path, System.Text.Encoding.Default);

                try {
                    Console.WriteLine();
                    Console.WriteLine("Файл {0}", Path.GetFileName(path));
                    Console.WriteLine();

                    using (stread){
                        while ((line = stread.ReadLine()) != null)
                        {
                            words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            int lengt = words.Length;
                            for (int i = 0; i<lengt; i++){
                                if (words[i] == "public")
                                    words[i] = "private";
                                result += (words[i] + " ");
                            }
                            result += "\n";
                        }
                    }
                    Console.WriteLine(result);
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                } finally {
                    try {
                        stread.Close();
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }
                }
            } else {
                Console.WriteLine("Файла {0} не существует.", Path.GetFileName(path));
            }
        }
    }
}