Module Enum_test
    Enum test As Integer
        VB = 1
        CSharp = 2
        CPlusDouble = 3
        JSharp = 4

    End Enum

    Sub Main()
        Console.WriteLine("VB =" & test.VB)
        Console.WriteLine("C# =" & test.CSharp)
        Console.WriteLine("C++ =" & test.CPlusDouble)
        Console.WriteLine("J# =" & test.JSharp)
        Console.Read()
    End Sub

End Module
