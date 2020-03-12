Module Struct_test
    Structure bang
        Dim door As Integer
        Dim engine As String
        Dim hp As Double
        Dim skylight As Boolean
    End Structure

    Sub Main()
        Dim test As bang
        test.door = 123
        test.engine = "引擎"
        test.hp = 51.25
        test.skylight = True
        Console.WriteLine("有" & test.door & "門")
        Console.WriteLine("引擎是" & test.engine)
        Console.WriteLine("馬力有" & test.hp & "匹")
        Console.WriteLine("天窗=" & test.skylight)
        Console.Read()




    End Sub

End Module
