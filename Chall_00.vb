'BROKEN CODE

'imports
Imports Microsoft.VisualBasic.FileIO
Module Chall_00
    Structure Matrix
        Dim Boy() As String
        Dim Girl() As String
    End Structure

    Sub Main()
        'declaracion de variables ¿?
        Dim menu As Byte
        Dim Matrix As Matrix
        Dim limit As Integer
        'precarga de las matrices
        '------------------------
        'CHICO
        '_________________________________________________________________________________
        limit = IO.File.ReadAllLines("C:\Users\Marin\Documents\Visual Studio 2015\Projects\G\B.txt").Length 'chequea y pone el limite a la matriz de nombres
        ReDim Matrix.Boy(0 To limit)

        Using reader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Marin\Documents\Visual Studio 2015\Projects\G\B.txt") 'lee l archivo de texto y asigna cada nombre a un slot de la matriz
            reader.TextFieldType = FileIO.FieldType.Delimited
            reader.SetDelimiters("  ")

            Do
                Try
                    Matrix.Boy(reader.LineNumber) = reader.ReadLine()
                Catch ex As Exception
                    Console.WriteLine("Petó, RIP el sueño")
                End Try
            Loop Until reader.EndOfData = True
        End Using
        For i As Integer = 0 To UBound(Matrix.Boy) 'recorta los dos espacios al final de cada nombre
            Try
                Matrix.Boy(i) = Matrix.Boy(i).Trim
            Catch ex As Exception
                Exit For
            End Try
        Next

        'CHICA
        '___________________________________________________________________________________
        limit = IO.File.ReadAllLines("C:\Users\Marin\Documents\Visual Studio 2015\Projects\G\G.txt").Length 'chequea y pone el limite a la matriz de nombres
        ReDim Matrix.Girl(0 To limit)

        Using reader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Marin\Documents\Visual Studio 2015\Projects\G\G.txt") 'lee l archivo de texto y asigna cada nombre a un slot de la matriz
            reader.TextFieldType = FileIO.FieldType.Delimited
            reader.SetDelimiters("  ")

            Do
                Try
                    Matrix.Girl(reader.LineNumber) = reader.ReadLine()
                Catch ex As Exception
                    Console.WriteLine("Petó, RIP el sueño")
                End Try
            Loop Until reader.EndOfData = True
        End Using
        For i As Integer = 0 To UBound(Matrix.Girl) ' recorta los dos espacios al final de cada nombre
            Try
                Matrix.Girl(i) = Matrix.Girl(i).Trim
            Catch ex As Exception
                Exit For
            End Try
        Next
        'saludo
        Console.WriteLine("Bienvenido a nuestro generador de nombres aleatorios:")

        'bucle general del programa
        Do
            'seleccion de opcion
            Console.WriteLine("[HOMBRE {1} | MUJER {2} | SALIR {3}]")
            Console.Write(">>")
            menu = Console.ReadLine()

            'seleccion interna de la opcion escogida
            Select Case menu
                Case 1
                    'GENERADOR NOMBRES CHICO
                    For i As Integer = 0 To UBound(Matrix.Boy)
                        Console.WriteLine(Matrix.Boy(i))
                    Next
                Case 2
                    'GENERADOR NOMBRES CHICA
                Case 3
                    'SALIDA DEL PROGRAMA
                    Dim salida As String
                    Console.WriteLine("¿Seguro? [S/N]")
                    Console.Write(">>")
                    salida = Console.ReadLine()

                    If salida = "S" Or salida = "s" Then
                        Exit Sub
                    End If
                Case Else
                    Console.WriteLine("<Inserte opcion valida>")
            End Select
        Loop Until 1 = 0
    End Sub

End Module
