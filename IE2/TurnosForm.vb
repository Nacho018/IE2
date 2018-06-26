Public Class TurnosForm

    Dim operacion_ As String
    Dim MiTurno As New Turnos

    Public Property operacion() As String
        Get
            Return operacion_


        End Get

        Set(ByVal value As String)

            operacion_ = value

        End Set



    End Property


    Dim indice_ As Byte
    Public Property indice() As String
        Get
            Return indice_

        End Get
        Set(ByVal value As String)
            indice_ = value

        End Set

    End Property


    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub

    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        If ComboBox1.Text = ComboBox2.Text Or ComboBox1.Text = ComboBox3.Text Or ComboBox2.Text = ComboBox3.Text Then


            MsgBox("Error")

            Exit Sub



        End If
        MiTurno.Id = CInt(TextBox1.Text)


        MiTurno.Fecha = CDate(TextBox2.Text)

        MiTurno.Asign = TextBox3.Text



        MiTurno.Doc = (ComboBox1.SelectedItem)



        MiTurno.Vocal1 = (ComboBox2.SelectedItem)


        MiTurno.Vocal2 = (ComboBox3.SelectedItem)


        Select Case operacion_

            Case "Agregar"

                lst.Add(MiTurno)

            Case "Eliminar"


                lst.RemoveAt(indice_)

            Case "Modificar"

                lst.Item(indice_) = MiTurno





                TurnosGrilla.DataGridView1.Refresh()

        End Select



        Me.Close()

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then


            e.Handled = True


        End If





    End Sub

    Private Sub TurnosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each Item As String In ComboBox1.Items






        Next


    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" And Not e.KeyChar = "/" And Not e.KeyChar = "," And Not e.KeyChar = "." And Not e.KeyChar = ";" Then



            e.Handled = True



            Exit Sub

        End If


        Dim pos As Integer = TextBox2.SelectionStart





        If pos <> 2 And pos <> 5 And (e.KeyChar = "-" Or e.KeyChar = "/" Or e.KeyChar = "." Or e.KeyChar = "," Or e.KeyChar = ";") Then





            e.Handled = True





            Exit Sub

        End If



        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then

            e.Handled = True
            Exit Sub

        End If


        'If TextBox2.Text < 26 / 6 / 2018 Then




        '    MsgBox("Fecha caducada")
        'End If

    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = True


        End If

    End Sub

 

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress


        e.Handled = True


    End Sub




    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress


        e.Handled = True


    End Sub


    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress


        e.Handled = True


    End Sub
End Class
