Dim Merah, M1, M2, M3, M4, M5, M6, M7, M8, M9 As Boolean
Dim Hitam, H1, H2, H3, H4, H5, H6, H7, H8, H9 As Boolean
Dim Point_Merah As Integer
Dim Point_Hitam As Integer

Function Hidden()
    Shape1.Visible = False
    Shape2.Visible = False
    Shape3.Visible = False
    Shape4.Visible = False
    Shape5.Visible = False
    Shape6.Visible = False
    Shape7.Visible = False
    Shape8.Visible = False
    Shape9.Visible = False
    M1 = False : M2 = False : M3 = False : M4 = False
    M5 = False : M6 = False : M7 = False : M8 = False : M9 = False
    H1 = False : H2 = False : H3 = False : H4 = False
    H5 = False : H6 = False : H7 = False : H8 = False : H9 = False
End Function

Private Sub Command1_Click()
    Hidden()
    Point_Merah = 0
    Point_Hitam = 0
End Sub

Private Sub Command2_Click()
    End
End Sub

Private Sub Form_Load()
    Merah = True
    Hitam = False
    Shape1.Visible = False
    Shape2.Visible = False
    Shape3.Visible = False
    Shape4.Visible = False
    Shape5.Visible = False
    Shape6.Visible = False
    Shape7.Visible = False
    Shape8.Visible = False
    Shape9.Visible = False
End Sub

Private Sub Image1_Click()
    If Merah = True And Shape1.Visible = False Then
        Shape1.Visible = True
        Shape1.BackColor = vbRed
        M1 = True
        Hitam = True
        Merah = False
        Exit Sub
    End If

    If Hitam = True And Shape1.Visible = False Then
        Shape1.Visible = True
        Shape1.BackColor = vbBlack
        H1 = True
        Merah = True
        Hitam = False
        Exit Sub
    End If

End Sub

Private Sub Image2_Click()
    If Merah = True And Shape2.Visible = False Then
        Shape2.Visible = True
        Shape2.BackColor = vbRed
        M2 = True
        Hitam = True
        Merah = False
        Exit Sub
    End If

    If Hitam = True And Shape2.Visible = False Then
        Shape2.Visible = True
        Shape2.BackColor = vbBlack
        H2 = True
        Merah = True
        Hitam = False
        Exit Sub
    End If

End Sub

Private Sub Image3_Click()
    If Merah = True And Shape3.Visible = False Then
        Shape3.Visible = True
        Shape3.BackColor = vbRed
        M3 = True
        Hitam = True
        Merah = False
        Exit Sub
    End If

    If Hitam = True And Shape3.Visible = False Then
        Shape3.Visible = True
        Shape3.BackColor = vbBlack
        H3 = True
        Merah = True
        Hitam = False
        Exit Sub
    End If

End Sub

Private Sub Image4_Click()
    If Merah = True And Shape4.Visible = False Then
        Shape4.Visible = True
        Shape4.BackColor = vbRed
        M4 = True
        Hitam = True
        Merah = False
        Exit Sub
    End If

    If Hitam = True And Shape4.Visible = False Then
        Shape4.Visible = True
        Shape4.BackColor = vbBlack
        H4 = True
        Merah = True
        Hitam = False
        Exit Sub
    End If

End Sub

Private Sub Image5_Click()
    If Merah = True And Shape5.Visible = False Then
        Shape5.Visible = True
        Shape5.BackColor = vbRed
        M5 = True
        Hitam = True
        Merah = False
        Exit Sub
    End If

    If Hitam = True And Shape5.Visible = False Then
        Shape5.Visible = True
        Shape5.BackColor = vbBlack
        H5 = True
        Merah = True
        Hitam = False
        Exit Sub
    End If

End Sub

Private Sub Image6_Click()
    If Merah = True And Shape6.Visible = False Then
        Shape6.Visible = True
        Shape6.BackColor = vbRed
        M6 = True
        Hitam = True
        Merah = False
        Exit Sub
    End If

    If Hitam = True And Shape6.Visible = False Then
        Shape6.Visible = True
        Shape6.BackColor = vbBlack
        H6 = True
        Merah = True
        Hitam = False
        Exit Sub
    End If

End Sub

