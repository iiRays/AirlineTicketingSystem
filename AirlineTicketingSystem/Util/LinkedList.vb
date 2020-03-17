Public Class LinkedList(Of T)
    Public Top As LinkedNode(Of T)
    Public Size As Integer

    Public Sub New()
        Size = 0
    End Sub

    Public Function [Get](Tag As String) As T
        Dim temp = Top

        For counter As Integer = 1 To Size Step 1
            If temp.Tag.Equals(Tag) Then
                Return temp.Data
            End If
            temp = temp.Next
        Next

        Return Nothing
    End Function

    Public Function IndexOf(Tag As String) As Integer
        Dim temp = Top

        For counter As Integer = 1 To Size Step 1
            If temp.Tag.Equals(Tag) Then
                Return counter
            End If
            temp = temp.Next
        Next

        Return -1
    End Function

    Public Sub Delete(Tag As String)
        Dim temp = Top
        Dim previous As New LinkedNode(Of T)()

        If Size = 1 And temp.Tag.Equals(Tag) Then
            Clear()
        ElseIf (Size = 2 And temp.Next.Tag.Equals(Tag)) Then
            temp.Next = Nothing
            Size -= 1
        Else 'If got more than 2 items
            For counter As Integer = 1 To Size Step 1
                If temp.Next.Tag.Equals(Tag) Then 'If the next item is to be deleted
                    'Replace the next item with the one after
                    temp.Next = temp.Next.Next
                    Size -= 1
                    Return
                End If
                temp = temp.Next
            Next

        End If

        Return

    End Sub

    Public Sub Add(Tag As String, Item As Object)
        If (IsEmpty()) Then
            'List is empty
            Top = New LinkedNode(Of T)(Tag, Item)
        ElseIf (Size = 1) Then
            'List has 1 item
            Top.Next = New LinkedNode(Of T)(Tag, Item)
        Else
            'List is not empty
            Dim temp = Top

            'Loop until last item
            For i As Integer = 1 To Size Step 1
                'Same as for(i=i;i<=Size;i++)
                temp = temp.Next
            Next

            'Append at the end
            temp.Next = New LinkedNode(Of T)(Tag, Item)

        End If
    End Sub

    Public Sub Clear()
        Size = 0
        Top = Nothing
    End Sub

    Public Function IsEmpty() As Boolean
        If (Size = 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Class LinkedNode(Of T)
        Public [Next] As LinkedNode(Of T)
        Public Tag As String
        Public Data As Object

        Public Sub New()

        End Sub

        Public Sub New(Tag As String, Data As Object)
            Me.Data = Data
            Me.Tag = Tag
        End Sub
    End Class
End Class
