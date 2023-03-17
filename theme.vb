Imports MaterialSkin
Module theme
    Public Sub myCustomSkinDark(frm As Form)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        With SkinManager
            .AddFormToManage(frm)
            .Theme = MaterialSkinManager.Themes.DARK
            .ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        End With
    End Sub
    Public Sub myCustomSkinLight(frm1 As Form)
        Dim SkinManager1 As MaterialSkinManager = MaterialSkinManager.Instance
        With SkinManager1
            .AddFormToManage(frm1)
            .Theme = MaterialSkinManager.Themes.DARK
            .ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        End With
    End Sub
End Module
