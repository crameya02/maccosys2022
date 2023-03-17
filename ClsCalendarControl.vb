Public Class ClsCalendarControl
    Inherits UserControl

    Public WithEvents _calendar As New MonthCalendar()


    Public Sub New()
        Me.Controls.Add(_calendar)
    End Sub

    Public Property SelectedDate As Date
        Get
            Return _calendar.SelectionStart
        End Get
        Set(value As Date)
            _calendar.SelectionStart = value
        End Set
    End Property

    Public Event DateSelected As EventHandler

    Private Sub _calendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles _calendar.DateSelected
        RaiseEvent DateSelected(Me, e)
    End Sub


End Class
