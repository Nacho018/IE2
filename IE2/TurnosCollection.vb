﻿
Imports System.ComponentModel

Public Class TurnosCollection


    Inherits BindingList(Of Turnos)



    Protected Overrides Sub onAddingNew(ByVal e As AddingNewEventArgs)


        e.NewObject = New Turnos()



    End Sub


End Class