Private Sub Image7_Click()
    If Merah = True And Shape7.Visible = False Then
        Shape7.Visible = True
        Shape7.BackColor = vbRed
        M7 = True
        Hitam = True
        Merah = False
        Exit Sub
    End If

    If Hitam = True And Shape7.Visible = False Then
        Shape7.Visible = True
        Shape7.BackColor = vbBlack
        H7 = True
        Merah = True
        Hitam = False
        Exit Sub
    End If

End Sub

Private Sub Image8_Click()
    If Merah = True And Shape8.Visible = False Then
        Shape8.Visible = True
        Shape8.BackColor = vbRed
        M8 = True
        Hitam = True
        Merah = False
        Exit Sub
    End If

    If Hitam = True And Shape8.Visible = False Then
        Shape8.Visible = True
        Shape8.BackColor = vbBlack
        H8 = True
        Merah = True
        Hitam = False
        Exit Sub
    End If

End Sub

Private Sub Image9_Click()
    If Merah = True And Shape9.Visible = False Then
        Shape9.Visible = True
        Shape9.BackColor = vbRed
        M9 = True
        Hitam = True
        Merah = False
        Exit Sub
    End If

    If Hitam = True And Shape9.Visible = False Then
        Shape9.Visible = True
        Shape9.BackColor = vbBlack
        H9 = True
        Merah = True
        Hitam = False
        Exit Sub
    End If

End Sub

Private Sub Timer1_Timer()
    If M1 = True And M2 = True And M3 = True Then
        MsgBox("Pemain Merah yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Merah = Point_Merah + 1
        Timer1.Enabled = True
    End If

    If M4 = True And M5 = True And M6 = True Then
        MsgBox("Pemain Merah yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Merah = Point_Merah + 1
        Timer1.Enabled = True
    End If

    If M7 = True And M8 = True And M9 = True Then
        MsgBox("Pemain Merah yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Merah = Point_Merah + 1
        Timer1.Enabled = True
    End If

    If M1 = True And M5 = True And M9 = True Then
        MsgBox("Pemain Merah yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Merah = Point_Merah + 1
        Timer1.Enabled = True
    End If

    If M1 = True And M4 = True And M7 = True Then
        MsgBox("Pemain Merah yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Merah = Point_Merah + 1
        Timer1.Enabled = True
    End If

    If M3 = True And M5 = True And M7 = True Then
        MsgBox("Pemain Merah yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Merah = Point_Merah + 1
        Timer1.Enabled = True
    End If

    If M3 = True And M6 = True And M9 = True Then
        MsgBox("Pemain Merah yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Merah = Point_Merah + 1
        Timer1.Enabled = True
    End If

    If M2 = True And M5 = True And M8 = True Then
        MsgBox("Pemain Merah yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Merah = Point_Merah + 1
        Timer1.Enabled = True
    End If

    If H1 = True And H2 = True And H3 = True Then
        MsgBox("Pemain Hitam yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Hitam = Point_Hitam + 1
        Timer1.Enabled = True
    End If

    If H4 = True And H5 = True And H6 = True Then
        MsgBox("Pemain Hitam yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Hitam = Point_Hitam + 1
        Timer1.Enabled = True
    End If

    If H7 = True And H8 = True And H9 = True Then
        MsgBox("Pemain Hitam yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Hitam = Point_Hitam + 1
        Timer1.Enabled = True
    End If

    If H1 = True And H5 = True And H9 = True Then
        MsgBox("Pemain Hitam yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Hitam = Point_Hitam + 1
        Timer1.Enabled = True
    End If

    If H1 = True And H4 = True And H7 = True Then
        MsgBox("Pemain Hitam yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Hitam = Point_Hitam + 1
        Timer1.Enabled = True
    End If

    If H3 = True And H5 = True And H7 = True Then
        MsgBox("Pemain Hitam yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Hitam = Point_Hitam + 1
        Timer1.Enabled = True
    End If

    If H3 = True And H6 = True And H9 = True Then
        MsgBox("Pemain Hitam yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Hitam = Point_Hitam + 1
        Timer1.Enabled = True
    End If

    If H2 = True And H5 = True And H8 = True Then
        MsgBox("Pemain Hitam yang Menang", vbOKOnly)
        Timer1.Enabled = False
        Hidden()
        Point_Hitam = Point_Hitam + 1
        Timer1.Enabled = True
    End If

End Sub

Private Sub Timer2_Timer()
    Label1.Caption = Point_Merah
    Label2.Caption = Point_Hitam
End Sub