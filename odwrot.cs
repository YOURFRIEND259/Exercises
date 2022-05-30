public class Odwrot
{
            public static void Reverse()
        {
            Console.WriteLine("give string to revese: \n");
            var sting=Console.ReadLine();
            char[] charArray=sting!.ToCharArray();
            for(int i=0, j=sting.Length-1; i<j; i++, j--)
            {
                charArray[i]=sting[j];
                charArray[j]=sting[i];
            }
            string reverse=new string (charArray);
            Console.WriteLine(reverse+"\n");
            
        }
}