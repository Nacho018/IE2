Public Class TurnosGrilla





    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click


        TurnosForm.operacion = "Agregar"

        TurnosForm.Text = "Alta de turnos"

        TurnosForm.Show()


    End Sub



    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        If lst.Count = 0 Then Exit Sub

        TurnosForm.operacion = "Modificar"

        TurnosForm.Text = "Modificar datos"

        TurnosForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()

        TurnosForm.Show()


    End Sub





    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        If lst.Count = 0 Then Exit Sub
        TurnosForm.operacion = "Eliminar"

        TurnosForm.Text = "Elimina datos iva"

        TurnosForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()

        TurnosForm.Show()
    End Sub


    Private Sub LlenarForm()



        TurnosForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        TurnosForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TurnosForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        TurnosForm.ComboBox1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        TurnosForm.ComboBox2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        TurnosForm.ComboBox3.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
    End Sub


    Private Sub TurnosGrilla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = lst


    End Sub



    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()

    End Sub

End Class