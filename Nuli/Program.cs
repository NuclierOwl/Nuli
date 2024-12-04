class Proga
{
    public static void Main() // основная часть
    {
        Console.WriteLine("Нужны цыфры: ");
        int[] n = Array.ConvertAll(Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries), int.Parse); //сюда вводят значения игнорируя " ", ",", ";"
        Peredvizenie(n);
        Console.WriteLine("Итоговый массив: " + string.Join(" ", n));
    }
    public static int[] Peredvizenie(int[] nums) // пернгонщик нулей в конец
    {
        int poslednee = 0;
        for (int i = 0; i < nums.Length; i++) // перенос всего что не "0" в начало
        {
            if (nums[i] != 0)
            {
                nums[poslednee] = nums[i];
                poslednee++;
            }
        }
        for (int i = poslednee; i < nums.Length; i++) // заполнение остатка нулями
        {
            nums[i] = 0;
        }
        return nums;
    }
}