using System.Linq;

namespace FirstApplication
{
    public class Logic
    {
        public static string Sort(string Sentense)
        {
            string[] wordsArray = Sentense.Split(' ', ',', '.');
            int[] wordsLenghtArray = new int[wordsArray.Length];
            for (int i = 0; i < wordsLenghtArray.Length; i++)
            {
                wordsLenghtArray[i] = wordsArray[i].Length;
            }

            Array.Sort(wordsLenghtArray, wordsArray);
            Array.Reverse(wordsArray);
            
            string finalLine = String.Join(' ', wordsArray);

            return finalLine;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //НАЧАЛО взаимодейтсвия с пользователем
            Console.WriteLine("Введите ваше предложение:");
            var yourSentense = Console.ReadLine();
            //КОНЕЦ взаимодействия с пользователем

            //НАЧАЛО логики
            string outArray = Logic.Sort(yourSentense);
            //КОНЕЦ логики

            //НАЧАЛО взаимодейтсвия с пользователем
            Console.WriteLine("Ваше предложение было отсортированно в порядке убывания длин слов:");
            Console.WriteLine(outArray);
            Console.ReadLine();
            //КОНЕЦ взаимодейтсвия с пользователем
        }
    }
}

