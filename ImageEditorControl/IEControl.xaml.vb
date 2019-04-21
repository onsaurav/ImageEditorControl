Public Class IEControl

    Private Sub UserControl_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

    End Sub

    Private Sub sliSaturtion_ValueChanged(sender As System.Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles sliSaturtion.ValueChanged
        Try
            tblSaturtion.Text = sliSaturtion.Value.ToString()
        Catch ex As Exception
            tblSaturtion.Text = ""
        End Try
    End Sub

    Private Sub sliContrast_ValueChanged(sender As System.Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles sliContrast.ValueChanged
        Try
            tblContrast.Text = sliContrast.Value.ToString()
        Catch ex As Exception
            tblContrast.Text = ""
        End Try
    End Sub

    Private Sub sliBrightness_ValueChanged(sender As System.Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles sliBrightness.ValueChanged
        Try
            tblBrightness.Text = sliBrightness.Value.ToString()
        Catch ex As Exception
            tblBrightness.Text = ""
        End Try
    End Sub

    Private Sub sliAdditive_ValueChanged(sender As System.Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles sliAdditive.ValueChanged
        Try
            tblAdditive.Text = sliAdditive.Value.ToString()
        Catch ex As Exception
            tblAdditive.Text = ""
        End Try
    End Sub

    Private Sub sliSaltAndPepper_ValueChanged(sender As System.Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles sliSaltAndPepper.ValueChanged
        Try
            tblSaltAndPepper.Text = sliSaltAndPepper.Value.ToString()
        Catch ex As Exception
            tblSaltAndPepper.Text = ""
        End Try
    End Sub

    Private Sub sliOilPainting_ValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles sliOilPainting.ValueChanged
        Try
            tblOilPainting.Text = sliOilPainting.Value.ToString()
        Catch ex As Exception
            tblOilPainting.Text = ""
        End Try
    End Sub

    Private Sub sliJitter_ValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles sliJitter.ValueChanged
        Try
            tblJitter.Text = sliJitter.Value.ToString()
        Catch ex As Exception
            tblJitter.Text = ""
        End Try
    End Sub

    Private Sub sliPixellate_ValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles sliPixellate.ValueChanged
        Try
            tblPixellate.Text = sliPixellate.Value.ToString()
        Catch ex As Exception
            tblPixellate.Text = ""
        End Try
    End Sub
End Class
