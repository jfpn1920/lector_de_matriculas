Imports System
Module lector_de_matriculas
    Sub Main(args As String())
        Dim ids(19) As Integer
        Dim matriculas(19) As String
        Dim propietarios(19) As String
        Dim tipos(19) As String
        Dim marcas(19) As String
        Dim modelos(19) As Integer
        Dim colores(19) As String
        Dim estados(19) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-----------------------------------------'
        '--|menu_principal_lector_de_matriculas|--'
        '-----------------------------------------'
        Do
            Console.WriteLine("menu principal lector de matriculas")
            Console.WriteLine("1) Registrar matricula")
            Console.WriteLine("2) Editar matricula")
            Console.WriteLine("3) Listar matriculas")
            Console.WriteLine("4) Buscar matricula")
            Console.WriteLine("5) Eliminar matricula")
            Console.WriteLine("6) Leer matricula")
            Console.WriteLine("7) Mostrar resumen")
            Console.WriteLine("8) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-------------------------'
                '--|registrar_matricula|--'
                '-------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas matriculas.")
                    Else
                        Console.Write("Ingrese la matricula: ")
                        Dim nuevaMatricula As String = Console.ReadLine()
                        If nuevaMatricula = "" Then
                            Console.WriteLine("La matricula no puede estar vacia.")
                        Else
                            Dim matriculaExiste As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If matriculas(i).ToLower() = nuevaMatricula.ToLower() Then
                                    matriculaExiste = True
                                End If
                            Next
                            If matriculaExiste Then
                                Console.WriteLine("No se puede registrar. La matricula ya existe.")
                            Else
                                Console.Write("Ingrese el propietario: ")
                                Dim nuevoPropietario As String = Console.ReadLine()
                                Console.Write("Ingrese el tipo de vehiculo: ")
                                Dim nuevoTipo As String = Console.ReadLine()
                                Console.Write("Ingrese la marca: ")
                                Dim nuevaMarca As String = Console.ReadLine()
                                Console.Write("Ingrese el modelo: ")
                                Dim nuevoModelo As Integer = Convert.ToInt32(Console.ReadLine())
                                If nuevoModelo < 1900 Then
                                    Console.WriteLine("El modelo no es valido.")
                                Else
                                    Console.Write("Ingrese el color: ")
                                    Dim nuevoColor As String = Console.ReadLine()
                                    ids(cantidad) = cantidad + 1
                                    matriculas(cantidad) = nuevaMatricula.ToUpper()
                                    propietarios(cantidad) = nuevoPropietario
                                    tipos(cantidad) = nuevoTipo
                                    marcas(cantidad) = nuevaMarca
                                    modelos(cantidad) = nuevoModelo
                                    colores(cantidad) = nuevoColor
                                    estados(cantidad) = "Registrado"
                                    cantidad += 1
                                    Console.WriteLine("Matricula registrada correctamente.")
                                    Console.WriteLine("ID: " & ids(cantidad - 1) & " | Matricula: " & matriculas(cantidad - 1) & " | Propietario: " & propietarios(cantidad - 1) & " | Tipo: " & tipos(cantidad - 1) & " | Marca: " & marcas(cantidad - 1) & " | Modelo: " & modelos(cantidad - 1) & " | Color: " & colores(cantidad - 1) & " | Estado: " & estados(cantidad - 1))
                                End If
                            End If
                        End If
                    End If
                '----------------------'
                '--|editar_matricula|--'
                '----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen matriculas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Matricula: " & matriculas(i) & " | Propietario: " & propietarios(i) & " | Tipo: " & tipos(i) & " | Marca: " & marcas(i) & " | Modelo: " & modelos(i) & " | Color: " & colores(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la matricula a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 AndAlso idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nueva matricula: ")
                            Dim nuevaMatricula As String = Console.ReadLine()
                            If nuevaMatricula = "" Then
                                Console.WriteLine("La matricula no puede estar vacia.")
                            Else
                                Dim matriculaExiste As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If i <> posicion AndAlso matriculas(i).ToLower() = nuevaMatricula.ToLower() Then
                                        matriculaExiste = True
                                    End If
                                Next
                                If matriculaExiste Then
                                    Console.WriteLine("No se puede actualizar. La matricula ya existe.")
                                Else
                                    matriculas(posicion) = nuevaMatricula.ToUpper()
                                    Console.Write("Nuevo propietario: ")
                                    propietarios(posicion) = Console.ReadLine()
                                    Console.Write("Nuevo tipo de vehiculo: ")
                                    tipos(posicion) = Console.ReadLine()
                                    Console.Write("Nueva marca: ")
                                    marcas(posicion) = Console.ReadLine()
                                    Console.Write("Nuevo modelo: ")
                                    Dim nuevoModelo As Integer = Convert.ToInt32(Console.ReadLine())
                                    If nuevoModelo < 1900 Then
                                        Console.WriteLine("El modelo no es valido.")
                                    Else
                                        modelos(posicion) = nuevoModelo
                                        Console.Write("Nuevo color: ")
                                        colores(posicion) = Console.ReadLine()
                                        Console.WriteLine("Matricula actualizada correctamente.")
                                        Console.WriteLine("ID: " & ids(posicion) & " | Matricula: " & matriculas(posicion) & " | Propietario: " & propietarios(posicion) & " | Tipo: " & tipos(posicion) & " | Marca: " & marcas(posicion) & " | Modelo: " & modelos(posicion) & " | Color: " & colores(posicion) & " | Estado: " & estados(posicion))
                                    End If
                                End If
                            End If
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-----------------------'
                '--|listar_matriculas|--'
                '-----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen matriculas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Matricula: " & matriculas(i) & " | Propietario: " & propietarios(i) & " | Tipo: " & tipos(i) & " | Marca: " & marcas(i) & " | Modelo: " & modelos(i) & " | Color: " & colores(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '----------------------'
                '--|buscar_matricula|--'
                '----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen matriculas registradas.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por matricula")
                        Console.WriteLine("3) Buscar por propietario")
                        Console.WriteLine("4) Buscar por marca")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 AndAlso idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Matricula: " & matriculas(posicion) & " | Propietario: " & propietarios(posicion) & " | Tipo: " & tipos(posicion) & " | Marca: " & marcas(posicion) & " | Modelo: " & modelos(posicion) & " | Color: " & colores(posicion) & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese la matricula: ")
                            Dim matriculaBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If matriculas(i).ToLower().Contains(matriculaBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Matricula: " & matriculas(i) & " | Propietario: " & propietarios(i) & " | Tipo: " & tipos(i) & " | Marca: " & marcas(i) & " | Modelo: " & modelos(i) & " | Color: " & colores(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron matriculas.")
                            End If
                        ElseIf tipoBusqueda = 3 Then
                            Console.Write("Ingrese el propietario: ")
                            Dim propietarioBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If propietarios(i).ToLower().Contains(propietarioBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Matricula: " & matriculas(i) & " | Propietario: " & propietarios(i) & " | Tipo: " & tipos(i) & " | Marca: " & marcas(i) & " | Modelo: " & modelos(i) & " | Color: " & colores(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron vehiculos de ese propietario.")
                            End If
                        ElseIf tipoBusqueda = 4 Then
                            Console.Write("Ingrese la marca: ")
                            Dim marcaBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If marcas(i).ToLower().Contains(marcaBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Matricula: " & matriculas(i) & " | Propietario: " & propietarios(i) & " | Tipo: " & tipos(i) & " | Marca: " & marcas(i) & " | Modelo: " & modelos(i) & " | Color: " & colores(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron vehiculos de esa marca.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '------------------------'
                '--|eliminar_matricula|--'
                '------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen matriculas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Matricula: " & matriculas(i) & " | Propietario: " & propietarios(i) & " | Tipo: " & tipos(i) & " | Marca: " & marcas(i) & " | Modelo: " & modelos(i) & " | Color: " & colores(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la matricula a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 AndAlso idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                matriculas(i) = matriculas(i + 1)
                                propietarios(i) = propietarios(i + 1)
                                tipos(i) = tipos(i + 1)
                                marcas(i) = marcas(i + 1)
                                modelos(i) = modelos(i + 1)
                                colores(i) = colores(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            matriculas(cantidad) = ""
                            propietarios(cantidad) = ""
                            tipos(cantidad) = ""
                            marcas(cantidad) = ""
                            modelos(cantidad) = 0
                            colores(cantidad) = ""
                            estados(cantidad) = ""
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Matricula eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------'
                '--|leer_matricula|--'
                '--------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen matriculas registradas.")
                    Else
                        Console.Write("Ingrese la matricula a leer: ")
                        Dim matriculaLeer As String = Console.ReadLine()
                        Dim encontrado As Boolean = False
                        For i As Integer = 0 To cantidad - 1
                            If matriculas(i).ToLower() = matriculaLeer.ToLower() Then
                                Console.WriteLine("Matricula encontrada.")
                                Console.WriteLine("ID: " & ids(i) & " | Matricula: " & matriculas(i) & " | Propietario: " & propietarios(i) & " | Tipo: " & tipos(i) & " | Marca: " & marcas(i) & " | Modelo: " & modelos(i) & " | Color: " & colores(i) & " | Estado: " & estados(i))
                                Console.WriteLine("1) Autorizar")
                                Console.WriteLine("2) Restringir")
                                Console.WriteLine("3) Mantener registrado")
                                Console.Write("Seleccione el nuevo estado: ")
                                Dim opcionEstado As Integer = Convert.ToInt32(Console.ReadLine())
                                Select Case opcionEstado
                                    Case 1
                                        estados(i) = "Autorizado"
                                    Case 2
                                        estados(i) = "Restringido"
                                    Case 3
                                        estados(i) = "Registrado"
                                    Case Else
                                        Console.WriteLine("Estado no valido.")
                                        Continue Do
                                End Select
                                Console.WriteLine("Estado actualizado correctamente.")
                                Console.WriteLine("ID: " & ids(i) & " | Matricula: " & matriculas(i) & " | Propietario: " & propietarios(i) & " | Tipo: " & tipos(i) & " | Marca: " & marcas(i) & " | Modelo: " & modelos(i) & " | Color: " & colores(i) & " | Estado: " & estados(i))
                                encontrado = True
                            End If
                        Next
                        If Not encontrado Then
                            Console.WriteLine("Matricula no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 7
                    If cantidad = 0 Then
                        Console.WriteLine("No existen matriculas registradas.")
                    Else
                        Dim registrados As Integer = 0
                        Dim autorizados As Integer = 0
                        Dim restringidos As Integer = 0
                        Dim automoviles As Integer = 0
                        Dim motocicletas As Integer = 0
                        Dim otros As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            If estados(i) = "Registrado" Then
                                registrados += 1
                            ElseIf estados(i) = "Autorizado" Then
                                autorizados += 1
                            ElseIf estados(i) = "Restringido" Then
                                restringidos += 1
                            End If
                            If tipos(i).ToLower() = "automovil" Then
                                automoviles += 1
                            ElseIf tipos(i).ToLower() = "motocicleta" Then
                                motocicletas += 1
                            Else
                                otros += 1
                            End If
                        Next
                        Console.WriteLine("Total de matriculas: " & cantidad)
                        Console.WriteLine("Vehiculos registrados: " & registrados)
                        Console.WriteLine("Vehiculos autorizados: " & autorizados)
                        Console.WriteLine("Vehiculos restringidos: " & restringidos)
                        Console.WriteLine("Automoviles: " & automoviles)
                        Console.WriteLine("Motocicletas: " & motocicletas)
                        Console.WriteLine("Otros vehiculos: " & otros)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 8
                    Console.WriteLine("Gracias por utilizar Lector de Matriculas.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 8
    End Sub
End Module