Imports System.Drawing.Printing
Imports System.Management

Public Class Impresoras

    Public ImpresoraPredeterminada As Object

    Public Function detectarImpresoras() As Boolean
        Dim cont As Integer = 0

        For Each impresoras In PrinterSettings.InstalledPrinters
            cont += 1
            lstLImpresoras.Items.Add(impresoras.ToString)
        Next
        If cont > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If detectarImpresoras() Then
            MsgBox("Estas son las impresoras existentes")
        End If
    End Sub

    Private Sub lstLImpresoras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLImpresoras.SelectedIndexChanged
        Dim nombreImpresora As String = lstLImpresoras.GetItemText(lstLImpresoras.SelectedItem)
        If MessageBox.Show("Desea que la impresora " + nombreImpresora + vbCrLf + " sea la impresora", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
            lstPropiedades.Clear()
            Dim comando As String = String.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", nombreImpresora)
            Dim consulta As New ManagementObjectSearcher(comando)
            Dim coll = consulta.Get()
            Dim impresora As ManagementObject
            For Each impresora In coll
                For Each dato In impresora.Properties
                    If dato.Name.Equals("Default") Then
                        dato.Value = True
                    End If
                    lstPropiedades.Items.Add(String.Format("{0}: {1}", dato.Name, dato.Value))
                Next
            Next
        End If
    End Sub

    Private Sub lstLImpresoras_DoubleClick(sender As Object, e As EventArgs) Handles lstLImpresoras.DoubleClick
        Dim nombreImpresora As String = lstLImpresoras.GetItemText(lstLImpresoras.SelectedItem)
        If Not InputBox("¿Desea cambiar el nombre de la matriz?", "Nombre Matriz", nombreImpresora).Equals(nombreImpresora) Then 'comparo si NO es igual 
            lstPropiedades.Clear()
            Dim comando As String = String.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", nombreImpresora)
            Dim consulta As New ManagementObjectSearcher(comando)
            Dim coll = consulta.Get()
            Dim impresora As ManagementObject
            For Each impresora In coll
                For Each dato In impresora.Properties
                    If dato.Name.Equals("Default") Then
                        dato.Value = True
                    End If
                    lstPropiedades.Items.Add(String.Format("{0}: {1}", dato.Name, dato.Value))
                Next
            Next
        End If
    End Sub
End Class