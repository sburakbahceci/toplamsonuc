Imports System

Module Program
    Sub Main(args As String())
        Dim sayi As Integer
        Dim toplam As Integer
        Dim tuslar As ConsoleKeyInfo
        Do
            Console.Write("Bir Sayý Girin:")
            sayi = Console.ReadLine()
            toplam += sayi
            Console.WriteLine("Toplam={0}", toplam)
            Console.WriteLine("Sayi girmeye devam edecek misin? <Enter><Escape>")
            tuslar = Console.ReadKey()
        Loop While tuslar.Key <> ConsoleKey.Escape

    End Sub
End Module
