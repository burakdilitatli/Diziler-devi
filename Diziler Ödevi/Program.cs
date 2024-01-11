namespace Diziler_Ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Aralığın ilk sayısını giriniz");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine("Aralığın son sayısını giriniz");
                int last = int.Parse(Console.ReadLine());

                if (first < last)
                {
                    while (true)
                    {
                        Console.WriteLine("Toplam kaç tane sayı sıralansın?");
                        int quantity = int.Parse(Console.ReadLine());

                        if (quantity > 0 && quantity <= (last - first + 1))
                        {
                            Random random = new Random();
                            int[] arr = new int[quantity];

                            for (int i = 0; i < quantity;)
                            {
                                int uni = random.Next(first, last + 1);
                                int j;

                                for (j = 0; j < i; j++)
                                {
                                    if (arr[j] == uni)
                                    {
                                        break;
                                    }
                                }

                                if (j == i)
                                {
                                    arr[i] = uni;
                                    i++;
                                }
                            }

                            Array.Sort(arr);

                            for (int i = 0; i < quantity; i++)
                            {
                                Console.WriteLine(arr[i]);
                            }
                            break;
                        }
                        else if (quantity > (last - first + 1))
                        {
                            Console.WriteLine("Sıralanan sayı adedi aralıktan fazla olamaz, lütfen aralık dahilinde sayı adedi giriniz");
                        }
                        else
                        {
                            Console.WriteLine("Yalnızca 0'dan büyük sayılar girilebilir");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("İlk sayı son sayıdan büyük veya aynı olamaz, lütfen başka bir sayı giriniz");
                }

                Console.WriteLine("Devam etmek için 'E' tuşuna, çıkmak için başka bir tuşuna basın");
                if (Console.ReadLine() != "E")
                {
                    break;
                }
            }
        }
    }
}