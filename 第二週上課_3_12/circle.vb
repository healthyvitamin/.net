Module circle

    Sub Main()
        Const PI As Double = 3.14159
        Console.WriteLine("請輸入半徑")
        Dim radius As Double = Console.ReadLine()
        Dim circumference As Double = radius * 2 * PI
        Dim area As Double = radius * radius * PI

        Console.Write("圓周:" & circumference)
        Console.Write("面積:" & area)
        Console.Read()


    End Sub

End Module
